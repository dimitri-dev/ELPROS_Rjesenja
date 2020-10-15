#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>

struct Djelatnici
{
	char ID[20];
	char ime[20];
	char brojTelefona[13];
};

struct Automobil
{
	char proizvodjac[20];
	char model[20];
	int godinaProizvodnje;
};

struct Film
{
	char imeFilma[30];
	char zanr[20];
	int trajanje;
	int godina;
};

struct Ucenik
{
	int rBr;
	char ime[30];
	char prezime[30];
	int danRodenja;
	int mjesecRodenja;
	int godinaRodenja;
};

void workerIspis(Djelatnici[], int);
void carIspis(Automobil[], int, std::string);
void movieIspis(Film[], int, std::string);
void studentIspis(Ucenik[], int, int);

int main()
{
	char rand;

	int n;
	printf("1. Unesite broj djelatnika: ");
	scanf("%d", &n);

	struct Djelatnici* workers = new Djelatnici[n];

	for (int i = 0; i < n; ++i)
	{
		printf("Unesite ime %d. djelatnika: ", i + 1);
		scanf("%s", &workers[i].ime);

		printf("Unesite ID %d. djelatnika: ", i + 1);
		scanf("%s", &workers[i].ID);

		printf("Unesite broj telefona %d. djelatnika: ", i + 1);
		scanf("%s", &workers[i].brojTelefona);
	}

	workerIspis(workers, n);

	Automobil auti[10] =
	{
		{"Daimler-Benz", "StuG III Ausf. A", 1940},
		{"Maybach", "Panzer III Ausf. L", 1941},
		{"AvtoVAZ", "Lada Niva", 1977},
		{"Zastava", "Yugo 45", 1981},
		{"Fiat", "Multipla", 1998},
		{"Skoda", "Fabia", 1999},
		{"Tesla", "Model S", 2012},
		{"Tesla", "Model 3", 2017},
		{"Tesla", "Model Y", 2019},
		{"Tesla", "Cybertruck", 2020}
	};

	std::string proizvodjac;
	printf("\n2. Unesite proizvodaca auta: ");
	std::cin >> proizvodjac;

	carIspis(auti, 10, proizvodjac);

	Film filmovi[10] =
	{
		{"Sonic: Super Jez", "akcija", 100, 2020},
		{"Parazit", "drama", 132, 2019},
		{"BloodShot", "akcija", 110, 2020},
		{"Izvan igre", "drama, Sport", 108, 2020},
		{"Mjesto tisine 2", "horor", 98, 2020},
		{"Zov divljine", "avantura", 100, 2020},
		{"Otok fantazija", "triler", 109, 2020},
		{"Kao sefica", "komedija", 83, 2020},
		{"Naprijed", "animirani", 102, 2020},
		{"Za smrt nema vremena", "akcija", 164, 2020},

	};

	std::string zanr;
	printf("\n3. Unesite zanr filma: ");
	std::cin >> zanr;

	movieIspis(filmovi, 10, zanr);

	Ucenik ucenik[24] =
	{
		{1, "Antonijo", "Andic",5,3,2003},
		{2, "Denis", "Bede",19,7,2002},
		{3, "Marko", "Blaskovic",12,11,2003},
		{4, "Marko", "Borovec",20,7,2003},
		{5, "Lars", "Cupec",18,1,2004},
		{6, "Bruno", "Denisov",27,12,2003},
		{7, "Iva", "Egredzija",27,7,2003},
		{8, "Marko", "Hohos",25,6,2003},
		{9, "Borna", "Hrastovic",17,5,2003},
		{10, "Luka", "Kasunic", 7,3,2003},
		{11, "Viktor", "Katalinic",24,12,2003},
		{12, "Marin", "Kreso", 23,12,2003},
		{13, "Luka", "Kuruc",10,7,2003},
		{14, "Filip", "Majdenic",26,2,2004},
		{15, "Daniel", "Malenjak",27,1,2003},
		{16, "Neven", "Maric",26,6,2003},
		{17, "Ivano", "Marinic Sakic",26,3,2004},
		{18, "Ivan", "Mikodanic",8,8,2003},
		{19, "Tena", "Past",30,11,2003},
		{20, "Jakov", "Pavisic",3,4,2003},
		{21, "Benjamin", "Sabo",25,6,2003},
		{22, "Nikola", "Sudar",10,4,2003},
		{23, "Filip", "Turalija",4,4,2003},
		{24, "Robert", "Vranjes",23,9,2003}
	};

	int month;
	printf("\n4. Unesite trazeni mjesec rodenja: ");
	scanf(" %d", &month);

	studentIspis(ucenik, 24, month);

	system("pause");
	return 0;
}

void workerIspis(Djelatnici workers[], int n)
{
	printf("\n%25s %25s %25s\n", "IME", "ID", "BROJ TELEFONA");
	
	for (int i = 0; i < n; ++i)
	{
		printf("%25s %25s %25s\n", workers[i].ime, workers[i].ID, workers[i].brojTelefona);
	}
}

void carIspis(Automobil auti[], int n, std::string proizvodjac)
{
	for (int i = 0; i < n; ++i)
	{
		if (auti[i].proizvodjac == proizvodjac)
			printf("%s\n", auti[i].model);
	}

}
void movieIspis(Film filmovi[], int n, std::string zanr)
{
	for (int i = 0; i < n; ++i)
	{
		if (filmovi[i].zanr == zanr)
			printf("\nIme filma: %s\nTrajanje: %d min\nZanr: %s\nGodina: %d\n", filmovi[i].imeFilma, filmovi[i].trajanje, filmovi[i].zanr, filmovi[i].godina);
	}
}
void studentIspis(Ucenik ucenici[], int n, int mjesec)
{
	for (int i = 0; i < n; ++i)
	{
		if (ucenici[i].mjesecRodenja == mjesec)
		{
			printf("\nIme i prezime ucenika: %s %s\nDatum rodenja: %d.%d.%d\n", ucenici[i].ime, ucenici[i].prezime, ucenici[i].danRodenja, ucenici[i].mjesecRodenja, ucenici[i].godinaRodenja);
		}
	}
}

