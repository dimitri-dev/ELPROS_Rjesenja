#ifndef LANG

#define LANG

#include <string>

typedef std::string string;
typedef std::wstring wstring;

struct game_HRV
{
	wstring cTitle = L"Milijunaš iz EMŠE";

	string welcome = "Dobrodošli u Milijunaša!\n";
	string error = "Pogrješka 404: Opcija nije pronađena.\n";
	string key = "Molimo pritisnite tipku nakon koje ova aplikacija ce se iskljuciti.\n";

	string loadError = "Dogodila se greška tokom ucitavanja pitanja.\n";
	string choiceError = "Dogodila se greška tokom odabira odgovora.\n";

	string choice = "Vaš odabir: ";

	string joker = "Imate mogucnost uporabe joker-a, ukoliko ga želite iskoristiti upišite JOKER.\n";
	string giveup = "Ukoliko želite odustati, upišite ABORT.\n";

	string correctAns = "TAČAN ODGOVOR!!!\n";

	string earned = "Zaradili ste: ";

	string totaled = "Vaš konacan dobitak iznosi ";

	string millionaire = "Svaka cast!!! Postali ste milijunaš!";
};

struct game_ENG
{
	wstring cTitle = L"Millionaire from EMŠA";

	string welcome = "Welcome to Millionaire!\n";
	string error = "Error 404: Option not found\n";
	string key = "Please press a key after which this application will exit.\n";

	string loadError = "An error has occured while loading the questions.\n";
	string choiceError = "An error has occured while choosing the answer.\n";

	string choice = "Your choice: ";

	string joker = "Your joker is stil available, if you wish to use it just type JOKER.\n";
	string giveup = "If you want to give up, just type ABORT.\n";

	string correctAns = "CORRECT ANSWER!!!\n";

	string earned = "You have earned: ";

	string totaled = "The amount of money you're going home with is: ";

	string millionaire = "Congratulations!!! You are a millionaire!";
};

#endif