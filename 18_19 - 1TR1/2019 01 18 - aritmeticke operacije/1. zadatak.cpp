// 1. zadatak.cpp : This file contains the 'main' function. Program execution begins and ends there.

// Gospodin Mato Å¾eli znati koliko Ä‡e moÄ‡i zaraditi ako proda rakiju koju ispeÄe po 30 kn/l.
// Rakiju Ä‡e peÄ‡i od 6200 kg Å¡ljiva, a od 10 kg Å¡ljiva moÅ¾e dobiti cca 1.2 l rakije.
// Neka korisnik unese masu Å¡ljiva i cijenu litre rakije.

#include <iostream>
#include <cstdlib>
#include <cmath>

using namespace std;

int main()
{
	float sljivovica;
	cout << "Koliko kosta litra sljivovice u kn: ";
	cin >> sljivovica;

	float masa_sljiva;
	cout << "Koliko imate kila sljiva u kg: ";
	cin >> masa_sljiva;

	float ukupno_rakije;
	ukupno_rakije = floor(((masa_sljiva / 10) * 1.2));

	float ukupno_para;
	ukupno_para = ukupno_rakije * sljivovica;

	cout << "Od " << ukupno_rakije << " l rakije dobiti cete " << ukupno_para << "kn.";

	return 0;
}