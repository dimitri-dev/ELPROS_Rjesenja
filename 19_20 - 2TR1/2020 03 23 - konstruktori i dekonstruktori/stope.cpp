#include "stope.h"

stope::stope()
{
	this->h = 100;
}

stope::stope(float h)
{
	this->h = h;
}

stope::~stope()
{

}

float stope::pretvorba()
{
	return (h / 100 * 3.28084);
}
