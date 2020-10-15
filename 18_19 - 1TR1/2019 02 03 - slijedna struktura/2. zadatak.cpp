#include <iostream>
#include <cstdlib>
#include <cmath>
#include <algorithm>

/*
Veliki pravokutnik sastoji se od devet sukladnih manjih pravokutnika kako je prikazano na slici.
Korisnik unosi duljinu veće stranice manjeg pravokutnika, izračunaj opseg velikog pravokutnika?
*/

using namespace std;

int main()
{
	float small_rectangle_b;
		cout << "Unesite vecu stranicu manjeg pravokutnika u cm:  ";
	cin >> small_rectangle_b;

	float big_rectangle_a = small_rectangle_b * 2; // velika stranica "b" ako je preokrenuta na slici jednaka je kao pola stranice "a" velikog pravokutnika
	float small_rectangle_a = big_rectangle_a / 5; // stranica "a" se dijeli na pet manjih pravokutnika u sredini
	float big_rectangle_b = small_rectangle_b + 2 * small_rectangle_a; // mala stranica preokrenuta na slici jednaka je kao stranica koja dijeli dva pravokutnika gore i dole na slici, i paralelna je dijelom stranice "b" velikog pravokutnika

	/*
	TEST da obje stranice nisu jednake jer bi ona tvorile kvadrat

	cout << "velik a : " << big_rectangle_a << endl;
	cout << "velik b : " << big_rectangle_b << endl;

	*/

	float opseg = 2 * (big_rectangle_b + big_rectangle_a);
	cout << "Opseg velikog pravokutnika je " << opseg << " centimetara kvadratnih." << endl;
	return 0;
}