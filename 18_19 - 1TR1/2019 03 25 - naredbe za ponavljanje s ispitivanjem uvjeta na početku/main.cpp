#include <iostream>
#include <cmath>

using namespace std;

int main()
{
	// 1. zadatak: 
	// Učitati visine za n osoba.Ispisati prosječnu i najveću visinu. Koristi petlju while.
	cout << "1. zadatak: " << endl;
	int n, i = 1, temp, temp_max = 0, sum1 = 0;

	cout << "Unesite broj osoba za koje cete upisivati visine: ";
	cin >> n;

	while (i <= n)
	{
		cout << "Unesite visinu " << i << ". osobe u cm: ";
		cin >> temp;

		if (temp > temp_max)
			temp_max = temp;

		sum1 += temp;
		i++;
	}

	cout << "Prosjecna visina za " << n << " osoba je " << sum1 / n << " cm." << endl;
	cout << "Najveca visina od svih unesenih bila je " << temp_max << " cm." << endl;

	cout << "_________________________________________________________________" << endl;

	// 2. zadatak:
	// Napiši program koji će ispisati ASCII vrijednost unesenog znaka. Koristiti petlju while.
	cout << "2. zadatak: " << endl;
	char cThing = 'a';
	
	cout << "Unesite * da bi prekinuli unos." << endl;
	while (cThing != '*')
	{
		cout << "Unesite neki znak : ";
		cin >> cThing;

		if (cThing == '*')
			break;
		else
			cout << "ASCII vrijednost znaka " << cThing << " je " << int(cThing) << endl;
	}
	


	cout << "_________________________________________________________________" << endl;

	// 3. zadatak:
	// Napiši program koji binarni broj (unosi ga korisnik) pretvara u oktalni. Koristiti petlju while.
	cout << "3. zadatak: " << endl;
	long long int binary, octal = 0, decimal = 0, j = 0, bin_copy_out;

	cout << "Unesite binarni broj: ";
	cin >> binary;

	bin_copy_out = binary;

	while (binary != 0)
	{
		decimal += (binary % 10) * pow(2, j);
		++j;
		binary /= 10;
	}
	j = 1;
	while (decimal != 0)
	{
		octal += (decimal % 8) * j;
		decimal /= 8;
		j *= 10;
	}
	
	cout << "Oktalni iznos binarnog broja " << bin_copy_out << " je " << octal << "." << endl;
}