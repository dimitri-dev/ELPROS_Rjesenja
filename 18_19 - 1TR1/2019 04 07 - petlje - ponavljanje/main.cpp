#include "pch.h"
#include <iostream>
#include <ctime>
#include <iomanip>

using namespace std;

int main()
{
	cout << "1. zadatak: " << endl;
	// Stojiš li na Mjesecu tvoja tjelesna masa biti æe 16.5 % tvoje mase na Zemlji.
	// Ako se na Zemlji svake godine udebljaš po jedan kilogram koliko bi tvoja masa svake godine iznosila na Mjesecu?
	// Ispiši rezultate za period  od 15 godina, koristeæi petlju for.

	float mass;

	cout << "Unesite vasu trenutnu masu: ";
	cin >> mass;

	for (int god = 1; god <= 15; ++god)
	{
		cout << "Vasa masa " << god << ". godine na mjesecu je " << mass * 0.165 << " kg." << endl;
		++mass;
	}

	cout << "-----------------------------------------------------------------" << endl;
	cout << "2. zadatak: " << endl;
	// Marija radi u peèenjarnici. Koristeæi petlju while izradi joj aplikaciju.
	// Kada gost naruèi male ili velike æevape a Marija unese M ili V.
	// Mala porcija æevapa sadrži 5 æevapa i košta 20 kn, a velika 10 æevapa i košta 30 kn.
	// Na kraju dana radi obraèun. Za zakljuèak dana unosi slovo G. Izradi joj aplikaciju koja æe joj ispisati:
	// 1.dnevni utržak (kolièinu novca u blagajni)
	// 2. broj ispeèenih æevapèiæa

	int cash = 0, sum_cevapi = 0;
	char cInput;

	cout << "Za kraj dana unesite slovo G." << endl;
	cout << "Unesite vrstu narudzbe (M ili V):";
	cin >> cInput;

	while (cInput != 'G')
	{
		if (cInput == 'M')
		{
			sum_cevapi += 5;
			cash += 20;
		}

		if (cInput == 'V')
		{
			sum_cevapi += 10;
			cash += 30;
		}

		cout << "Unesite vrstu narudzbe (M ili V):";
		cin >> cInput;

	}

	cout << "Vas dnevni utrzak ovoga dana je " << cash << " kn." << endl;
	cout << "Broj sveukupno danas ispecenih cevapcica je " << sum_cevapi << "." << endl;

	cout << "-----------------------------------------------------------------" << endl;
	cout << "3. zadatak: " << endl;
	// Poèetna startna cijena prijevoza taksijem je 9.90 kn, a svaki dodatni kilometar naplaæuje se 4.90 kn.
	// Ivica ima jako puno vožnji dnevno i teško mu je pratiti koliko novca treba imati u blagajni.
	// Izradi mu aplikaciju u koju æe po završetku svake vožnje unijeti broj km. Za kraj radnog dana unosi 0.
	// Aplikacija mu treba ispisati broj odvezenih vožnji i ukupnu zaradu. Koristi petlju do while.

	int rides = 0;
	float pare = 0, ride_cost = 0, milage_input;

	cout << "Za kraj radnoga dana unesite 0." << endl;

	do
	{
		cout << "Koliko ste kilometara presli: ";
		cin >> milage_input;

		if (milage_input == 0)
		{
			break;
			cout << endl;
		}

		ride_cost = 9.90 + (milage_input * 4.90);
		pare += ride_cost;
		++rides;
	} while (milage_input != 0);

	cout << "Ukupno ste danas imali " << rides << " voznji." << endl;
	cout << "Od njih ste zaradili " << pare << " kn." << endl;

	cout << "-----------------------------------------------------------------" << endl;
	cout << "4. zadatak: " << endl;
	// Josip pohaða teèaj programiranja na Trinity college-u  u Dublinu.
	// Ima prepaid karticu za transport, ali ju mora vratiti punu kad bude odlazio.
	// U ovisnosti o tome ide li autobusom ili vlakom s raèuna mu se skida odreðeni iznos novca.
	// Na raèunu je u poèetku bilo 30 €. Koristeæi petlju for izradi mu aplikaciju koja æe mu pomoæi da zna koliko novca treba uplatiti.
	// Na teèaju je 5 dana tj. ima deset vožnji. Kada putuje autobusom unese A, a kada ide vlakom V.
	// Jedna vožnja vlakom košta 2.40 €, a vožnja busom 2.80 €. Ispiši mu iznos koji treba uplatiti.


	float uplata = 0, balance = 30;
	char cInputTransport;

	for (int transport = 0; transport < 10; ++transport)
	{
		cout << "Ukoliko putujete autobusom unesite A, a ako vlakom onda V: ";
		cin >> cInputTransport;

		if (cInputTransport == 'A')
		{
			balance -= 2.80;
			uplata += 2.80;
		}

		else if (cInputTransport == 'V')
		{
			balance -= 2.40;
			uplata += 2.40;
		}

		else
		{
			cout << "Niste napravili pravilan unos. Molimo unesite vrstu prijevoza ponovno." << endl;
			--transport;
		}
	}

	cout << "Na vasoj prepaid kartici za transport ostalo je " << balance << " €, te kako bi je vratili na pocetnu vrijednost morate uplatiti " << uplata << " €." << endl;

	

	cout << "-----------------------------------------------------------------" << endl;
	cout << "5. zadatak: " << endl;
	// Marta radi na blagajni kantine studentskog centra. Svaki student uzima hranu koja mu se sviða i dolazi na blagajnu.
	// Na blagajni su tipke: J – za juhu, G – za glavno jelo, S – za salatu, K – za kruh, V – za voæe, N – za napitak i D – za desert.
	// Juha košta 4 kn, glavno jelo 6 kn, salata 2  kn, komad kruha 0.5 kn, voæe 2 kn, napitak 5 kn, te desert 4 kn.
	// Marta stišæe tipke onoliko puta koliko je takvih artikala pojedini student uzeo npr. za dvije šnite kruha stisne K dva puta.
	// Za kraj stisne tipku R koja ispisuje raèun. Izradi aplikaciju koja ispisuje raèun. Koristi petlju while.

	float countJ = 0, countG = 0, countS = 0, countK = 0, countV = 0, countN = 0, countD = 0;
	char cInputCashier;

	cout << "Za ispis racuna unesite slovo R." << endl;
	cout << "Unesite tipku s blagajne: ";
	cin >> cInputCashier;

	while (cInputCashier != 'R')
	{
		if (cInputCashier == 'J')
			countJ++;
		else if (cInputCashier == 'G')
			countG++;
		else if (cInputCashier == 'S')
			countS++;
		else if (cInputCashier == 'K')
			countK++;
		else if (cInputCashier == 'V')
			countV++;
		else if (cInputCashier == 'N')
			countN++;
		else if (cInputCashier == 'D')
			countD++;
		else
			cout << "Niste unijeli niti jednu od mogucih opcija. Molimo pokusajte ponovno." << endl;

		cout << "Unesite tipku s blagajne: ";
		cin >> cInputCashier;
	}

	float sum = (countJ * 4) + (countG * 6) + (countS * 2) + (countK * 0.5) + (countV * 2) + (countN * 5) + (countD * 4);

	cout << endl;

	// Kao primjer racuna koristen je http://mojfaks.com/uploads/images/content/789529459634211.jpg uz minijaturne izmjene

	srand(time(NULL));

	cout << "Racun broj: " << rand() % 300 + 2726 << endl;
	cout << endl;

	cout << "Naziv" << setw(13) << "Kom" << setw(20) << "Jedinicna cijena" << setw(10) << "Iznos" << endl;
	cout << endl;

	cout.precision(2);

	if (countJ > 0)
		cout << fixed << "Juha" << setw(15) << countJ << setw(13) << "4,00" << setw(16) << 4*countJ << endl;
	if (countG > 0)
		cout << fixed << "Glavno jelo" << setw(8) << countG << setw(13) << "6,00" << setw(16) << 6 * countG << endl;
	if (countS > 0)
		cout << fixed << "Salata" << setw(13) << countS << setw(13) << "2,00" << setw(16) << 2 * countS << endl;
	if (countK > 0)
		cout << fixed << "Kruh" << setw(15) << countK << setw(13) << "0,50" << setw(16) << 0.5 * countK << endl;
	if (countV > 0)
		cout << fixed << "Voce" << setw(15) << countV << setw(13) << "2,00" << setw(16) << 2 * countV << endl;
	if (countN > 0)
		cout << fixed << "Napitak" << setw(12) << countN << setw(13) << "5,00" << setw(16) << 5 * countN << endl;
	if (countD > 0)
		cout << fixed << "Desert" << setw(13) << countD << setw(13) << "4,00" << setw(16) << 4 * countD << endl;

	cout << "-------------------------------------------------------" << endl;

	cout << "Za platiti Kn:" << setw(34) << fixed << sum << endl;

	cout << "-------------------------------------------------------" << endl;

	cout << "PDV nije zaracunat po cl. 39 Zakona" << endl;
	cout << endl;

	cout << "-----------------------------------------------------------------" << endl;
	cout << "6. zadatak: " << endl;
	// Marko, Ana i Ivana rade u nadnici, beru grožđe.
	// Svaki dan dobiju 20 kn + plus po 0.25 kn za svaki kg grožđa koji uberu.
	// Oni donose grožđe u kanti, unesu početno slovo svog imena i istresu ga na vagu koja svaki puta memorira masu grožđa i dodaje pojedinom računu.
	// Izradi aplikaciju za takvu vagu. Za kraj radnog dana poslovođa unosi 0.
	// Aplikacija mu ispisuje ukupnu zaradu za taj dan za svakog od njih. Koristi petlju do while.

	float pay_M = 0, pay_I = 0, pay_A = 0, kg_NotAssigned = 0, kg_M = 0, kg_I = 0, kg_A = 0;
	char cName;

	cout << "Za kraj radnoga dana unesite 0." << endl;

	do
	{
		cout << "Unesite prvo slovo vaseg imena: ";
		cin >> cName;

		if (cName == '0') // Testira se samo na prvom unosu da li je kraj radnoga dana
		{
			break;
			cout << endl;
		}

		cout << "Unesite masu grozda sa vage: ";
		cin >> kg_NotAssigned;

		if (cName == 'M')
			kg_M += kg_NotAssigned;
		else if (cName == 'I')
			kg_I += kg_NotAssigned;
		else if (cName == 'A')
			kg_A += kg_NotAssigned;
		else
			cout << "Nije unesen niti jedan postojeći korisnik." << endl;

	} while (cName != 0);

	pay_A = 20 + (kg_A * 0.25);
	pay_I = 20 + (kg_I * 0.25);
	pay_M = 20 + (kg_M * 0.25);

	cout << "Danasnja zarada: " << endl;
	cout << "Ana : " << kg_A << " kg = " << pay_A << " kn " << endl;
	cout << "Ivana : " << kg_I << " kg = " << pay_I << " kn " << endl;
	cout << "Marko : " << kg_M << " kg = " << pay_M << " kn " << endl;
	return 0;
}