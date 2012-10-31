#include <iostream>
using namespace std;
class hjalti
{
public:
	hjalti();
	friend ostream& operator <<(ostream& outs, const hjalti& hs);

};
hjalti::hjalti()
{
}

ostream& operator <<(ostream& straumur, const hjalti& hs)
{
   straumur << "hjalti";
}


