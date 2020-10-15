#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

float a,volumen,x;
void volumen1()
{
    volumen=pow(a,3);
    cout<<"Volumen je: "<<volumen<<" cm3."<<endl;
}

int volumen2()
{
    return pow(a,3);
}

void volumen3(int a)
{
    cout<<"Volumen je: "<<pow(a,3)<<" cm3."<<endl;
}

int volumen4(int a)
{
    return pow(a,3);
}

int ukupnamasa;
float udio(float masa)
{
    return (masa/ukupnamasa)*100;
}

float jedna, dvije, zid=2.85;
void boja()
{
    float ukupno;
    ukupno=(jedna*zid)+(dvije*zid)+(jedna*dvije);
    cout<<"Da bi ofarbao sobu potrebno ti je ukupno: "<<ukupno/10<<" litara boje"<<endl;
}

string valuta;
void funta(int kuna, string valuta)
{
    cout<<setprecision(3)<<fixed<<kuna<<" kuna ti je "<<kuna*0.11<<" funti."<<endl;
}
void euro(int kuna, string valuta)
{
    cout<<setprecision(3)<<fixed<<kuna<<" kuna ti je "<<kuna*0.13<<" eura."<<endl;
}
void dolar(int kuna, string valuta)
{
    cout<<setprecision(3)<<fixed<<kuna<<" kuna ti je "<<kuna*0.15<<" dolara."<<endl;
}
void kruna(int kuna, string valuta)
{

    cout<<setprecision(3)<<fixed<<kuna<<" kuna ti je "<<kuna*3.42<<" kruna."<<endl;
}

int broj()
{
    float n;
    cout<<"Unesite broj: "<<endl;
    cin>>n;
    if(n<0)
    {
        n=abs(n);
    }
    n=abs(n);
    if(n>=0 && n<=9)
    {
        return n;
    }
    else if(n>=10 && n<=99)
    {
        return n/10;
    }
    else if(n>=100 && n<=999)
    {
        return n/100;
    }
    else if(n>=1000 && n<=9999)
    {
        return n/1000;
    }
    else if(n>=10000 && n<=99999)
    {
        return n/10000;
    }

}
int main()
{
    cout<<"1. Zadatak: "<<endl;
    cout<<"------------------------------------------"<<endl;

    cout<<"Duljina, visina i sirina iznosi: ";
    cin>>a;
    cout<<endl;

    volumen1();
    cout<<volumen2()<<endl;
    volumen3(a);
    cout<<volumen4(a)<<endl;
    cout<<endl;

    cout<<"2. zadatak: "<<endl;
    cout<<"------------------------------------------"<<endl;

    int sastojci;

    cout<<"Unesi broj sastojaka: ";
    cin>>sastojci;

    float masa[sastojci];

    for(int i=0; i<sastojci; i++)
    {
        cout<<"Unesi masu "<<i+1<<". sastojka u g: ";
        cin>>masa[i];
        ukupnamasa=ukupnamasa+masa[i];
    }
    cout<<endl;
    cout<<"Ukupna masa iznosi: "<<ukupnamasa<<" g."<<endl;
    cout<<endl;

    for(int i=0; i<sastojci; i++)
    {
        cout<<setprecision(2)<<fixed<<"Udio "<<i+1<<". sastojka iznosi: "<<udio(masa[i])<<"%"<<endl;
    }

    cout<<endl;
    cout<<"3. zadatak: "<<endl;
    cout<<"------------------------------------------"<<endl;

    float p1, p2, psoba, ukupno;

    cout<<"Unesi duljine manjih zidova u m: ";
    cin>>jedna;

    cout<<"Unesi duljine vecih zidova u m: ";
    cin>>dvije;
    cout<<endl;

    boja();

    cout<<endl;
    cout<<"4. zadatak: "<<endl;
    cout<<"------------------------------------------"<<endl;

    int kuna;

    cout<<"Unesi koliko novaca zelis promijeniti u kunama: "<<endl;
    cin>>kuna;

    cout<<endl;

    cout<<"U koju valutu ih zelis promijeniti (funta, dolar, euro ili kruna): ";
    cin>>valuta;

    if(valuta=="funta")
    {
        funta(kuna,valuta);
    }
    else if(valuta=="euro")
    {
        euro(kuna,valuta);
    }
    else if(valuta=="dolar")
    {
        dolar(kuna,valuta);
    }
    else if (valuta=="kruna")
    {
         kruna(kuna,valuta);
    }

    cout<<endl;
    cout<<"5. Zadatak: "<<endl;
    cout<<"------------------------------------------"<<endl;

    cout<<"Prva znamenka vaseg broja je: "<<broj()<<endl;

return 0;
}
