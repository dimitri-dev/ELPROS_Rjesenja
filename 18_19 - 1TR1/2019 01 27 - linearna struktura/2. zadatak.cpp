#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
	const double pi = 3.14159;

	float r;
	cout << "Unesi radijus koji balon dosegne kada je napunjen helijem u cm :  ";
	cin >> r;

	int n;
	cout << "Unesi broj dogovorenih gaza u mjesecu :  ";
	cin >> n;

	float actual_r;
	actual_r = r / 10;

	float _1helij;
	_1helij = (4 * pi * pow(actual_r, 3)) / 3;

	double total;
	total = (20 * _1helij) * n;

	cout << "Ukupno bi vam bilo potrebno " << total << " litara helija." << endl; // normal

	cout << "Ukupno bi vam bilo potrebno " << round(total) << " litara helija." << endl; // round
	cout << "Ukupno bi vam bilo potrebno " << floor(total) << " litara helija." << endl; // floor
	cout << "Ukupno bi vam bilo potrebno " << ceil(total) << " litara helija." << endl; // ceil

	cout.precision(2);
	cout << fixed << "Ukupno bi vam bilo potrebno " << total << " litara helija." << endl; // 2 decimals

	return 0;
}