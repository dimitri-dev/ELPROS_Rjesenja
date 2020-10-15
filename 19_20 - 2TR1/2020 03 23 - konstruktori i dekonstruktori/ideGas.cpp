#include "ideGas.h"

ideGas::ideGas()
{
	this->prijedeniPut = 671;
	this->velicinaSpremnika = 75;
}

ideGas::ideGas(float prijedeniPut, float velicinaSpremnika)
{
	this->prijedeniPut = prijedeniPut;
	this->velicinaSpremnika = velicinaSpremnika;
}

ideGas::~ideGas()
{

}

float ideGas::potrosnja()
{
	return (velicinaSpremnika * 100 / prijedeniPut);
}
