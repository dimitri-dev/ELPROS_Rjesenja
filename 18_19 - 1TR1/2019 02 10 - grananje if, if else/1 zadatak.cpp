#include <iostream>
#include <cmath>
#include <algorithm>

using namespace std;

int main()
{
    int iq;
    cout << "Unesite vas IQ rezultat:  ";
    cin >> iq;

    if (iq<70)
    {
        cout << "Vas IQ je iznimno nizak." << endl;
    }
    else if (iq>=70 && iq<=79)
    {
        cout << "Vas IQ je granican." << endl;
    }
    else if (iq>=80 && iq<=89)
    {
        cout << "Vas IQ je nisko prosecan." << endl;
    }
    else if (iq>=90 && iq<=109)
    {
        cout << "Vas IQ je prosecan." << endl;
    }
    else if (iq>=110 && iq<=119)
    {
        cout << "Vas IQ je visoko prosecan." << endl;
    }
    else if (iq>=120 && iq<=129)
    {
        cout << "Vas IQ je superioran." << endl;
    }
    else
    {
        cout << "Vas IQ je vrlo superioran." << endl;
    }
    return 0;
}
