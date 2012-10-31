#ifndef HILMAR_H
#DEFINE HILMAR_H

#include <iostream>
#include <string>
using namespace std;

const string name="Hilmar";

class hilmar
{
public:
	hilmar();
	
	friend ostream& operator << (ostream& Outs, const hilmar& hilmar);
};

hilmar::hilmar(){}

ostream& operator <<(ostream& straumur, const hilmar& hilmar)
{
	straumur << name;
};


