#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include "prizma.h"
#include "ideGas.h"
#include "stope.h"

int main()
{
	printf("Prvi zadatak:\n");
	float a, h;
	prizma prizmaNP;

	printf("Unesite duljinu stranice u cm: ");
	scanf("%f", &a);

	printf("Unesite visinu prizme u cm: ");
	scanf("%f", &h);

	printf("\nPoziv funkcije bez parametara:\n"
			"Oplosje iznosi %.2f cm2.\n"
			"Volumen iznosi %.2f cm3.\n",
			prizmaNP.oplosje(),
			prizmaNP.volumen());

	prizma prizmaP(a, h);

	printf("\nPoziv funkcije sa unesenim parametara:\n"
			"Oplosje iznosi %.2f cm2.\n"
			"Volumen iznosi %.2f cm3.\n",
			prizmaP.oplosje(),
			prizmaP.volumen());

	printf("\n\nDrugi zadatak:\n");
	float prijedeniPut, velicinaSpremnika;

	printf("Unesite predeni put u km: ");
	scanf("%f", &prijedeniPut);

	printf("Unesite velicinu spremnika u l: ");
	scanf("%f", &velicinaSpremnika);

	/* Kod pozivanja, tj. deklariranja drugog objekta sa parametrima nije pisalo
		treba li ponovan unos ili išta slično, tako da sam jednostavno napravio
		isti objekt dvaput jer niste specificirali kako želite da to bude napravljeno */

	ideGas gaserNP;
	ideGas gaser1(prijedeniPut, velicinaSpremnika);
	ideGas gaser2(prijedeniPut, velicinaSpremnika);

	printf("\nPoziv funkcije bez parametara:\n"
		"Potrosnja iznosi %.2f l/100km.\n", gaserNP.potrosnja());

	printf("\nPoziv funkcije sa parametrima:\n"
		"Potrosnja iznosi %.2f l/100km.\n", gaser1.potrosnja());

	printf("\nPoziv funkcije sa parametrima #2:\n"
		"Potrosnja iznosi %.2f l/100km.\n", gaser2.potrosnja());

	printf("\n\nTreci zadatak:\n");
	float visinaCm;

	printf("Unesite visinu u cm: ");
	scanf("%f", &visinaCm);

	stope feetNP;
	stope feet(visinaCm);

	printf("\nPoziv funkcije bez parametara:\n"
		"Pretvaranje %.2f cm visine iznosi %.2f stopa.\n", 100.00, feetNP.pretvorba());

	printf("\nPoziv funkcije sa parametrima:\n"
		"Pretvaranje %.2f cm visine iznosi %.2f stopa.\n", visinaCm, feet.pretvorba());

	system("pause");
	return 0;
}