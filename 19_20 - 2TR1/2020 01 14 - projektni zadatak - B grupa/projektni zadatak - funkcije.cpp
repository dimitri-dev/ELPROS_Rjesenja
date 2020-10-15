#include "pch.h"
#include <iostream>
#include <cmath>
#include <algorithm>

// 1. zadatak:
void introduction();

// 2. zadatak:
float global_roofWidth, global_roofLenght;
void loc_roof_calc(float fP, float iWP);

// 3. zadatak:
float global_roomWidth, global_roomLenght, global_roomHeight;
float global_paintPrice, global_roomAmount;
float global_room_calc();

// 4. zadatak:
float global_rent_calc(int n_OneBed, int n_TwoBed, float n_obPrice, float n_tbPrice);

// 5. zadatak:
int global_recurs_ticket_sum = 0;
int global_ticket_calc_recurs(int nTickets, int tPrice);

int main()
{
	introduction();
	
	std::cout << "\nUnesite sirinu i duljinu krova u m: ";
	std::cin >> global_roofWidth >> global_roofLenght;

	float loc_foilPrice;

	std::cout << "Unesite cijenu folije u kn/m2: ";
	std::cin >> loc_foilPrice;

	float loc_isolWorkPrice;

	std::cout << "Unesite cijenu izolaterskih radova u kn/m2: ";
	std::cin >> loc_isolWorkPrice;

	loc_roof_calc(loc_foilPrice, loc_isolWorkPrice);

	std::cout << "\nUnesite sirinu, duljinu i visinu sobe u m: ";
	std::cin >> global_roomWidth >> global_roomLenght >> global_roomHeight;

	std::cout << "Unesite broj soba na gornjem katu: ";
	std::cin >> global_roomAmount;

	std::cout << "Unesite cijenu odabrane boje u kn/m2: ";
	std::cin >> global_paintPrice;

	std::cout << "Za bojanje zidova i stropova u " << global_roomAmount << " soba, trebati ce vam " << global_room_calc() << " kn.\n";

	int loc_nOneBed, loc_nTwoBed;

	std::cout << "\nUnesite broj zauzetih jednokrevetnih, pa dvokrevetnih sobi: ";
	std::cin >> loc_nOneBed >> loc_nTwoBed;

	float loc_nOneBedPrice, loc_nTwoBedPrice;

	std::cout << "Unesite cijenu jednokrevetne, pa dvokrevetne sobe u kn/nocenju: ";
	std::cin >> loc_nOneBedPrice >> loc_nTwoBedPrice;

	std::cout << "Zarada od nocenja za inajmljenih " << loc_nOneBed << " jednokrevetnih i " << loc_nTwoBed << " dvokrevetnih soba je " << global_rent_calc(loc_nOneBed, loc_nTwoBed, loc_nOneBedPrice, loc_nTwoBedPrice) << " kn. \n";
	
	int loc_nTicketSold;

	std::cout << "\nUnesite broj prodanih ulaznica za saunu: ";
	std::cin >> loc_nTicketSold;

	int loc_ticketPrice;

	std::cout << "Unesite cijenu ulaznice u kn/kom.: ";
	std::cin >> loc_ticketPrice;

	std::cout << "Zarada od saune za prodanih " << loc_nTicketSold << " ulaznica po " << loc_ticketPrice << " kn iznosi " << global_ticket_calc_recurs(loc_nTicketSold, loc_ticketPrice) << " kn.";

	getchar();
	return 0;
}

int global_ticket_calc_recurs(int nTickets, int tPrice)
{
	if (nTickets == 0) return global_recurs_ticket_sum;
	else
	{
		global_recurs_ticket_sum += tPrice;
		global_ticket_calc_recurs((nTickets - 1), tPrice);
	}
}

float global_rent_calc(int n_OneBed, int n_TwoBed, float n_obPrice, float n_tbPrice)
{
	float sum = 0;
	for (int i = 0; i < std::max(n_OneBed, n_TwoBed); i = -~i)
	{
		if (i < n_OneBed) sum += n_obPrice;
		if (i < n_TwoBed) sum += n_tbPrice;
	}

	return sum;
}

float global_room_calc()
{
	float loc_roomSurface = 4 * (global_roomHeight * global_roomLenght) + (global_roomLenght * global_roomWidth);
	float loc_paintAmount = 20 * loc_roomSurface;
	float loc_moneySpent = loc_paintAmount / 8 * global_paintPrice;

	return loc_moneySpent;
}

void loc_roof_calc(float fP, float iWP)
{
	float loc_roofSurface = global_roofLenght * global_roofWidth;
	float loc_moneyForFoil = fP * loc_roofSurface;
	float loc_moneyForIsolWork = iWP * loc_roofSurface;
	float loc_moneyTotal = loc_moneyForFoil + loc_moneyForIsolWork;

	std::cout << "Za " << loc_roofSurface << " m2 krova, trebati ce vam " << loc_moneyForFoil << " kn za foliju, te " << loc_moneyForIsolWork << " kn za radove, odnosno ukupno " << loc_moneyTotal << " kn.\n";
}

void introduction()
{
	std::cout << "Dobro dosli u aplikaciju koja ce Vam pomoci pri planiranju obnove vaseg hotela \n";
}