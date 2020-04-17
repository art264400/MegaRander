#include<iostream>
#include<string>
#include <algorithm>
#include <ctime>
#include<stdlib.h>
using namespace std;
void sort(string &st)
{
	for (int i = 0; i < (int)st.length(); i++)
		for (int j = 0; j <(int)st.length(); j++)
		{
			int a = int(st[j]);
			int b = int(st[j + 1]);
			if (a > b)
			{
				char buf = st[j];
				st[j] = st[j + 1];
				st[j + 1] = buf;
			}
		}
};
int main(){
	string name;
	cin >> name;
	qsort(name,(int)name.length());
	/*	for (int i = 0; i < n; i++) {
			cin >> stick_len[i];
		}
		int *box_len = new int[n-1];
		for (int i = 0; i < n; i++) {
			cin >> box_len[i];
		}*/


	sort(name);
		cout << name;
		/*sort(box_len, box_len + n);
		for (int i = 0; i < n; i++) {
			if (stick_len[i] > box_len[i]) { cout << "NO";  return 0; };
		}
		cout << "YES";*/
		system("pause");
	return 0;
}