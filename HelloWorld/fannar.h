#include <iostream>
using namespace std;
class fannar
{
public:
	fannar();
	friend ostream& operator <<(ostream& outs, const fannar& fnr);

};
fannar::fannar(){}

ostream& operator <<(ostream& straumur, const fannar& fnr)
{
   straumur << "Fannar";
}

