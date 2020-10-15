#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <algorithm>
#include <cmath>
#include <fstream>
#include <string>

int main()
{
	printf("Prvi zadatak:\n");

	try
	{
		FILE *task;

		task = fopen("prvi.xls", "w+");
		if (task == NULL) throw 69;

		for (int i = 1; i < 30; ++i)
			if (i % 3 == 0)
				fprintf(task, "%d\n", i);

		printf("Ispis gotov.\n\n");
		fclose(task);
	}
	catch (int exception)
	{
		if (exception == 69)
			printf("Ne mogu otvoriti datoteku prvi.xls!\n");
	}
	
	printf("Drugi zadatak:\n");

	try
	{
		FILE *task;

		task = fopen("drugi.txt", "w+");
		if (task == NULL) throw 69;

		for (int i = 65; i < 91; ++i)
			fprintf(task, "%c%c\n", char(i), char(i + 32)); // Aa Bb Cc Dd Ee Ff 

		printf("Ispis gotov.\n\n");
		fclose(task);
	}
	catch (int exception)
	{
		if (exception == 69)
			printf("Ne mogu otvoriti datoteku drugi.txt!\n");
	}

	printf("Treci zadatak:\n");

	int k;
	printf("Unesite k: ");
	scanf("%d", &k);

	try
	{
		FILE *task;

		std::string niz = "";
		long long sum = 0;

		task = fopen("treci.doc", "w+");
		if (task == NULL) throw 69;

		for (int i = 1; i <= k; i += 2)
		{
			niz += std::to_string(i * i);
			
			sum += pow(i, 2);

			fprintf(task, "%lld = %s \n", sum, niz.c_str());
			niz += " + ";
		}

		niz.erase(niz.end() - 3, niz.end());

		printf("Ispis gotov.\n\n");
		fclose(task);
	}
	catch (int exception)
	{
		if (exception == 69)
			printf("Ne mogu otvoriti datoteku treci.doc!\n");
	}

	printf("Cetvrti zadatak:\n");

	try
	{
		FILE *input;
		FILE *output;

		double sum = 0;

		input = fopen("jozo.txt", "r");
		if (input == NULL) throw 69;

		output = fopen("cetvrti.txt", "w+");
		if (output == NULL) throw 6969;

		char buff[255];
		int nDay = 0;
		bool cash = false; // 0
		float porez = 0.25; // 25% PDV yes/no ?

		while (fgets(buff, 255, (FILE*)input) != NULL) // 31 * 2
		{
			if (cash)
			{
				std::string pare(buff);
				fprintf(output, "%d. : %.2f \n", nDay, (stof(pare) * porez)); // 1. : 2500,00kn etc.

				sum += stof(pare);
			}
			else
			{
				++nDay;
			}

			cash = !cash;
		}

		fprintf(output, "Ukupni promet u kn u mjesecu iznosi: %.2lf \n", sum);
		fprintf(output, "Ukupan iznos PDV-a u kn iznosi: %.2lf \n", sum * porez); 
		printf("Ispis gotov.\n\n");
	}
	catch (int exception)
	{
		if (exception == 69)
			printf("Ne mogu otvoriti datoteku jozo.txt!\n");

		if (exception == 6969)
			printf("Ne mogu otvoriti datoteku cetvrti.txt!\n");
	}

	printf("Peti zadatak:\n");

	try
	{
		FILE *task;

		task = fopen("peti.xls", "w+");
		if (task == NULL) throw 69;

		

		for (int i = 1; i <= 9; ++i)
			for (int j = 0; j <= 9; ++j)
				fprintf(task, "%d%d%d\n", i, j, i); // 101, 111, 121, 131, 141 :)

		printf("Ispis gotov.\n\n");
		fclose(task);
	}
	catch (int exception)
	{
		if (exception == 69)
			printf("Ne mogu otvoriti datoteku peti.xls!\n");
	}

	system("pause");
	return 0;

}
