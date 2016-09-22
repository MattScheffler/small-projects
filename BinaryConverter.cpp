// BinaryConverter.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cassert>
#include <string>
#include <cmath>
int Binary(int x)
{
	assert(x >= 0);

	if (x == 0)
		return 0;
	if (x == 1)
		return 1;

	int n = 0;
	while (std::pow(2, n) < x)
		++n;

	int powerTest = std::pow(2, n);
	if (powerTest % x == 0)
		return std::pow(10, n);
	else
	{
		std::string binary = "1";
		n -= 2;
		int difference = x - (std::pow(2, n + 1));
		while (n >= 0)
		{
			if (difference == 0)
				binary += "0";
			else if (difference >= (std::pow(2, n)))
			{
				binary += "1";
				difference -= std::pow(2, n);
			}
			else
				binary += "0";
			n -= 1;
		}
		return std::stoi(binary);
	}
}

int main()
{
	int input;
	std::cout << "Enter a positive integer: ";
	std::cin >> input;
	std::cout << "Input number to to binary: " << Binary(input) << std::endl;
	std::cin.get();
    return 0;
}

