#include <iostream>

using namespace std;

int main()
{
	cout << "1. zadatak: " << endl;
	// Izračunati sumu niza  do člana n koji unese korisnik:
	// S = 1!+ 2!+ 3!+ ... + !n
	// Pomoc : 1!= 1, 2!= 1 x 2, 3!= 1 x 2 x 3, n!= 1 x 2 x 3 x ... x n

	int n;
	unsigned int factorial = 1;
	unsigned int sum = 0;

	cout << "Unesite broj do kojeg ce se izracunati suma niza: ";
	cin >> n;

	for (int i = 1; i <= n; ++i)
	{
		factorial *= i;
		sum = sum + factorial;
	}

	cout << "Suma niza faktorijala do broja " << n << " iznosi " << sum << "." << endl;

	cout << "__________________________________________________________________________" << endl;

	cout << "2. zadatak: " << endl;
	// Napiši program koji provjerava je li broj strong (jednak je sumi faktorijela svojih znamenki)
	// Pomoc: formula za računanje faktorijela vidljiva je u zad 1.(Pomoc sekcija)
	// Primjer : Broj 145 je strong. 1!+ 4!+ 5!= 1 + 24 + 120 = 145

	int n_2, n_2_c, lastDigit;
	unsigned int sum_2 = 0;

	cout << "Unesite broj kako bi provjerili je li broj strong: ";
	cin >> n_2;

	n_2_c = n_2; // Stvaranje kopije orginalnog broja

	for (; n_2 > 0;)
	{
		lastDigit = n_2 % 10; // Uzimanje zadnjeg broja
		unsigned int factorial_2 = 1; 

		for (int j = 1; j <= lastDigit; ++j)
		{
			factorial_2 *= j; // Dobivanje faktorijela zadnjeg broja
		}

		sum_2 = sum_2 + factorial_2; // Dodavanje dobivenog faktorijela u sumu
		n_2 = n_2 / 10;
	}

	if (sum_2 == n_2_c)
		cout << "Broj " << n_2_c << " je strong." << endl;
	else
		cout << "Broj " << n_2_c << " nije strong." << endl;

	cout << "__________________________________________________________________________" << endl;

	cout << "3. zadatak: " << endl;
	// Zad 3. Izračunati sumu niza do člana n koji unese korisnik:
	// S = 1 x 1 + 3 x 3 + 5 x 5 + ... + n x n

	int n_3;
	int sum_3 = 0;

	cout << "Unesite broj do kojeg ce se izracunati suma niza: ";
	cin >> n_3;

	for (int k = 1; k <= n_3; k++)
	{
		if (k % 2 == 1)
		{
			int temp = k * k;
			sum_3 += temp;
		}
	}

	cout << "Suma niza do broja " << n_3 << " iznosi " << sum_3 << "." << endl;

	return 0;
}