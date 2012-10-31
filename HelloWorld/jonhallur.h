#include <iostream>
using namespace std;
class jonhallur
{
public:
	jonhallur();
	friend ostream& operator <<(ostream& outs, const jonhallur& jonh);

};
jonhallur::jonhallur(){}

ostream& operator <<(ostream& straumur, const jonhallur& jonh)
{
   straumur << "Jon Hallur";
}

