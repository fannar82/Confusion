#include <iostream>
#include "FinnbjornsKlasi.h"
#include "jonhallur.h"
#include "hilmar.h"
using namespace std;

int main()
{
    jonhallur jonh;
    cout<< "Hello world\nHello guys\n";

    cout << jonh << endl;

    // from: Finnbjorn
    FinnbjornsKlasi fk;
    string finnbjornSegir = fk.getName();
    cout << finnbjornSegir << endl;
    // finished from Finnbjorn

	//from: Hilmar
	hilmar hilmar;
	cout << "Hello snapahead";
	cout << hilmar << endl;
	//Hilmar out


    return 0;
}
