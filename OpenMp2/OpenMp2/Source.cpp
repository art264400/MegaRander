#include<iostream>
#include <cstdio>
#include"Windows.h"
#include "omp.h"
using namespace std;
//2 задание
//int main() {
//	omp_set_num_threads(2); // устанавливает число потоков дл€ паралельных регионов по умолчанию
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


//3 задание
int main() {
	int k=8;
	cin >> k;
#pragma omp parallel num_threads(k)
	{
		//printf("I am %d thread from %d threads!\n",
		//	omp_get_thread_num(), //Ќомер нити в параллельной области, контроль и просмтор параметров Openmp программы
		//	omp_get_num_threads() // оличество нитей в параллельной области
		//	
		//);
		(omp_get_thread_num() % 2==0) ? printf("I am %d thread from %d threads!\n", omp_get_thread_num(), omp_get_num_threads()) : false;
			 //Ќомер нити в параллельной области
		     //—ущесвтует ли omp_set_thread_num
		     //ƒл€ того чтобы значть сколько паралленьных задач мы можем выполн€ть однвоременно 
	}
	system("pause");
}




//4 задание 
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



// пример частной переменной цикл for
// где хран€тс€ частные переменные - сегмента стека нити
// общие хран€тс€ в сегменте данных процесса


// гонка процессов нити конкурирует за общий блок данных
