// 1. zadatak.cpp : This file contains the 'main' function. Program execution begins and ends there.

/*
1. zadatak: Kojom prosječnom brzinom ide vlak Eurostar koji vozi kroz tunel ispod  kanala La Manche  ako put od 50 km prijeđe za 35 min?
Izraditi programsko rješenje u C++-u. Neka korisnik unosi put i vrijeme.
*/

#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int main()
{
	int s, t, v;

	cout << "Unesite put koji prijede vlak Eurostar u km : " << endl;
	cin >> s;

	cout << "Unesite vrijeme za koje je vlak Eurostar presao taj put u satima: " << endl;
	cin >> t;

	v = s / t;

	cout << "Prosjecna brzina vlaka Eurostar je " << v << " km/h." << endl;

	return 0;
}