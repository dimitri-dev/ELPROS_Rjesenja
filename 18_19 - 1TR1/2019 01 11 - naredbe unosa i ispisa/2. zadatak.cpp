// 2. zadatak.cpp : This file contains the 'main' function. Program execution begins and ends there.

/*
2. zadatak: Za koliko vremena bi japanski brzi vlak koji vozi 603 km/h stigao od Osijeka do Zagreba ako je udaljenost prugom 272 km?
Za usporedbu brzi vlak HŽ-a na toj relaciji putuje 4 sata i 8 minuta. Izradi programsko rješenje u C++-u neka korisnik unosi brzine i udaljenosti.
*/

#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int main()
{
	double s, v;

	cout << "Unesite udaljenost koju je presao vlak u km: " << endl;
	cin >> s;

	cout << "Unesite brzinu vlaka koji je presao taj put u km/h: " << endl;
	cin >> v;

	double t;
	t = s / v;

	cout << "Vrijeme koje bi tom vlaku trebalo da prijede udaljenost od " << s << " km vozeci brzinom od " << v << " km/h je " << t << " h." << endl;

	return 0;
}