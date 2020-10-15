#include <cmath>
#include "prizma.h"

prizma::prizma()
{
	this->a = 3;
	this->h = 8;
}

prizma::prizma(float a, float h)
{
	this->a = a;
	this->h = h;
}

prizma::~prizma()
{

}

/*
Formule za računanje uzete su iz knjige sa Loomena:
https://i.gyazo.com/8652bbb97efe6f4a3f0b9919297fae55.png
*/

float prizma::oplosje()
{
	return (3 * pow(a, 2) * sqrt(3) * h / 2);
}

float prizma::volumen()
{
	return (3 * pow(a, 2) * sqrt(3) + 6 * a * h);
}