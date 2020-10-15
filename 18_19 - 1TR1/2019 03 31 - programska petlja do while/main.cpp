#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	// 1. ispiši:
	// *****
	// *****
	// *****
	// *****
	// *****
	
	cout << "1. zadatak: " << endl;
	int i = 0, j = 0, n = 0;

	cout << "Koliko redova i stupaca zvjezdica zelite ispisati: ";
	cin >> n;

	do
	{
		do
		{
			cout << "*";
			j++;
		} while (j < n);

		j = 0;

		cout << endl;
		i++;
	} while (i < n);

	cout << "------------------------------------------------------" << endl;

	// 2. ispiši
	//   #
	//  ###
	// #####
	//  ###
	//   #

	cout << "2. zadatak: " << endl;
	int diaHeight = 0, spaces = 0, hashes = 1, ii = 0, jj = 0;
	char cSpace = ' ', cHash = '#';

	cout << "Unesite velicinu dijamanta kojeg zelite ispisati: "; 
	cin >> diaHeight; // za bilo koji paran broj ispisati ce se (diaHeight + 1) dijamant kako bi oblik ostao pravilan

	if (diaHeight % 2 == 1)
		spaces = diaHeight - 1;
	else
		spaces = diaHeight;
	
	do // printing the top
	{
		do // printing spaces
		{
			cout << cSpace;
			jj++;
		} while (jj < spaces);

		jj = 0; // resetting value

		do // printing hashes
		{
			cout << cHash;
			jj++;
		} while (jj <= ii);

		jj = 0; // resetting value

		cout << endl;

		ii += 2; // setting the next row to be 2 hashes more
		spaces--; // reducing the space amount
	} while (ii < diaHeight);

	if (diaHeight % 2 == 1)
	{
		spaces += 2;
		ii = diaHeight - 3;
	}
	else
		ii = diaHeight;

	do // printing the bottom
	{
		do // printing spaces
		{
			cout << cSpace;
			jj++;
		} while (jj < spaces);

		jj = 0; // resetting value

		do // printing hashes
		{
			cout << cHash;
			jj++;
		} while (jj <= ii);

		jj = 0; // resetting value

		cout << endl;
		ii -= 2; // setting the next row to be 2 hashes less
		spaces++; // increasing the space amount
	} while (ii >= 0);

	cout << "------------------------------------------------------" << endl;

	// Upotrebom petlje do while izračunaj sumu recipročnih vrijednosti svih brojeva do n kojeg unosi korisnik:
	// suma = 1 / 1 + 1 / 2 + 1 / 3 + …1 / n

	cout << "3. zadatak: " << endl;
	float sum = 0.00;
	int c = 1, num = 0;

	cout << "Unesite broj do kojeg zelite racunati sumu reciprocnih vrijednosti: ";
	cin >> num;

	do
	{
		sum += 1 / float(c);
		c++; // ahahaha c++ 
	} while (c <= num);

	cout << "Suma reciprocnih vrijednosti do broja " << num << " je " << sum << "." << endl;

	return 0;
}