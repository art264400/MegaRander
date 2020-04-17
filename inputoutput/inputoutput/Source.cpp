#include<iostream>
#include <fstream>
#include<string>

using namespace std;

int main()
{
	ofstream fout;
	fout.open("input.txt");
	fout << "dasdasads";
	fout.close();
	system("pause");
	return 0;
}