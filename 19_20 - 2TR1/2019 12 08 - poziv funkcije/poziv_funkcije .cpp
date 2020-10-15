#include <iostream>
#include <cmath>
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

// 1 zadatak - variables & functions
float a, b, c;
int T1[2], T2[2], T3[2];
bool goahead;

void unos_triangle();
bool same_line_check();
void side_calc();
float perimeter_funct();
float area_funct();

// 2 zadatak - variables & functions
int godina_rodenja;

bool prestupnaCheck();

// 3 zadatak - variables & functions
float qA, qB, qC;
float diskriminanta;

pair <float, float> quadratic_funct();
float diskriminanta_calc();

// Main
int main()
{
	cout << "Zadatak 1: \n" << endl;
	/*  Problem podijeli na manje zadatke i popiši pojedinaène zadatke – za koordinate tri toèke u
	ravnini koje unosi korisnik provjeravamo leže li na istom pravcu, te ako ne leže raèunamo opseg i
	površinu trokuta kojega one èine. */

	unos_triangle();

	if (!(goahead)) {
		side_calc(); // duljina stranica
		cout << "\nStranice iznose " << a << " cm, " << b << " cm, " << c << " cm." << endl;

		float perimeter = perimeter_funct(); // opseg
		cout << "Opseg trokuta iznosi " << perimeter << " cm." << endl;

		float area = area_funct(); // povrsina
		cout << "Povrsina trokuta iznosi " << area << " cm2." << endl;
	}
	else cout << "Sve tocke leze na istom pravcu." << endl;

	screen_clean_funct(); // Zakomentirajte liniju koda ukoliko zelite ispis svih zadataka bez brisanja windowa.

	cout << "Zadatak 2: \n" << endl;
	/*  Neka korisnik unese godinu svog roğenja a aplikacija neka mu ispise je li ta godina bila
	prijestupna ili ne. Za odreğivanje je li godina prijestupna koristi funkciju. Varijabla godina_rodjenja
	neka bude globalna. Funkcija neka u main vrati 1 ako je godina prijestupna ili 0 ako nije. Iz maina ispisi
	prikladnu poruku.  */

	cout << "Unesite Vasu godinu rodenja: ";
	cin >> godina_rodenja;

	bool prestupna = prestupnaCheck();

	if (prestupna)
		cout << "\nVasa godina rodenja bila je prijestupna godina." << endl;
	else
		cout << "\nVasa godina rodenja nije bila prijestupna godina." << endl;

	screen_clean_funct(); // Zakomentirajte liniju koda ukoliko zelite ispis svih zadataka bez brisanja windowa.

	cout << "Zadatak 3: \n" << endl;
	/*  Korisnik neka unese koeficijente kvadratne jednadzbe a aplikacija neka mu izraèuna rjesenja
	te jednadzbe. Zasebno izdvojite funkciju koja ĉe vratiti vrijednost diskriminante. Koeficijenti a, b i c neka
	budu globalne varijable */

	cout << "Unesite kvadratni clan: ";
	cin >> a;

	cout << "Unesite linearni clan: ";
	cin >> b;

	cout << "Unesite slobodni clan: ";
	cin >> c;

	diskriminanta = diskriminanta_calc();

	pair<float, float> x = quadratic_funct();

	cout << "\nRjesenja jednadzbe su: " << endl;
	cout << "x1: " << x.first << endl;
	cout << "x2: " << x.second << endl;

	return 0;
}

pair <float, float> quadratic_funct() {
	float x1 = ((-(b) + (sqrt(diskriminanta))) / (2 * a));
	float x2 = ((-(b) - (sqrt(diskriminanta))) / (2 * a));

	return make_pair(x1, x2);
}

float diskriminanta_calc() {
	return (pow(qB, 2) - (4 * qA * qC));
}

bool prestupnaCheck() {
	if (godina_rodenja % 4 == 0)
		return true;
	else
		return false;
}

float area_funct() {
	float s = perimeter_funct() / 2;
	return (sqrt(s * (s - a) * (s - b) * (s - c)));
}

float perimeter_funct() {
	return (a + b + c);
}

void side_calc() {
	a = sqrt(pow((T1[0] - T2[0]), 2) + pow((T1[1] - T2[1]), 2));
	b = sqrt(pow((T2[0] - T3[0]), 2) + pow((T2[1] - T3[1]), 2));
	c = sqrt(pow((T3[0] - T1[0]), 2) + pow((T3[1] - T1[1]), 2));
}

bool same_line_check() {
	/* Zbog compiler postavki u VS-u, a vjerujem da vrijedi i za ostale
	   programe koji compile-aju C++ program, djeljenje sa 0 nije moguće, tj.
	   nije programu poznato, te time automatski break-a program.
	   Ovo bi bio jedan od nacina da se takvo sto izbjegne */

	if (T3[0] - T1[0] == 0 || T3[1] - T1[1] == 0)
		return false;
	else if ((T2[0] - T1[0]) / (T3[0] - T1[0]) == (T2[1] - T1[1]) / (T3[1] - T1[1]))
		return true;
	else
		return false;
}

void unos_triangle() {
	cout << "Unesite tocke x1 y1: ";
	cin >> T1[0] >> T1[1];

	cout << "Unesite tocke x2 y2: ";
	cin >> T2[0] >> T2[1];

	cout << "Unesite tocke x3 y3: ";
	cin >> T3[0] >> T3[1];

	goahead = same_line_check();
}
