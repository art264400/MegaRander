#include<iostream>
#include<ctime>
//
//#define CMaxInp 20
//#define CMaxOut 10
//#define CMaxImages 200
//#define CEta 0.75
//#define CError 05.e-3
//#define CCounter 1000
//#define CInitWeight 5.0
//#define CBiasNeuron 1.0
//
//struct TPerceptron
//{
//	int NInp;
//	int NOut;
//	float Inp[CMaxInp];
//	float Out[CMaxOut];
//	float W[CMaxInp][CMaxOut];
//};
//struct TBaseRecord
//{
//	float X[CMaxInp];
//	float Y[CMaxOut];
//};
//struct TBase
//{
//	int NImages;
//	TBaseRecord Images[CMaxImages];
//
//};
//
//TPerceptron VNet;
//TBase Vbase;
//bool VOK;
//float VError, VTemp, VDelta;
//int VCounter, Vi, Vj, Vk;
//
//
//void InitAll() {
//	int Li, Lj, Lk;
//	NInp
//}

void Init(&){

}

int main() {
	srand(time(0));
	int sum = 0;
	setlocale(0, "");
	int input[11];
	double weights[10] = { -0.4,0.39,-0.49,0.12,0.1,0.3,-0.31,0.2,0.3,0.5 };
	for (int i = 0; i < 10; i++) {
		input[i] = rand() % 2;
		if(input[i]==1)
	}
	system("pause");
}