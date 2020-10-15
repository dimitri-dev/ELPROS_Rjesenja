#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
	const int spin = 48000; // 800 spins per minute; 48000 spins per hour
	const int time = 2; // 2 hours
	const double pi = 3.141592653589793238463;
	
	float n; // n is 2r (d) of the wheel
	cout << "Unesite promjer kotača u cm :  ";
	cin >> n;

	double actual_d;
	actual_d = n * 0.00001; // centimeter to kilometer

	double O, v, s;

	O = 2 * pi * (actual_d/2); // circumference of the circle in kilometers - O = 2 * r * pi

	v = O * spin; // https://sciencing.com/calculate-wheel-speed-7448165.html

	s = v * time;
	
	cout << "Automobil je prevalio put od " << s << " km." << endl;
	return 0;
}