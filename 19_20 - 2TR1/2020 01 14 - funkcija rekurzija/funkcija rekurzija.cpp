#include <iostream>
#include <cmath>
#include <algorithm>

// 1. zadatak:
// https://www.mindomo.com/mindmap/66b2b88c567e46bfb80eba9f870f0514

// 2. zadatak: Napiši funkciju rekurziju za izraèun Fibonaccijeva niza do rednog broja èlana n koji æe unijeti korisnik.
int i = 0;
void funct_1(int n, int t1, int t2);

// 3. zadatak: Napiši funkciju rekurziju za izraèun sume brojeva do broja n koji æe unijeti korisnik.
int sum = 0;
int funct_2(int n);

// 4. zadatak: Napiši funkciju rekurziju za izraèun najveæeg zajednièkog djelitelja dva broja koje æe unijeti korisnik.
int funct_3(int n, int m);

// 5. zadatak: Za broj koji unese korisnik provjeri je li palindrom korištenjem funkcije rekurzije.
// Palindrom je broj koji se jednako èita i s lijeva na desno i s desna na lijevo.
int palindrom_n;
int rev = 0;
bool funct_4(int n);

// 6. zadatak: Izraèunaj sumu znamenki broja koji unese korisnik uporabom funkcije rekurzije.
int n_sum = 0;
int funct_5(int n);

int main()
{
	int fib_n;

	std::cout << "2. zadatak: \n";
	std::cout << "Unesite broj do kojeg se treba ispisati Fibonaccijev niz: ";
	std::cin >> fib_n;

	std::cout << "Ispis Fibonaccijevog niza do " << fib_n << ".-tog clana: \n";
	funct_1(fib_n, 0, 1);

	int sum_n;

	std::cout << "\n\n3. zadatak: \n";
	std::cout << "Unesite broj do kojeg ce se izracunati suma brojeva: ";
	std::cin >> sum_n;

	std::cout << "Suma brojeva do broja " << sum_n << " iznosi " << funct_2(sum_n);

	int nzd_a, nzd_b;

	std::cout << "\n\n4. zadatak: \n";
	std::cout << "Unesite dva broja kako bi saznali njihov najveci zajednicki djelitelj: ";
	std::cin >> nzd_a >> nzd_b;

	std::cout << "Njihov najveci zajednicki djelitelj je " << funct_3(nzd_a, nzd_b);

	std::cout << "\n\n5. zadatak: \n";
	std::cout << "Unesite broj kako bi provjerili jeli on palindrom: ";
	std::cin >> palindrom_n;

	if (funct_4(palindrom_n)) std::cout << "Broj je palindrom. \n";
	else std::cout << "Broj nije palindrom. \n";

	int calc_n;

	std::cout << "\n\n6. zadatak: \n";
	std::cout << "Unesite broj kako bi izracunali zbroj svih znamenki u njemu: ";
	std::cin >> calc_n;

	std::cout << "Suma znamenki tog broja iznosi " << funct_5(calc_n);

	getchar();
	return 0;
}

void funct_1(int n, int t1, int t2)
{
	if (n >= i && i == 0) {std::cout << t1 << " "; i = -~i;}
	if (n >= i && i == 1) {std::cout << t2 << " "; i = -~i;}

	int next = t1 + t2; t1 = t2; t2 = next;

	if (n >= i) {std::cout << next << " "; i = -~i; funct_1(n, t1, t2);}
	else return;
}

int funct_2(int n)
{
	if (n <= 0) return sum;
	sum += n;
	funct_2(n - 1);
}

int funct_3(int n, int m)
{
	if (m == 0) return n;
	return funct_3(m, n % m);
}

bool funct_4(int n)
{
	rev = (rev * 10) + (n % 10);
	if (n != 0) funct_4(n / 10);
	else { if (palindrom_n == rev / 10) return true; else return false; }
}

int funct_5(int n)
{
	n_sum += n % 10;
	if (n > 0) {n = n / 10; funct_5(n);}
	else return n_sum;
}
