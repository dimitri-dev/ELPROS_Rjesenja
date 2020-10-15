#include <iostream>
#include <cmath>
#include <algorithm>
#include <tuple>
#include <cstdlib>
#include <conio.h>

using namespace std;

// Clean console window function - mali trik :)
void screen_clean_funct() {
	cout << "\n\nPritisnite bilo koju tipku kako bi krenuli na sljedeci zadatak.";
	_getch();
	cout << flush;
	system("CLS");
}

// Zadatak 1
float veci(float a, float b);

// Zadatak 2
long long int potencija(int a, int n);

// Zadatak 3
int pretilost(float BMI[], int n);

// Zadatak 4
float strajkStrajkStrajk(float current);

// Zadatak 5
float visVisVis(float promjer);

// Main
int main()
{
	cout << "Zadatak 1: \n" << endl;
	/*  Napiši funkciju veci() koja će vratiti veći od dva proslijeđena broja.
	U mainu unesi 4 broja te pozovi funkciju dovoljan broj puta da bi saznao koji je od tih brojeva najveći i ispiši najveći. */
	int nC = 1;
	float n[4];
	
	cout << "Unesite bilo koja cetiri broja: ";
	cin >> n[0] >> n[1] >> n[2] >> n[3];

	float temp_val = n[0];

	while (nC < 4)
	{
		temp_val = veci(temp_val, n[nC]);
		++nC;
	}

	cout << "\nNajveci broj od ta cetiri je " << temp_val << "." << endl;

	screen_clean_funct();

	cout << "Zadatak 2: " << endl;
	/* U mainu neka korisnik unosi 5 puta parove cjelobrojnih vrijednosti baza, eksponent.
	Nemoj ih pohranjivati u polje nego za svaki unos u petlji while pozovi funkciju potencija( )
	i proslijedi joj unesene parametre, koja će vratiti vrijednost te potencije u main().
	Ispiši rješenje u petlji prije novog unosa.*/
	int wC = 0;
	int temp1, temp2;

	while (wC < 5)
	{
		cout << "\nUnesite bazu i eksponent " << wC + 1 << ". broja: ";
		cin >> temp1 >> temp2;

		cout << "Broj koji se dobije potenciranjem jeste: " << potencija(temp1, temp2) << endl;

		++wC;
	}

	screen_clean_funct();

	cout << "Zadatak 3: \n" << endl;
	/* Nastavnica tjelesnog mjerila je na početku nastavne godine za n učenika 2.TR1 razreda visinu u cm i tjelesnu masu u kg.
	Podatke pohrani u polje visina[ ] i masa [ ]. U mainu izračunaj polje BMI[ ] za učenike.
	Izradi funkciju pretilost( float BMI) koja će na temelju proslijeđenog polja vrijednosti izbrojiti koliko je učenika pretilo (BMI>25)*/
	int nStudents;

	cout << "Unesite broj ucenika razreda: ";
	cin >> nStudents;

	float *visina = new float[nStudents];
	float *masa = new float[nStudents];
	float *BMI = new float[nStudents];

	for (int i = 0; i < nStudents; ++i)
	{
		cout << "\nUnesite visinu " << i + 1 << ". ucenika u m: ";
		cin >> visina[i];

		cout << "Unesite masu " << i + 1 << ". ucenika u kg: ";
		cin >> masa[i];

		BMI[i] = masa[i] / pow(visina[i], 2);
	}

	cout << "U razredu je pretilo " << pretilost(BMI, nStudents) << " ucenika. " << endl;
	
	delete[] visina;
	delete[] masa;
	delete[] BMI;

	screen_clean_funct();

	cout << "Zadatak 4: \n" << endl;
	/* Izradi aplikaciju koja će na temelju unosa trenutne plaće n nastavnika
	(za unos iznosa i poziv funkcije koristi petlju)
	izračunati i vratiti koliko će ona iznositi nakon uvećanja za 6.11%.
	Funkciju prototipiraj, a zatim napiši nakon maina. */
	int nProfessors;

	cout << "Unesite broj profesora: ";
	cin >> nProfessors;

	float *plata = new float[nProfessors];

	for (int i = 0; i < nProfessors; ++i)
	{
		cout << "\nUnesite platu " << i + 1 << ". profesora: ";
		cin >> plata[i];

		cout << "Plata nakon povecanja iznositi ce " << strajkStrajkStrajk(plata[i]) << " kn.";
	}

	delete[] plata;

	screen_clean_funct();

	cout << "Zadatak 5: \n" << endl;
	/*  Marko od inox cijevi različitih izrađuje lončiće. Lončić uvijek treba imati zapreminu 1 l.
	Na temelju n unosa (mainu) promjera cijevi u cm u funkciji visina( ) proslijedite promjer i izračunajte
	i u main vratite koliku duljinu cijevi treba odrezati za izradu lončića zadane zapremine.
	Dobivene podatke ispišite iz maina. */

	int nHalfCircleThingy;
	
	cout << "Unesite broj promjera: ";
	cin >> nHalfCircleThingy;

	float *halfCircleThingies = new float[nHalfCircleThingy];

	for (int i = 0; i < nHalfCircleThingy; ++i)
	{
		cout << "\nUnesite promjer " << i + 1 << ". cijevi u cm: ";
		cin >> halfCircleThingies[i];

		cout << "Duzina koju treba odrezati iznosi " << visVisVis(halfCircleThingies[i]) << " cm." << endl;
		// Minijaturna problematika kod polja koje ima ime "visina" -.-
	}


	delete[] halfCircleThingies;
	return 0;
}

float visVisVis(float r) {
	return (1/(pow(r, 2) * 3.14)); // h = V / r2 * pi; V = 1;
}

float strajkStrajkStrajk(float current) {
	return (current * 1.0611);
}

int pretilost(float BMI[], int n) {
	int count = 0;
	sort(BMI, BMI + n, greater<int>());

	while (true) {
		if (BMI[count] >= 25)
			++count;
		else
			break;
	}

	return count;
}

long long int potencija(int a, int n) {
	return pow(a, n);
}

float veci(float a, float b) {
	return max(a, b);
}