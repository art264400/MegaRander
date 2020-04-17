#include<iostream>
#include<string>
#include<set>
#include<ctime>
using namespace std;

int main()
{
	unsigned int start_time = clock();
	//ios::sync_with_stdio(false);
	setlocale(0, "");
	string str;
	cin >> str;
	int n;
	cin >> n;
	if (n < 1 || n > 50000) return 0;
	int i1, i2, j1, j2;
	string answer = "";
	while (n) {
		//cin >> i1 >> j1 >> i2 >> j2;
		i1 = rand() % str.length() + 1;
		i2 = rand() % str.length() + 1;
		j1 = rand() % str.length() + 1;
		j2 = rand() % str.length() + 1;
		while (i1 > j1)
		{
		j1 = rand() % str.length() + 1;
		}
		while (i2 > j2)
		{
		j2 = rand() % str.length() + 1;
		}
		if (i1 < 1 || i1 > 50000) return 0;
		if (i2 < 1 || i2 > 50000) return 0;
		if (j1 < 1 || j1 > 50000) return 0;
		if (j2 < 1 || j2 > 50000) return 0;
		if (j1 - i1 != j2 - i2) { answer += "N"; n--; continue; }

		multiset <char> mls1;
		multiset <char> mls2;

		for (i1; i1 <= j1; i1++) {
			mls1.insert(str[i1 - 1]);
		}

		for (i2; i2 <= j2; i2++) {
			mls2.insert(str[i2 - 1]);
		}
		if (mls1 == mls2)
		{
			answer += "Y";
		}
		else { answer += "N"; }
		n--;
	}
	for (int i = 0; i <(int)answer.length(); i++) {
		answer[i] == 'Y' ? cout << "YES" << endl : cout << "NO" << endl;
	}
	unsigned int end_time = clock(); // конечное время
	cout << end_time - start_time; // искомое время
	system("pause");
	return 0;

}
