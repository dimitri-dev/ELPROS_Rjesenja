// squidward on a chair.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <algorithm>
#include <ctime>
#include <cmath>
#include <iterator>


using namespace std;

int main()
{
	// Neka je T broj koji se dobiva iz dvoznamenkastoga broja D tako da se zamijene mjesta znamenkama jedinice i desetice.
	// Napišite program koji će učitati dvoznamenkasti prirodan broj D, a ispisati veći od brojeva D i T.
	// (Napomena: Provjeriti je li broj dvoznamenkast.) 
	cout << "1. zadatak: " << endl;
	int T, D;

	cout << "Unesite dvoznamenkasti broj: ";
 re:cin >> D;

	if (!(D > 9 && D < 100)) {
		cout << "Daj ga unesi ponovno. Dvoznamenkasti broj: ";
		goto re;
	}

	T = ((D % 10) * 10 + D / 10);

	if (T > D)
		cout << T << endl;
	else
		cout << D << endl;

	cout << endl;

	// Dva igrača igraju igru u kojoj naizmjence stavljaju kamenčiće na niz polja.
	// Prvi igrač stavlja jedan kamenčić na prvo polje i nakon toga drugi igrač stavlja dva kamenčića na drugo polje.
	// U svakome sljedećem koraku igrač koji je na redu stavlja na sljedeće polje dva puta više kamenčića nego što je stavljeno na prethodno polje.
	// Igra završava kada je broj kamenčića koje je stavio neki igrač u posljednjemu koraku veći ili jednak zadanomu broju N.
	// Napišite program koji će učitati prirodan broj N, a ispisati u kojemu će koraku K završiti igra.
	cout << "2. zadatak: " << endl;
	int N, K = 0, rocks = 1;

	cout << "Unesite prirodan broj: ";
re0:cin >> N;

	if (!(N > 0)) {
		cout << "Daj ga unesi ponovno. Prirodan broj: ";
		goto re0;
	}

	for (K = 1; rocks < N; ++K)
		rocks *= 2;

	cout << "Broj potrebnih koraka je " << K << "." << endl;

	cout << endl;
	
	// Napišite program koji će učitati broj učenika, a zatim za svakoga od tih učenika učitati broj opravdanih izostanaka.
	// Program na kraju treba ispisati najveći od učitanih brojeva opravdanih izostanaka.
	cout << "3. zadatak: " << endl;
	int numeroDeEstudiantes, numeroTemp, numeroMax = 0;

	cout << "Unesite broj ucenika: ";
re3:cin >> numeroDeEstudiantes;

	if (!(numeroDeEstudiantes > 0)) {
		cout << "Daj ga unesi ponovno. Prirodan broj: ";
		goto re3;
	}

	for (int i = 0; i < numeroDeEstudiantes; ++i) {
		cout << "Unesite broj opravdanih izostanaka " << i + 1 << ". ucenika: ";
		cin >> numeroTemp;

		if (numeroTemp > numeroMax)
			numeroMax = numeroTemp;
	}

	cout << "Najveći broj opravdanih izostanaka bio je " << numeroMax << endl;

	cout << endl;
	
	// Mirta je odlučila renovirati svoju kupaonicu kvadratnoga tlocrta s duljinom stranice A centimetara.
	// Stavit će kvadratne podne pločice s duljinom stranice B centimetara.
	// Napišite program koji će učitati brojeve A i B te ispisati koliko najmanje pločica Mirta treba kupiti.
	// Napomena: Može se dogoditi da keramičar mora rezati neke pločice.
	// Preostale dijelove odrezanih pločica neće ponovno upotrijebiti.
	cout << "4. zadatak: " << endl;
	float A_kupaonica, B_plocice;
	float P_kupaonica, P_plocice;

	cout << "Unesite stranicu kupaonice u m: ";
re4a:cin >> A_kupaonica;

	if (!(A_kupaonica > 0)) {
		cout << "Daj ga unesi ponovno. Prirodan broj: ";
		goto re4a;
	}

	P_kupaonica = pow(A_kupaonica, 2);

	cout << "Unesite stranicu plocica u m: ";
re4b:cin >> B_plocice;

	if (!(B_plocice > 0)) {
		cout << "Daj ga unesi ponovno. Prirodan broj: ";
		goto re4b;
	}

	P_plocice = pow(B_plocice, 2);

	float numeroDePlates = P_kupaonica / P_plocice;

	cout << "Trebate kupiti " << ceil(numeroDePlates) << " plocica." << endl;

	cout << endl;

	// Napišite program koji će učitati tri prirodna broja a, b i c.
	// Program treba ispisati „Da” ako je a paran broj i veći je od b ili ako je c neparan broj.U suprotnome program treba ispisati „Ne”.
	cout << "5. zadatak: " << endl;
	int a, b, c;

	cout << "Unesite prirodan broj a: ";
re5a:cin >> a;

	if (!(a > 0)) {
		cout << "Daj ga unesi ponovno. Prirodan broj a: ";
		goto re5a;
	}

	cout << "Unesite prirodan broj b: ";
re5b:cin >> b;

	if (!(b > 0)) {
		cout << "Daj ga unesi ponovno. Prirodan broj b: ";
		goto re5b;
	}

	cout << "Unesite prirodan broj c: ";
re5c:cin >> c;

	if (!(c > 0)) {
		cout << "Daj ga unesi ponovno. Prirodan broj c: ";
		goto re5c;
	}

	if ((a % 2 == 0 && a > b) || (c % 2 == 1))
		cout << "Da" << endl;
	else
		cout << "Ne" << endl;

	system("pause");
	return 0;
}

