// 3. zadatak.cpp : This file contains the 'main' function. Program execution begins and ends there.

// Napiši C++ kod koji računa i ispisuje kolika je površina crveno osjenčanog dijela sa slike ako korisnik unosi radijus velike kružnice.

#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int main()
{
	const double pi = 3.14159265358979323846;

	float r;
	cout << "Unesite radijus velikog kruga u cm: ";
	cin >> r;

	double big_circle;
	big_circle = pow(r, 2) * pi;

	float a;
	a = r;
	double large_square;
	large_square = a * a;

	float mini_r;
	mini_r = r / 2;
	double four_half_circles;
	four_half_circles = 2 * pi * pow(mini_r, 2);

	double shaded_region;
	shaded_region = big_circle - large_square - four_half_circles;

	/* test phase to make sure the formulas are right
	cout << "Povrsina velikog kruga je " << big_circle << " cm." << endl;
	cout << "Povrsina kvadrata je " << large_square << " cm." << endl;
	cout << "Povrsina cetiri polu kruga je " << four_half_circles << " cm." << endl;
	*/

	cout << "Povrsina crveno osjencanog dijela je " << shaded_region << " cm.";

	return 0;
}