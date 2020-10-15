#include <iostream>
#include <cmath>

using namespace std;

int main(int argc, char** argv)
{
    float a, c;
    char b;

    cout << "Unesite prvi zeljeni broj: " << endl;
    cin >> a;

    cout << "Unesite matematicki znak +, -, * ili / : " << endl;
    cin >> b;

    cout << "Unesite drugi zeljeni broj: " << endl;
    cin >> c;

    switch (b)
    {
        case '+':
        {
            cout << a+c;
        }
        break;
        case '-':
        {
            cout << a-c;
        }
        break;
        case '/':
        {
            cout << a/c;
        }
        break;
        case '*':
        {
            cout << a*c;
        }
        break;
    }
    return 0;
}
