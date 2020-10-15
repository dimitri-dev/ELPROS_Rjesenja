#include "pch.h"
#include <algorithm>
#include <cmath>
#include <ctime>
#include <iostream>
#include <string>

using namespace std;

int main()
{
	cout << "1. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	unsigned long long int maraton[10] = { 0 };
	unsigned long long int temp = 0, sumRun = 0;

	for (int i = 0; i < 10; ++i)
	{
		cout << "Unesite sate " << i + 1 << ". maratonca: ";
		cin >> temp;

		maraton[i] += (temp * 3600);

		cout << "Unesite minute " << i + 1 << ". maratonca: ";
		cin >> temp;

		maraton[i] += (temp * 60);

		cout << "Unesite sekunde " << i + 1 << ". maratonca: ";
		cin >> temp;

		maraton[i] += temp;

		sumRun += maraton[i];

		cout << endl;
	} 

	int avgRunH = (sumRun / 10) / 3600;
	int avgRunMIN = ((sumRun / 10) - (avgRunH * 3600)) / 60;
	int avgRunSEC = ((sumRun / 10) - (avgRunH * 3600) - (avgRunMIN * 60));

	cout << "Prosjecno vrijeme najboljih rezultata trcanja maratona je " << sumRun / 10 << " sekundi iliti " << avgRunH << " h " << avgRunMIN << " min " << avgRunSEC << " sec." << endl;

	cout << "Prosjecna brzina najboljih rezultata trcanja maratona je " << 42.195 / float((sumRun / 10) / 3600) << " km/h." << endl;

	cout << "_________________________________________________" << endl;
	cout << endl;
	cout << endl;
	
	cout << "2. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	unsigned long long int bloodGivers[12][3] = { // redni broj, procenat (maknuta decimala), broj stanovnika
												{1, 97, 7318640}, // Švajcarska, 2003 wiki
												{2, 81, 61538322}, // Francuska, 2007 wiki
												{3, 74, 5520535}, // Finska, 2018 wiki
												{4, 66, 5806015}, // Danska, 2018 wiki
												{5, 59, 11116243}, // Belgija, 2012 wiki
												{6, 49, 10215250}, // Švedska, 2018 wiki
												{7, 48, 5328212}, // Norveška, 2019 wiki
												{8, 46, 4588252}, // Irska, 2011 wiki
												{9, 46, 16669112}, // Nizozemska, 2006 wiki
												{10, 38, 4298889}, // Hrvatska, 2011 wiki
												{11, 15, 46572028}, // Spanjolska, 2017 wiki
												{12, 61, 325719178}}; // SAD, 2017 wiki

	unsigned long long int totalBloodGivers = 0;

	string drzave[12] = { "Svicarskoj", "Francuskoj", "Finskoj",
						  "Danskoj", "Belgiji", "Svedskoj",
						  "Norveskoj", "Irskoj", "Nizozemskoj",
						  "Hrvatskoj", "Spanjolskoj", "SAD-u" };

	for (int i = 0; i < 12; ++i)
		totalBloodGivers += ((bloodGivers[i][2] * 10) / bloodGivers[i][1]);

	cout << "Ukupan broj dobrovoljnih darivatelja je: " << totalBloodGivers << " ljudi." << endl;

	cout << endl;

	for (int i = 0; i < 12; ++i)
		cout << "Prosjecan broj darivatelja u " << drzave[i] << " iznosi " << ((bloodGivers[i][2] * 10) / bloodGivers[i][1]) << " ljudi." << endl;;

	cout << "_________________________________________________" << endl;
	cout << endl;
	cout << endl;
	
	cout << "3. zadatak:" << endl;
	cout << "_________________________________________________" << endl;
	cout << endl;

	unsigned int studentNumber[10][2] = { // broj ucenika 2018/2019, 2019/2020
										{800, 896}, // sibensko-kninska zupanija
										{1071, 1162}, // krapinsko-zagorska zupanija
										{1652, 1741}, // zadarska zupanija
										{1036, 1101}, // koprivnicko-krizevacka
										{984, 1014}, // bjelovarsko-bilogorska
										{970, 995}, // karlovacka
										{345, 363}, // licko-senjska
										{628, 644}, // pozesko-slavonska
										{1536, 1548}, // varazdinska
										{1168, 1171} }; // dubrovacko-neretvanska

	unsigned int temp2018 = 0, temp2019 = 0;

	for (int i = 0; i < 10; ++i) {
		temp2018 += studentNumber[i][0];
		temp2019 += studentNumber[i][1];
	}

	if (temp2019 > temp2018)
		cout << "Skolske godine 2019/2020 bio je veci broj upisanih ucenika za " << temp2019 - temp2018 << " ucenika." << endl;
	else if (temp2018 > temp2019)
		cout << "Skolske godine 2018/2019 bio je veci broj upisanih ucenika za " << temp2018 - temp2019 << " ucenika." << endl;
	else
		cout << "Obje skolske godine bio je upisan isti broj ucenika." << endl;

	return 0;
}

