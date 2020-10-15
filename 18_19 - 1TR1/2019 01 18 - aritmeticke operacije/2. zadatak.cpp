// 2. zadatak.cpp : This file contains the 'main' function. Program execution begins and ends there.

// Tijelo mase m kilograma, pada sa visine h metara brzinom v metara/sekundi. Kolika je ukupna energija tijela.
// Ukupna je energija zbroj potencijalne i kinetiÄke energije.
// Potencijalna energija: Ep=m*g*h.
// KinetiÄka energija: Ek=m*v*v/2.
// Akceleracija slobodnog pada je konstanta i iznosi g=9.81 m/s2. Korisnik neka unese masu tijela, brzinu kojom pada i visinu s koje pada.

#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int main()
{
	float m;
	cout << "Unesite masu predmeta u kg: ";
	cin >> m;

	float h;
	cout << "Unesite visinu s koje predmet pada u m: ";
	cin >> h;

	float v;
	cout << "Unesite brzinu kojom predmet pada u m/s: ";
	cin >> v;

	float potencijalna_energija;
	potencijalna_energija = m * h * 9.81;

	float kineticka_energija;
	kineticka_energija = m * v * v / 2;

	float energija;
	energija = potencijalna_energija + kineticka_energija;

	cout << "Ukupna energija ovog predmeta tokom pada je " << energija << " dzula." << endl;

	return 0;
}