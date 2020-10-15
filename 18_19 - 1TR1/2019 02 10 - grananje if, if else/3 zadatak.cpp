#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
    int skok;
    cout << "Unesite duljinu skoka u dalj u cm:  ";
    cin >> skok;

    if (skok<180)
    {
        cout << "nedovoljan" << endl;
    }
    else if (skok<=194 && skok>=180)
    {
        cout << "dovoljan" << endl;
    }
    else if (skok<=209 && skok>=195)
    {
        cout << "dobar" << endl;
    }
    else if (skok<=224 && skok>=210)
    {
        cout << "vrlo dobar" << endl;
    }
    else
    {
        cout << "odlican" << endl;
    }

    return 0;
}
