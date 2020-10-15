#include "pch.h"
#include <algorithm>
#include <cmath>
#include <ctime>
#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
	cout << "1. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	int nElements, countLetter = 0, countPackage = 0, MASSiveNumber = 0;
	cout << "Unesite broj predanih posiljki: ";
	cin >> nElements;

	int *postOffice = new int[nElements]; // potrebno koristenje pointera zbog compilera u Visual Studiu

	srand(time(NULL));

	cout << "Mase predanih posiljki su redom: " << endl;

	for (int i = 0; i < nElements; ++i)
	{
		postOffice[i] = rand() % 19999 + 1;
		cout << postOffice[i] << " g" << endl;

		if (postOffice[i] > 2000)
			++countPackage;
		else
			++countLetter;

		MASSiveNumber += postOffice[i];
	}

	cout << "Pisama ima " << countLetter << ", a paketa ima " << countPackage << "." << endl;

	cout << "Ukupna masa svih posiljki iznosi " << MASSiveNumber << " g." << endl;

	delete[] postOffice; // brisanje memorijske alokacije zbog koristenja pointera za polje.

	cout << endl;

	cout << "2. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	int arrayRobert[5][5] = { 0 }, arrayIvan[5][5] = { 0 }, coincidence = 0;

	cout << "Ivanova ploca:" << endl;

	for (int i = 0, j = 0; i < 5;) // komplicirano, da :)
	{
		if (j < 5)
		{
			arrayIvan[i][j] = rand() % 2;
			cout << arrayIvan[i][j] << " ";
			++j;
		}
		else
		{
			cout << endl;
			j = 0;
			++i;
		}
	}

	cout << "Robertova ploca:" << endl;

	for (int i = 0, j = 0; i < 5;)
	{
		if (j < 5)
		{
			arrayRobert[i][j] = rand() % 2;
			cout << arrayRobert[i][j] << " ";

			if ((arrayRobert[i][j] == 1) && (arrayRobert[i][j] == arrayIvan[i][j]))
				++coincidence;

			++j;
		}
		else
		{
			cout << endl;
			j = 0;
			++i;
		}
	}
	cout << endl;

	if (coincidence > 0)
	{
		cout << "Oba igraca postavila su bomboncic na pozicije:" << endl;
		
		for (int i = 0; i < 5; ++i)
			for (int j = 0; j < 5; ++j)
				if ((arrayRobert[i][j] == 1) && (arrayRobert[i][j] == arrayIvan[i][j]))
					cout << "[" << i + 1 << "][" << j + 1 << "]" << endl;
		cout << endl;

		cout << "Ukupno su na ista polja stavili " << coincidence << " bomboncica." << endl;
	}
	else
	{
		cout << "Oba igraca su bomboncice postavili na skroz razlicita polja." << endl;
	}

	cout << endl;

	cout << "3. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	int studentJump[5][3] = { 0 }, studentMAX[5] = { 0 };


	for (int i = 0, j = 0; i < 5;)
	{
		if (j == 0)
			cout << i + 1 << ". ucenik: ";
		if (j < 3)
		{
			studentJump[i][j] = rand() % 601;
			cout << setw(5) << studentJump[i][j] ;
			if (studentJump[i][j] > studentMAX[i])
				studentMAX[i] = studentJump[i][j];
			++j;
		}
		else
		{
			cout << endl;
			j = 0;
			++i;
		}
	}

	for (int i = 0; i < 5; ++i)
		cout << i + 1 << ". ucenik: " << setw(5) << studentMAX[i] << " cm " << endl;

	cout << endl;

	cout << "4. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	int drawerM[15] = { 3, 4, 5, 6, 8, 10, 12, 14, 16, 18, 20, 24, 27, 30, 42 };
	int nScan;

	cout << "Ante bolan, unesi koju velicinu matice trebas: ";
	cin >> nScan;

	int drawerBottom = 0, drawerCeil = 14, drawerMiddle = 0;

	while (drawerBottom <= drawerCeil)
	{
		drawerMiddle = (drawerBottom + drawerCeil) / 2;

		if (drawerM[drawerMiddle] == nScan)
		{
			cout << "Trazena velicina matice nalazi se u polju u ladici " << drawerMiddle + 1 << "." << endl;
			break;
		}
		else if (drawerM[drawerMiddle] < nScan)
			drawerBottom = drawerMiddle + 1;
		else
			drawerCeil = drawerMiddle - 1;
	}

	if (drawerBottom > drawerCeil )
		cout << "Trazena velicina matice ne postoji u Vasoj ladici." << endl;

	cout << endl;

	cout << "5. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	int studentHeight[5] = { 0 }, studentSearch = 0;

	for (int i = 0; i < 5; ++i)
	{
		cout << "Unesite visinu " << i + 1 << ". ucenika: ";
		cin >> studentHeight[i];
	}

	sort(studentHeight, studentHeight + 5);

	cout << "Visine redom su: " << endl;

	for (int i = 0; i < 5; ++i)
	{
		cout << i + 1 << ". " << studentHeight[i] << endl;
	}

	cout << "Unesite visinu koju zelite provjeriti: ";
	cin >> studentSearch;

	int studentBottom = 0, studentCeil = 5, studentMiddle = 0;

	while (studentBottom <= studentCeil)
	{
		studentMiddle = (studentBottom + studentCeil) / 2;

		if (studentHeight[studentMiddle] == studentSearch)
		{
			cout << "Trazena visina vec se nalazi na popisu na " << studentMiddle + 1 << ". mjestu. " << endl;
			break;
		}
		else if (studentHeight[studentMiddle] < studentSearch)
			studentBottom = studentMiddle + 1;
		else
			studentCeil = studentMiddle - 1;
	}

	if (studentBottom > studentCeil)
		cout << "Trazenu visinu niste unijeli." << endl;

	cout << endl;

	return 0;
}

