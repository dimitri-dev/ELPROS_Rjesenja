#include <iostream>
#include <string>
#include <time.h>
#include <cstdlib>
#include <math.h>

using namespace std;

int main() { 
	cout << "1. zadatak: " << endl;
	cout << "________________________________________________________________________" << endl;
	cout << endl;
	
	float kilometri, cijenaNocenjaPoOsobi;
	
	cout << "Unesite broj kilometara: ";
	cin >> kilometri;
	
	srand(time(0));
	
	float cijenaGoriva = roundf((( rand() / (float)RAND_MAX * 1)  + 9) * 100) / 100; // rand izmedu devet i deset, ne zaboravi HAAHAHAHAHAHAHAAH
	float ukupanTrosakGorivo = kilometri * (6.88/100) * cijenaGoriva;
	
	cout << "Unesite cijenu nocenja u €: ";
	cin >> cijenaNocenjaPoOsobi;
	
	float ukupanTrosakNocenjaObitelj = cijenaNocenjaPoOsobi * 4 * 5;
	
	cout.precision(2);
	cout << fixed << "Ukupan trosak goriva biti ce : " << ukupanTrosakGorivo << " kn." << endl;
	cout << fixed << "Ukupan trosak nocenja obitelji za 5 dana biti ce : " << ukupanTrosakNocenjaObitelj << " €." << endl;
	
	cout << endl;
	
	cout << "2. zadatak: " << endl;
	cout << "________________________________________________________________________" << endl;
	cout << endl;
	
	string unos;
	
	cout << "Unesite opciju budenja (RD, S ili N): ";
 re:cin >> unos;
	
	if (unos == "RD") cout << "Alarm ce zvoniti sutra u 9 sati." << endl;
	
	else if (unos == "S") cout << "Alarm ce zvoniti sutra u 10 sati." << endl;
		
	else if (unos == "N") cout << "Alarm sutra nece zvoniti." << endl;
	
	else {
		cout << "Unos nije valjan. Molimo unesite ponovno: ";
		goto re;
	}
		
	cout << endl;
	
	cout << "3. zadatak: " << endl;
	cout << "________________________________________________________________________" << endl;
	cout << endl;
	
	float start = 5000, spent_temp, spent_max = 0;
	
	cout << "Za kraj unosa unesite 0." << endl;
	
	cout << endl;
	
	do
	{
		cout << "Unesite cijenu sa racuna: ";
		cin >> spent_temp;
		
		spent_max += spent_temp;
	}while (spent_temp != 0);
	
	cout << endl;
	
	float end = start - spent_max;
	
	if (end >= 0) cout << "Od ukupnog iznosa od 5000 kn potrosili ste " << spent_max << " kn sto Vas ostavlja sa " << end << " kn." << endl;
	else cout << "Prekardasili ste iznos od 5000 kn za " << -end << " kn." << endl;
	
	cout << endl;
	
	cout << "4. zadatak: " << endl;
	cout << "________________________________________________________________________" << endl;
	cout << endl;
	
	int i, total_swimt;
	for (i = 0, total_swimt = 0; total_swimt < 3860; ++i, total_swimt += 50) {}
	
	cout << "Trebate otplivati bazen duljine 50 metara " << i << " puta." << endl;
	cout << "Koliko vam treba minuta da otplivate 50 m: " << endl;
	
	float swim50min;
	cin >> swim50min;
	
	cout << "Vasa brzina plivanja iznosi " << 1 / (swim50min * 2 * 10) * 60 << " km/h." << endl;
	
	cout << endl;
	
	cout << "5. zadatak: " << endl;
	cout << "________________________________________________________________________" << endl;
	cout << endl;
	
	char ivan_unos;
	
	cout << "Unesite opciju budenja (RD, S ili N): ";
 re_iv:cin >> ivan_unos;
	
	if (ivan_unos == 'P') cout << "Ceka Vas plivanje." << endl;
	
	else if (ivan_unos == 'U' || ivan_unos == 'C') cout << "Ceka Vas voznja biciklom." << endl;
		
	else if (ivan_unos == 'S') cout << "Ceka Vas trcanje." << endl;
	
	else if (ivan_unos == 'N') cout << "Slobodno odmarajte - danas je taj dan." << endl;
	
	else {
		cout << "Unos nije valjan. Molimo unesite ponovno: ";
		goto re_iv;
	}
	
	cout << endl;
	
	cout << "6. zadatak: " << endl;
	cout << "________________________________________________________________________" << endl;
	cout << endl;
	
	float goal = 42.195, run_temp, run_session, break_times;
	
	cout << "Za kraj unosa unesite 0." << endl;
	
	cout << endl;
	
	do
	{
		cout << "Koliko ste do sad istrcali km: ";
		cin >> run_temp;
		
		if(run_temp > 0){
			run_session += run_temp;
			break_times += 1;
			
			if (run_session < goal){
				
				cout << "Trebao bi jos vjezbati, ostalo ti je "<< goal - run_session << " km." << endl;
			}
			else cout << "Bravo!" << endl;
		}
	}while (spent_temp != 0);
	
	return 0;
}
