#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
    int vreme;
    cout << "Unesite vreme u sekundama za koje je ucenik istrcao 30m:  ";
    cin >> vreme;

    if (vreme>5.2)
    {
        cout << "nedovoljan" << endl;
    }
    else if (vreme==5.2)
    {
        cout << "dovoljan" << endl;
    }
    else if (vreme<=5.1 && vreme>=4.9)
    {
        cout << "dobar" << endl;
    }
    else if (vreme<=4.8 && vreme>=4.7)
    {
        cout << "vrlo dobar" << endl;
    }
    else 
    {
        cout << "odlican" << endl;
    }

    return 0;
}
