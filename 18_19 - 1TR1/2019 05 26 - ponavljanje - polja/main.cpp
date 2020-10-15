#include "pch.h"
#include <iostream>
#include <algorithm>
#include <ctime>
#include <cmath>

using namespace std;

int main()
{
	srand(time(NULL));

	// 1. zadatak
	// Napiši program koji će nasumično generirati jednodimenzionalno polje od 10 elemenata
	// te ispisati koliko puta se pojedina vrijednost pojavljuje u polju – frekvenciju pojedinog elementa.
	cout << "1. zadatak: " << endl;
	int randomPolje[10] = { 0 };


	for (int i = 0; i < 10; ++i)
		randomPolje[i] = rand() % 10 + 1; // generiranje brojeva od 1 do 10

	for (int i = 0; i < 10; ++i)
		cout << randomPolje[i] << " "; // ispis generiranog polja

	cout << endl;

	int count[10] = { 0 };

	for (int i = 0; i < 10; ++i) {
		if (randomPolje[i] == 1) // nulti element je brojac broja 1
			++count[0];
		if (randomPolje[i] == 2) // prvi element je brojac broja 2
			++count[1];
		if (randomPolje[i] == 3) // itd.
			++count[2];
		if (randomPolje[i] == 4)
			++count[3];
		if (randomPolje[i] == 5)
			++count[4];
		if (randomPolje[i] == 6)
			++count[5];
		if (randomPolje[i] == 7)
			++count[6];
		if (randomPolje[i] == 8)
			++count[7];
		if (randomPolje[i] == 9)
			++count[8];
		if (randomPolje[i] == 10)
			++count[9];
	}

	for (int i = 0; i < 10; ++i) {
		if (count[i] > 0)
			cout << "U ovom generiranom polju broj " << i + 1 << " se ponavlja " << count[i] << " puta." << endl;
	}

	cout << endl;

	// Napiši program koji će kopirati elemente jednodimenzionalnog polja od 5 elemenata koje unosi korisnik u drugo polje i ispisati dobiveno polje.
	cout << "2. zadatak: " << endl;
	int polje5[5] = { 0 };
	int polje_copy[5] = { 0 };

	for (int i = 0; i < 5; ++i)
		cin >> polje5[i];

	copy(begin(polje5), end(polje5), begin(polje_copy));

	for (int i = 0; i < 5; ++i)
		cout << polje_copy[i] << " ";

	cout << endl;
	cout << endl;

	// Napiši program koji generira dva dvodimenzionalna polja 3*3, ispisuje ih i množi ih u treće polje koje također ispisuje
	cout << "3. zadatak: " << endl;

	int randPolje1[3][3] = { 0 }, randPolje2[3][3] = { 0 }, randPolje3[3][3] = { 0 };

	for (int i = 0; i < 3; ++i)
		for (int j = 0; j < 3; ++j) {
			randPolje1[i][j] = rand() % 10 + 1; // generiranje brojeva od 1 do 10
			randPolje2[i][j] = rand() % 10 + 1; 
		}
			

	for (int i = 0; i < 3; ++i){
		for (int j = 0; j < 3; ++j)
			cout << randPolje1[i][j] << " "; // ispis prvog generiranog polja
		cout << endl;
	}

	cout << endl;

	for (int i = 0; i < 3; ++i){
		for (int j = 0; j < 3; ++j)
			cout << randPolje2[i][j] << " "; // ispis drugog generiranog polja
		cout << endl;
	}

	cout << endl;

	for (int i = 0; i < 3; ++i)
		for (int j = 0; j < 3; ++j)
			randPolje3[i][j] = randPolje1[i][j] * randPolje2[i][j];

	for (int i = 0; i < 3; ++i){
		for (int j = 0; j < 3; ++j)
			cout << randPolje3[i][j] << " "; // ispis treceg mnozenog polja
		cout << endl;
	}

	cout << endl;
	cout << endl;

	// Napiši program koji generira dvodimenzionalno polje 3*3, ispisuje ga,
	// te elemente ispod glave dijagonale zamijeni nulama i ispiše novonastalo polje. 
	cout << "4. zadatak: " << endl;

	int randFinal[3][3] = { 0 };

	for (int i = 0; i < 3; ++i)
		for (int j = 0; j < 3; ++j)
			randFinal[i][j] = rand() % 10 + 1; // generiranje brojeva od 1 do 10

	for (int i = 0; i < 3; ++i) {
		for (int j = 0; j < 3; ++j)
			cout << randFinal[i][j] << " "; // ispis prvog generiranog polja
		cout << endl;
	}
		

	cout << endl;

	/*
	0 r r
	r 0 r
	r r 0
	*/

	for (int i = 0, j = 0; i < 3, j < 3; ++i, ++j)
		randFinal[i][j] = 0;

	for (int i = 0; i < 3; ++i) {
		for (int j = 0; j < 3; ++j)
			cout << randFinal[i][j] << " "; // ispis novog polja
		cout << endl;
	}

	return 0;
}