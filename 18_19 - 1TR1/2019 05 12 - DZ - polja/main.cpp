#include "pch.h"
#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

int main()
{
	/*
	Napiši c++ program koji će učitati 10 brojeva sa konzole te spremiti ih u polje p1.
	Pronaći parne, neparne i negativne brojeve iz polja p1 te ih spremiti u p2 (parni), p3 (neparni), p4 (negativni) polja.
	Za svako p2, p3, p4 polje pronađi najveći i najmanji broj. Ispiši sve elemente p2, p3 i p4 polja:
	*/
	cout << "1. zadatak: " << endl;

	int a[10], small, big; // pocetna lista
	int p2[10], x = 0; // parni brojevi + brojac
	int p3[10], y = 0; // neparni brojevi + brojac
	int p4[10], z = 0; // negativni brojevi + brojac

	for (int i = 0; i < 10; i++) // unos brojeva
	{
		cout << "Unesite " << i + 1 << ". broj: ";
		cin >> a[i];

		if (a[i] > 0) // provjera pozitivnih brojeva
		{
			if (a[i] % 2 == 0) // provjera parnog broja
			{
				p2[x] = a[i];
				++x;
			}

			if (a[i] % 2 == 1)
			{
				p3[y] = a[i];
				++y;
			}
		}

		if (a[i] < 0) // provjera neg. brojeva
		{
			p4[z] = a[i];
			++z;
		}
	}

	cout << endl;

	/*
	Parni brojevi su :
	8, 6, 12 ...
	Min : 6
	Max : 12

	Neparni brojevi su :
	1, 3, 9, 15 ...
	Min : 1
	Max : 15

	Negativni brojevi su :
	-4, -9, -2 ...
	Min : -9
	Max : -2
	*/

	if (x > 0) // ispis parnih brojeva
	{
		sort(p2, p2 + x);

		cout << "Parni brojevi su : " << endl;

		for (int j = 0; j < x; ++j)
		{
			cout << p2[j] << ", ";
		}

		cout << endl;

		big = p2[0];
		small = p2[0];

		for (int b = 1; b < x; ++b)
			if (big < p2[b])
				big = p2[b];

		for (int s = 1; s < x; ++s)
			if (small > p2[s])
				small = p2[s];

		cout << "Min : " << small << endl;
		cout << "Max : " << big << endl;

		cout << endl;
	}

	if (y > 0) // ispis neparnih brojeva
	{
		sort(p3, p3 + y);

		cout << "Neparni brojevi su : " << endl;

		for (int j = 0; j < y; ++j)
		{
			cout << p3[j] << ", ";
		}

		cout << endl;

		big = p3[0];
		small = p3[0];

		for (int b = 1; b < y; ++b)
			if (big < p3[b])
				big = p3[b];

		for (int s = 1; s < y; ++s)
			if (small > p3[s])
				small = p3[s];

		cout << "Min : " << small << endl;
		cout << "Max : " << big << endl;

		cout << endl;
	}

	if (z > 0) // ispis negativnih brojeva
	{
		sort(p4, p4 + z);

		cout << "Negativni brojevi su : " << endl;

		for (int j = 0; j < z; ++j)
		{
			cout << p4[j] << ", ";
		}

		cout << endl;

		big = p4[0];
		small = p4[0];

		for (int b = 1; b < z; ++b)
			if (big < p4[b])
				big = p4[b];

		for (int s = 1; s < z; ++s)
			if (small > p4[s])
				small = p4[s];

		cout << "Min : " << small << endl;
		cout << "Max : " << big << endl;

		cout << endl;
	}

	/*
	Napiši c++ program koji će spojiti 2 polja p1 i p2 u p3.
	Korisnik unosi broj elemenata/dužinu polja za p1 i p2.
	Program mora proći kroz elemente p1 i p2 te upisanji njihove vrijednosti u p3.
	Primjer:
	
	Unesi dužinu p1: 2
	Unesi dužinu p2: 5
	Unesi vrijenosti za p1: 1, 5
	Unesi vrijenosti za p2: 7, 3, 1, 9, 44
	Vrijednosti polja p3 su: 1, 5, 7, 3, 1, 9, 44
	*/
	cout << "2. zadatak: " << endl;

	int size1, size2;

	cout << "Unesi duzinu prvog polja: ";
	cin >> size1;

	cout << "Unesi duzinu drugog polja: ";
	cin >> size2;

	int size3 = size1 + size2;

	int *polje1 = new int[size1];
	int *polje2 = new int[size2];
	int *polje3 = new int[size3];

	for (int i_p1 = 0; i_p1 < size1; ++i_p1)
	{
		cout << "Unesite " << i_p1 + 1 << ". broj za prvo polje: ";
		cin >> polje1[i_p1];
		polje3[i_p1] = polje1[i_p1];
	}

	for (int i_p2 = 0; i_p2 < size2; ++i_p2)
	{
		cout << "Unesite " << i_p2 + 1 << ". broj za drugo polje: ";
		cin >> polje2[i_p2];
		polje3[i_p2 + size1] = polje2[i_p2];
	}

	cout << "Vrijednosti polja 3 su : " << endl;
	
	sort(polje3, polje3 + size3); // funkcija ukoliko zelite da brojevi idu redom od najmanjeg do najveceg

	for (int i_p3 = 0; i_p3 < size3; ++i_p3)
	{
		cout << polje3[i_p3] << ",";
	}

	delete[] polje1;
	delete[] polje2;
	delete[] polje3;

	cout << endl;

	/*
	3. Deklarirajte cjelobrojni niz naziva polje1 i ograničite ga na 10 elemenata.
	Omogućite unos elemenata preko tipkovnice.
	Ispišite elemente niza čiji su indeksi parni (0 nije ni parna ni neparna).
	Rješenje izradite i u c++-u.
	*/

	cout << "3. zadatak: " << endl;

	int polje111[10] = { 0 };

	for (int y_p1 = 0; y_p1 < 10; ++y_p1)
	{
		cout << "Unesite " << y_p1 + 1 << ". broj da popunite polje: ";
		cin >> polje111[y_p1];
	}

	cout << "Parni brojevi uneseni u polje su : " << endl;

	for (int y_p1_t = 0; y_p1_t < 10; ++y_p1_t)
		if (polje111[y_p1_t] % 2 == 0)
			cout << polje111[y_p1_t] << ",";

	return 0;
}