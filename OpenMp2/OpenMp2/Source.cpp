#include<iostream>
#include <cstdio>
#include"Windows.h"
#include "omp.h"
using namespace std;
//2 �������
//int main() {
//	omp_set_num_threads(2); // ������������� ����� ������� ��� ����������� �������� �� ���������
//#pragma omp parallel num_threads(4)
//	{
//		printf("Hello world\n");
//	}
//	cout << endl;
//#pragma omp parallel
//	{
//		printf("Hello world\n");
//	}
//	system("pause");
//}


//3 �������
int main() {
	int k=8;
	cin >> k;
#pragma omp parallel num_threads(k)
	{
		//printf("I am %d thread from %d threads!\n",
		//	omp_get_thread_num(), //����� ���� � ������������ �������, �������� � �������� ���������� Openmp ���������
		//	omp_get_num_threads() //���������� ����� � ������������ �������
		//	
		//);
		(omp_get_thread_num() % 2==0) ? printf("I am %d thread from %d threads!\n", omp_get_thread_num(), omp_get_num_threads()) : false;
			 //����� ���� � ������������ �������
		     //���������� �� omp_set_thread_num
		     //��� ���� ����� ������ ������� ������������ ����� �� ����� ��������� ������������ 
	}
	system("pause");
}




//4 ������� 
//int main() {
//	int rank, k = 8;
//#pragma omp parallel num_threads(8)
//	{
//		rank = omp_get_thread_num();
//		Sleep(100);
//		printf("I am %d thread.\n", rank);
//	}
//	system("pause");
//}



// ������ ������� ���������� ���� for
// ��� �������� ������� ���������� - �������� ����� ����
// ����� �������� � �������� ������ ��������


// ����� ��������� ���� ����������� �� ����� ���� ������
