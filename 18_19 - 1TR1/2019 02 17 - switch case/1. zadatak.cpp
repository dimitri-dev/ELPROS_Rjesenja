#include "pch.h"
#include <iostream>
#include <cstdlib>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
	int Broj;
	cout << "Unesite broj na kockici: " << endl;
	cin >> Broj;
	switch (Broj)
	{
		case 1:
		{
			Broj = 1;
			cout << "Broj suprotan unesenom broju na kockici je " << endl;
			cout << "O O\nO O\nO O";
		}
		break;
		case 2:
		{
			Broj = 2;
			cout << "Broj suprotan unesenom broju na kockici je " << endl;
			cout << "O O\n O\nO O";
		}
		break;
		case 3:
		{
			Broj = 3;
			cout << "Broj suprotan unesenom broju na kockici je " << endl;
			cout << "O O\nO O";
		}	
		break;
		case 4:
		{
			Broj = 4;
			cout << "Broj suprotan unesenom broju na kockici je " << endl;
			cout << "  O\n O\nO";
		}
		break;
		case 5:
		{
			Broj = 5;
			cout << "Broj suprotan unesenom broju na kockici je " << endl;
			cout << "O\n O";
		}
		break;
		case 6:
		{
			Broj = 6;
			cout << "Broj suprotan unesenom broju na kockici je " << endl;
			cout << "O";
		}
		break;
	}

	return 0;
}