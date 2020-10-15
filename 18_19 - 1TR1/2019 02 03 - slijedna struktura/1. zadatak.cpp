#include <iostream>
#include <cstdlib>
#include <cmath>
#include <algorithm>

/*
Josip gradi stepenište gdje je svaka stepenica s cm visoka i s cm široka, kako je pokazano na slici.
Koliko treba takvih stepenica da bi drugi kat, izgrađen na h m visine, povezao s prvim katom
*/

using namespace std;

int main()
{
	float step_h, step_w, kat_y;
		cout << "Unesite visinu stepenica u cm:  ";
	cin >> step_h;

		cout << "Unesite sirinu stepenica u cm:  ";
	cin >> step_w;
	
		cout << "Unesite visinu kata u m:  ";
	cin >> kat_y;

	float kat_x = kat_y; // pretpostavka da je x os kata jednaka y osi kata

	float kat_hip = sqrt(pow(kat_x, 2) + pow(kat_y, 2));
	float step_hip = sqrt(pow(step_h, 2) + pow(step_w, 2))/100;

	int max_count = 0;
	float test_var = 0;

	while (test_var < kat_hip)
	{
		test_var = step_hip + test_var;
		max_count = max_count + 1;
	}

	cout << "Ukupno je potrebno " << ceil(max_count) << " stepenica." << endl;
	return 0;
}