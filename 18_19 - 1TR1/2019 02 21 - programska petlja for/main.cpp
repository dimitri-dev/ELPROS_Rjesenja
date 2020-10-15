#include "pch.h"
#include <stdio.h>
#include <stdlib.h>
#include <ctime>
#include <algorithm>

int main()
{
	// 1 zadatak
	for (int i = 20; i <= 80; i = i + 5)
	{
		printf("Broj koji je djeljiv sa 5 je %d , a njegova reciprocna vrijednost je %f\n", i, 1 / float(i));
	}
	printf(" \n");

	// 2 zadatak
	int total = 0;
	for (int i = 10; i <= 100; ++i)
	{
		if (i % 7 == 0)
		{
			total = total + i;
		}
	}
	printf("Zbroj brojeva koji su djeljivi sa 7 izmedu 10 i 100 je %d \n", total);
	printf(" \n");

	// 3 zadatak
	printf("Unesi broj: ");
	int n; int count = 0;
	scanf_s("%d", &n);
	for (; n != 0; n /= 10, ++count) {} // for(init; cond; increment)
	printf("Broj znamenki je %d \n", count);
	printf(" \n");

	// 4 zadatak
	int a, b, secretoNumero, guessoNumero = 0, retard = 0;
	printf("Odaberite dva broja koja ce ogranicavati broj koji cete vi pogadati : ");
	srand(time(NULL));
 re:scanf_s("%d %d", &a, &b);

	if (a > b && a != b)
	{
		secretoNumero = b + rand() % (a - b + 1); // generates numbers from b to a
	}
	else if (b > a && a != b)
	{
		secretoNumero = a + rand() % (b - a + 1); // generates numbers from a to b
	}
	else
	{
		printf("Molim da opet unesete dva razlicita broja koja ce ogranicavati broj koji cete Vi pogadati : ");
		goto re;
	}

	for (;guessoNumero != secretoNumero; ++retard)
	{
		printf("Pogodi koji je skriveni broj (od %d do %d) : ", std::min(a,b), std::max(a,b));
		scanf_s("%d", &guessoNumero);
		if (guessoNumero > secretoNumero) puts ("Tajni broj je manji.");
		else if (guessoNumero < secretoNumero) puts ("Tajni broj je veci.");
	}

	printf("Pogodili ste broj na %d pokusaju!", retard);
	return 0;
}