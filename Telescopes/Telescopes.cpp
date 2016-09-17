// Telescopes.cpp : Defines the entry point for the console application.

#include "stdafx.h"
#include <iostream>
#include <string>
#include "TelescopeClasses.h"

int main()
{
	Type1 n("Newton", 0.2, 4, 100, 1);
	
	std::cout << n.getName() << std::endl;
	n.move(43.5125, -0.9817);
	n.takeImage();

	std::cout << std::endl;

	Type2 prime("Prime Focus", 0.5, 7.5, 135);

	prime.move(65.024, -0.4219);
	prime.takeImage();

    return 0;
}

