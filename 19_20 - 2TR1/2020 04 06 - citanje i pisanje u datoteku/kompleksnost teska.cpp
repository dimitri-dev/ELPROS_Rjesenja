#include <iostream>
#include <fstream>
#include <cmath>
#include <ctime>
#include <cstdlib>
#include <vector>
#include <string>
#include <sstream>
#include <locale.h>

int required_n(std::string temp);

int main()
{
	setlocale(LC_ALL,"");
	printf("1. zadatak:\n");
	std::ofstream Kvadrati("kvadrati.xls");
	
	printf("Generiranje kvadrata...\n");
	for (int i = 1; i <= 10; ++i)
	{
		Kvadrati << pow(i, 2) << '\n'; 	
	}
	
	printf("Ispis je gotov.\n");
	Kvadrati.close();
	
	printf("\n2. zadatak: \n");
	std::ofstream Osobe("visina_masa.txt");
	std::string imena[5] = {"Jovan", "Duško", "Miško", "Rajka", "Danijela"};
	
	srand(time(NULL));
	
	printf("Generiranje osoba...\n");
	for (int i = 0; i < 5; ++i)
	{
		int temp_m = rand()% 61 + 40;
		int temp_h = rand()% 47 + 150;
		
		Osobe << imena[i] << '\n'<< "Masa: " << temp_m << " kg\n" << "Visina: " << temp_h << " cm.";
		if (i != 4) Osobe << "\n\n";
	}
	
	Osobe.close();
	std::ifstream data;
	data.open("visina_masa.txt");
	
	int sum_m = 0;
	int sum_h = 0;
	int indexor = 0;
	
	if (data.is_open())
	{
		std::vector<std::string> names; // spremnik za imena
		int i = -1; // starting position
		// 0 - Name
		// 1 - Mass
		// 2 - Height
		// 3 - Skip (Reset)
		
		while (!data.eof())
		{
			++i;
			std::string temp; // getline
			getline(data, temp);
			if (i == 0)
			{
				names.push_back(temp);
			}
			else if (i == 1)
			{
				sum_m += required_n(temp);	
			}
			else if (i == 2)
			{
				sum_h += required_n(temp);
				if (required_n(temp) > 180)
				{
					printf("\n%s je visok/visoka %d cm!", names[indexor].c_str(), required_n(temp));
				}
			}
			else
			{
				++indexor;
				i = -1;
			}
		}
	}
	
	printf("\n\nProsjecna masa iznosi %.1f kg.\n",sum_m / (float)(indexor + 1)); 
	printf("Prosjecna visina iznosi %.1f cm.\n", sum_h / (float)(indexor + 1));
	
	return 0;
}

int required_n(std::string temp)
{
	int n;
	std::string temp_ss;
	std::stringstream ss;
	ss << temp;
				
	while (!ss.eof())
	{
		ss >> temp_ss;
		if(std::stringstream(temp_ss) >> n)
			return n;
	}
}
