#include <iostream>
#include <ctime>
#include <algorithm>
#include <cmath>

using namespace std;

int main()
{
    srand(time(0));

	int pokerface[5][5] = {0}, gaga[5] = {0};
	/* "Poker Face" je pop pjesma amerièke pjevaèice Lady Gage. Objavljena je 23. rujna 2008. kao njen drugi singl s albuma The Fame.
	Pjesmu su napisali Lady Gaga i RedOne koji je i produncent iste. Glavna poruka pjesme je njena biseksualnost i posveæena je njezinim bivšim deèkima.
    Pjesma je bila veliki hit diljem svijeta, dospjevši na broj jedan u preko 17 država.
    Bila na broju jedan u SAD-u, Ujedinjenom Kraljevstvu, Australiji, Novom Zelandu, Kanadi i mnogim europskim državama. "Poker Face" je najskidanija pjesma u britanskoj povijesti glazbe.
    Gaga je izvela pjesmu za osmu sezonu amerièke emisije American Idol kao i na Fame Ball i Monster Ball turnejama. */


    for (int i = 0; i < 5; ++i)
        for (int j = 0; j < 5; ++j)
            {
                cout << "Unesite [" << i << "][" << j << "] element polja: ";
             re:cin >> pokerface[i][j];

                if (pokerface[i][j] > 5 || pokerface[i][j] < 1)
                {
                    cout << "Niste unijeli pravilan broj. Molimo unesite ponovno: ";
                    goto re;
                }

                gaga[i] += pokerface[i][j];
            }

    cout << endl;

    for (int x = 0; x < 5; ++x)
        cout << "Prosjek " << x + 1 << ". ucenika je " << round( float(gaga[x]) / 3) << endl;

    return 0;
}
