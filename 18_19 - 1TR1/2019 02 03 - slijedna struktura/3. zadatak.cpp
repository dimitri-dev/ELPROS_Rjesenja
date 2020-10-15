#include <iostream>
#include <cstdlib>
#include <cmath>
#include <algorithm>

/*
Na školskoj ploči sam pročitao da  60 % ukupnog broja svih nastavnika moje škole dolazi u školu biciklom.
Samo 12 % ukupnog broja svih nastavnika dolazi u školu automobilom.
Koliko nastavnika dolazi u školu automobilom?
Korisnik unosi n - ukupni broj nastavnika u školi.
*/

using namespace std;

int main()
{
	int n;
		cout << "Unesite broj nastavnika u skoli:  ";
	cin >> n;

	int n_biciklo = n * 0.12;

	cout << "U skolu biciklom dolazi " << n_biciklo << " nastavknika." << endl;
	return 0;
}