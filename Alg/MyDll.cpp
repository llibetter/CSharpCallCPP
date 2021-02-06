#include<iostream>
extern "C" _declspec(dllexport)int add(int a, int b, char * str)
{
	std::cout << "[from Alg.dll] param1:" << a << std::endl;
	std::cout << "[from Alg.dll] param2:" << b << std::endl;
	std::cout << "[from Alg.dll] param3:" << str << std::endl;
	int sum = a + b;
	return sum;
}