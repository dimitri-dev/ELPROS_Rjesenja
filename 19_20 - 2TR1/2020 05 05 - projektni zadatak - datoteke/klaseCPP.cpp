#define _CRT_SECURE_NO_WARNINGS
#include <cmath>
#include <string>
#include <vector>
#include <conio.h>
#include <fstream>
#include <iostream>
#include <algorithm>
#include <windows.h>
#include "LANG.h"

// Defines
#define no false
#define yes true
#define elif else if
#define wait Sleep(2000);
#define CLR system("CLS");
#define waitForKey _getch();
#define newLine printf("\n");
#define SCI SetConsoleWindowInfo(hConsole, 1, &rect);
#define SCR GetConsoleScreenBufferInfo(hConsole, &info);


// Typedefs
typedef int n;
typedef bool used;
typedef long long ll;
typedef const int coord;
typedef std::string string;
typedef SMALL_RECT CONSOLE;
typedef std::wstring wstring;
typedef std::vector<string> vector;
typedef std::vector<n> vectorN;
typedef CONSOLE_SCREEN_BUFFER_INFO SCRvar;

// Enum
enum Allign {left, center, right};
enum Error {loadFilesEr, choiceEr, localeSetEr};

// Global variables
n i;
used gotoF;
FILE *input;
FILE *choice;
used english;
FILE *correct;
string locale;
ll cashAmount;
vectorN earned;
used joker_5050;
n correctAnswers;
struct game_ENG eng;
struct game_HRV hrv;

// Predefined output functions
void introduction();
void consoleUpdate();
void textPlace(Allign, coord, string);

// Predefined gameplay functions
void quizTime();
void setValues();
void localeSet();
void loadFiles();
void correctAnsF();
void millionaire();
void gameOver(bool);
string correctAnswer();
vector answers(string);
void errorEncounter(Error);


// MAIN METHOD

int main()
{
	setValues();
	localeSet();
	introduction();
	loadFiles();

	quizTime();

	system("pause");
}

// DEFINITIONS OF OTHER METHODS

void textPlace(Allign x, coord y, string text)
{
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	COORD textSpot;
	CONSOLE rect;

	rect.Top = 0; rect.Left = 0; rect.Bottom = 30; rect.Right = 100;
	SCI;

	if (x == left)
		textSpot.X = rect.Left;
	elif (x == center)
		textSpot.X = (rect.Right / 2) - (text.size() / 2);
	else
		textSpot.X = rect.Right - text.size();

	textSpot.Y = y;

	SetConsoleCursorPosition(hConsole, textSpot);
	return;
}

void quizTime()
{
	for (i = 0; i < 15; ++i)
	{
		n pos = 0;
		n modif = 4;

		CLR;
		consoleUpdate();
		string answer = correctAnswer();

		char alloc[255];
		fgets(alloc, 255, (FILE*)input);
		string question(alloc);

		// Remove \n
		question.erase(question.end() - 1, question.end());

		textPlace(center, pos, question);
		printf(question.c_str());
		newLine;

		++++++pos; // pos +3

		fgets(alloc, 255, (FILE*)choice);
		string line(alloc);

		// Remove \n
		line.erase(line.end() - 1, line.end());

		vector posAnswers = answers(line);
		vector letters = { "a", "b", "c", "d" };

		n indexed;
		for (n xx = 0; xx < modif; ++xx)
			if (posAnswers[xx] == answer)
				indexed = xx;

	modifx:
		n remBef = 0;
		if (gotoF)
		{
			CLR;
			pos = 0;
			textPlace(center, pos, question);
			printf(question.c_str());
			newLine;

			++++pos; // pos +2

			n removed = 0;
			n x = 0;
			while(true)
			{
				if (removed != 2 && indexed != x)
				{
					posAnswers.erase(posAnswers.begin() + x);
					letters.erase(letters.begin() + x);

					if (x < indexed)
					{
						--indexed;
						++remBef;
					}
						

					++removed;
				}
				elif (removed == 2)
					break;

				++x;
			}
			joker_5050 = true; // Joker has been used
			modif = posAnswers.size();
			gotoF = false;
		}

		for (n x = 0; x < modif; ++x)
		{
			string print = letters[x] + ") " + posAnswers[x];

			if (letters[x] == "a" || letters[x] == "c")
			{
				textPlace(left, pos, print);
				printf(print.c_str());
			}
			else
			{
				textPlace(right, pos, print);
				printf(print.c_str());

				newLine;
				++pos;
			}
		}

		++pos;

		if (english)
		{
			if (!joker_5050)
			{
				textPlace(center, pos, eng.joker);
				printf(eng.joker.c_str());
				++pos;
			}

			textPlace(center, pos, eng.giveup);
			printf(eng.giveup.c_str());
			++++pos;

			textPlace(center, pos, eng.choice + "    ");
			printf(eng.choice.c_str());
		}
		else
		{
			if (!joker_5050)
			{
				textPlace(center, pos, hrv.joker);
				printf(hrv.joker.c_str());
				++pos;
			}

			textPlace(center, pos, hrv.giveup);
			printf(hrv.giveup.c_str());
			++++pos;


			textPlace(center, pos, hrv.choice + "    ");
			printf(hrv.choice.c_str());
		}

		// Looking for console input
		string input;
		getline(std::cin, input);

		// Removing all spaces that user may have "accidentally" put
		input.erase(std::remove_if(input.begin(), input.end(), ::isspace), input.end());

		if (input.size() == 1) // One lettered answer
		{
			// Getting index of the correct answer
			n index;
			for (n y = 0; y < modif; ++y)
				if (answer == posAnswers[y])
					index = y;

			// User letters; A B C D
			if (int(input[0]) >= 65 && int(input[0]) <= 68)
			{
				// Correct answer
				if (int(input[0]) - 65 - remBef == index)
				{
					correctAnsF();
				}
				// Incorrect Answer
				{
					gameOver(no);
				}
			}
			// User letters; a b c d
			elif (int(input[0]) >= 97 && int(input[0]) <= 100)
			{
				// Correct answer
				if (int(input[0]) - 97 - remBef == index)
				{
					correctAnsF();
				}
				// Incorrect Answer
				else
				{
					gameOver(no);
				}
			}
			// Improper answer (unsupported one-letter choice)
			else
			{
				errorEncounter(choiceEr);
			}
		}
		else // Word answer
		{
			// JOKER CHECK
			if (input == "JOKER" || input == "joker" && !joker_5050)
			{
				gotoF = true;
				goto modifx;
			}
			// ABORT CHECK
			else if (input == "ABORT" || input == "abort")
			{
				gameOver(yes);
			}

			// Correct Answer
			if (input == answer)
			{
				correctAnsF();
			}
			// Incorrect answer (caps, dots, etc.)
			else
			{
				gameOver(no);
			}
		}
	}
}

vector answers(string lineofText)
{
	n charPos = 0;
	vector returnVal(4);
	
	for (n ans_count = 0; ans_count < 4; ++ans_count)
	{
		for (; charPos < lineofText.size(); ++charPos)
		{
			if (lineofText[charPos] != ',')
			{
				returnVal[ans_count] += lineofText[charPos];
			}
			else
			{
				++ans_count;
				++charPos;
			}
		}
	}

	return returnVal;
}

string correctAnswer()
{
	char alloc[255];
	fgets(alloc, 255, (FILE*)correct);
	string correctAns(alloc);

	// Remove \n
	correctAns.erase(correctAns.end() - 1, correctAns.end());

	return correctAns;
}

void introduction()
{
	CLR;

	if (english)
	{
		SetConsoleTitle(eng.cTitle.c_str());
		textPlace(center, 0, eng.welcome);
		printf(eng.welcome.c_str());
		wait;
	}
	else
	{
		SetConsoleTitle(hrv.cTitle.c_str());
		textPlace(center, 0, hrv.welcome);
		printf(hrv.welcome.c_str());
		wait;
	}

	// Removing \n from input so first getline can work
	std::cin.ignore();
}

void consoleUpdate()
{
	wstring cTitle;

	if (english)
		cTitle = L"Millionaire from EMŠA - Question " + std::to_wstring(i + 1) + L"/15";
	else
		cTitle = L"Milijunaš iz EMŠE - Pitanje " + std::to_wstring(i + 1) + L"/15";

	SetConsoleTitle(cTitle.c_str());
}

void loadFiles()
{
	if (english)
	{
		input = fopen("data/questionsENG", "r");
		choice = fopen("data/choicesENG", "r");
		correct = fopen("data/correctENG", "r");
	}	
	else
	{
		input = fopen("data/questionsHRV", "r");
		choice = fopen("data/choicesHRV", "r");
		correct = fopen("data/correctHRV", "r");
	}
		
	if (input == NULL || choice == NULL || correct == NULL)
		errorEncounter(loadFilesEr);
}

void errorEncounter(Error x)
{
	switch (x)
	{
		case loadFilesEr:
			CLR;

			if (english)
			{
				textPlace(center, 0, eng.loadError);
				printf(eng.loadError.c_str());

				textPlace(center, 2, eng.key);
				printf(eng.key.c_str());

				exit(1);
			}
			else
			{
				textPlace(center, 0, hrv.loadError);
				printf(hrv.loadError.c_str());

				textPlace(center, 2, hrv.key);
				printf(hrv.key.c_str());

				exit(1);
			}

			break;

		case choiceEr:
			CLR;

			if (english)
			{
				textPlace(center, 0, eng.choiceError);
				printf(eng.choiceError.c_str());

				textPlace(center, 2, eng.key);
				printf(eng.key.c_str());

				exit(1);
			}
			else
			{
				textPlace(center, 0, hrv.choiceError);
				printf(hrv.choiceError.c_str());

				textPlace(center, 2, hrv.key);
				printf(hrv.key.c_str());

				exit(1);
			}

			break;
	
		case localeSetEr:
			CLR;

			textPlace(center, 0, eng.error);
			printf(eng.error.c_str());

			textPlace(center, 1, eng.key);
			printf(eng.key.c_str());

			waitForKey;

			exit(1);
			break;
	}
}

void setValues()
{
	english = true; // default_lang = english
	joker_5050 = false; // Joker available
	gotoF = false; // Joker available

	cashAmount = 0;
	correctAnswers = 0;
	
	earned = { 100, 200, 300, 500, 1000, 2000, 4000, 8000,
			   16000, 32000, 64000, 125000, 250000, 500000, 1000000};
}

void localeSet()
{
	setlocale(LC_ALL, "");
	CLR;
	SetConsoleTitle(L"Loading...");
	
	string hrv_ch = "Želite li da igra bude na hrvatskom (1) ili engleskom (2): \n";
	textPlace(center, 0, hrv_ch);

	printf(hrv_ch.c_str());

	string eng_ch = "Do you want to play the game on Croatian (1) or on English (2): \n";
	textPlace(center, 1, eng_ch);

	printf(eng_ch.c_str());

	n choice;
	textPlace(center, 2, "");
	scanf("%d", &choice);

	if (choice == 1)
		english = false;
	elif (choice == 2)
		english = true;
	else
		errorEncounter(localeSetEr);
}

void gameOver(bool forced)
{
	string printed;
	CLR;

	// If he gave up (USER FORCED ENDING GAME)
	if (forced)
	{
		if (english)
			printed = eng.totaled + std::to_string(cashAmount) + " HRK.\n";
		else
			printed = hrv.totaled + std::to_string(cashAmount) + " HRK.\n";

		textPlace(center, 0, printed);
		printf(printed.c_str());
		
		waitForKey;
		exit(1);
	}
	// If he f*cked up a question (USER DIDN'T FORCE ENDING GAME)
	else
	{
		// If no milestone occured, total is 0
		if (i < 5)
			cashAmount = 0;
		else
			while (i % 5 != 0)
				--i;

		// Reset to latest milestone
		if (cashAmount != 0)
			cashAmount = earned[i - 1];

		if (english)
			printed = eng.totaled + std::to_string(cashAmount) + " HRK.\n";
		else
			printed = hrv.totaled + std::to_string(cashAmount) + " HRK.\n";

		textPlace(center, 0, printed);
		printf(printed.c_str());

		waitForKey;
		exit(1);
	}
}

void correctAnsF()
{
	CLR;

	if (english)
	{
		if (i != 15)
		{
			for (n kkk = 0; kkk < 30; ++kkk)
			{
				textPlace(center, kkk, eng.correctAns);
				printf(eng.correctAns.c_str());
			}
		}
		else
		{
			millionaire();
		}
		
	}
	else
	{
		if (i != 15)
		{
			for (n kkk = 0; kkk < 30; ++kkk)
			{
				textPlace(center, kkk, hrv.correctAns);
				printf(hrv.correctAns.c_str());
			}
		}
		else
		{
			millionaire();
		}
	}

	wait;

	CLR;
	
	if (english)
	{
		string printed = eng.earned + std::to_string(earned[i]) + " HRK.\n";
		textPlace(center, 5, printed);
		printf(printed.c_str());
	}
	else
	{
		string printed = hrv.earned + std::to_string(earned[i]) + " HRK.\n";
		textPlace(center, 5, printed);
		printf(printed.c_str());
	}

	cashAmount = earned[i];

	wait;
}

void millionaire()
{
	CLR;

	if (english)
	{
		for (n mmm = 0; mmm < 30; ++mmm)
		{
			textPlace(center, mmm, eng.millionaire);
			printf(eng.millionaire.c_str());
		}
	}
	else
	{
		for (n mmm = 0; mmm < 30; ++mmm)
		{
			textPlace(center, mmm, hrv.millionaire);
			printf(hrv.millionaire.c_str());
		}
	}

	waitForKey;
	exit(1);
}