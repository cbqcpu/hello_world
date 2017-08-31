// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
int a = 10; //全局变量
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
	static int b = 5; //局部变量，如果设置为static 则变量在fun函数结束后不会被删除
	b++;
	std::cout << "a = " << a;
	std::cout << "b = " << b << std::endl;
	
	}
