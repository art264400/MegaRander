#include <iostream>
#include <ostream>
#include <string>
#include <fstream>
#include <iterator>
#include <windows.h> // CharToOem
#include <boost/asio.hpp>
#include <boost/archive/iterators/base64_from_binary.hpp>
#include <boost/archive/iterators/transform_width.hpp>
namespace iters = boost::archive::iterators;
typedef boost::asio::ip::tcp tcp;
typedef iters::base64_from_binary<iters::transform_width<std::string::const_iterator, 6, 8>>
base64_t;

boost::asio::streambuf reqBuf, respBuf;
std::ostream reqStream(&reqBuf);
tcp::socket* psock;

void SendRequest(std::string s) {
	reqStream << s << "\r\n";
	boost::asio::write(*psock, reqBuf);
}

std::size_t PrintResponse() {
	std::size_t len = boost::asio::read_until(*psock, respBuf, "\r\n");
	std::cout << &respBuf;
	return len;
}

std::string Encode(const std::string& s) {
	return std::string(base64_t(s.begin()), base64_t(s.end()));
}

int main() {
	try {
		std::ifstream ifs("1.txt"); // прикреплённый файл
		if (!ifs) { std::cerr << "File not found\n"; return 1; }
		std::string str((std::istreambuf_iterator<char>(ifs)), std::istreambuf_iterator<char>()), encStr(Encode(str));
		ifs.close();
		// авторизация на ящик отправителя
		std::string login = "name1", encLogin(Encode((login))); //имя
		std::string passw = "passw1", encPassw(Encode(passw));  //пароль
		std::string host = "smtp.mail.ru"; // почтовый сервер
		boost::asio::io_service io;
		tcp::resolver resolver(io);
		tcp::resolver::query query(host, "25"); //default smtp port
		tcp::resolver::iterator endpoint_iterator = resolver.resolve(query);
		tcp::resolver::iterator end;
		tcp::socket sock(io);
		psock = &sock;
		boost::system::error_code error = boost::asio::error::host_not_found;
		while (error && endpoint_iterator != end) {
			sock.close();
			sock.connect(*endpoint_iterator++, error);
		}
		if (error) throw boost::system::system_error(error);
		PrintResponse();
		SendRequest("ehlo myhost");
		PrintResponse();
		SendRequest("auth login");//выбираем авторизацию по login
		PrintResponse();
		SendRequest(encLogin);
		PrintResponse();
		SendRequest(encPassw);
		PrintResponse();
		SendRequest("mail from:<name1@mail.ru>");//ящик отправителя
		PrintResponse();
		SendRequest("rcpt to:<name2@yandex.ru>");// ящик получателя
		PrintResponse();
		SendRequest("data");
		PrintResponse();
		SendRequest("from:<name1@mail.ru>");  //это
		SendRequest("to:<name2@yandex.ru>"); //не
		SendRequest("subject: Some subject"); //спам
		SendRequest("Mime-Version: 1.0");
		SendRequest("Content-Type: multipart/mixed; boundary=bound");
		SendRequest("\r\n--bound");
		SendRequest("Content-type: text/plain; charset=windows-1251");
		SendRequest("Content-Transfer-Encoding: quoted-printable\r\n");
		SendRequest("It's letter's text\r\nThis letter has attaching file.");//текст письма
		SendRequest("\r\n--bound");
		SendRequest("Content-Type: text/plain; name=file.txt");
		SendRequest("Content-Transfer-Encoding: base64");
		SendRequest("Content-Disposition: attachment\r\n");
		SendRequest(encStr);
		SendRequest("\r\n--bound--\r\n.");
		PrintResponse();
		SendRequest("quit");
		PrintResponse();
		sock.close();
	}
	catch (std::exception& e) {
		char buf[512];
		CharToOem(e.what(), buf);
		std::cout << "Exception: " << buf << "\n";
	}
	return 0;
}