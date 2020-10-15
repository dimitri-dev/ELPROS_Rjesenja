// 3. zadatak.cpp : This file contains the 'main' function. Program execution begins and ends there.

/*
3. zadatak: Kanader leti brzinom 291 km/h.
Za koje ga vrijeme mogu očekivati na požarištu u Makarskoj ako je zračna luka Zemunik u kojoj su stacionirani udaljena 160.12 km ako pretpostavimo da je avion spreman za polijetanje.
Izraditi programsko rješenje u C++-u. Neka korisnik unosi brzinu i udaljenost.
*/

#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int main()
{
	double s, v;

	cout << "Unesite udaljenost koju avion mora preci u km: " << endl;
	cin >> s;

	cout << "Unesite brzinu aviona koji je presao taj put u km/h: " << endl;
	cin >> v;

	double t;
	t = s / v;

	cout << "Vrijeme koje bi tom avionu trebalo da prijede udaljenost od " << s << " km leteci brzinom od " << v << " km/h je " << t << " h." << endl;

	return 0;
}