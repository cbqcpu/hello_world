// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
int a = 10; //ȫ�ֱ���
void fun();

int main()
{
	while (a--)
	{
		fun();
	}
	
	return 0;
}

void fun(void)
	{
	static int b = 5; //�ֲ��������������Ϊstatic �������fun���������󲻻ᱻɾ��
	b++;
	std::cout << "a = " << a;
	std::cout << "b = " << b << std::endl;
	
	}
