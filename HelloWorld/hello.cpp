#include <iostream>
#include "FinnbjornsKlasi.h"
#include "jonhallur.h"
#include "hjalti.h"
#include "hilmar.h"
#include "fannar.h"
#include "SiggaClassi.h"
using namespace std;

int main()
{
    jonhallur jonh;
    hjalti hs;
    cout<< "Hello world\nHello guys\n";

    cout << jonh << endl;

// from: Fannar
	fannar fann;
	cout << fann << endl;
// finished Fannar


    // from: Finnbjorn
    FinnbjornsKlasi fk;
    string finnbjornSegir = fk.getName();
    cout << finnbjornSegir << endl;
    // finished from Finnbjorn


    // from: Hjalti
    cout << hs << endl;
    // Finished from Hjalti

	//from: Hilmar
	hilmar hilmar;
	cout << "Hello snapahead" << endl;
	cout << hilmar << endl;
	//Hilmar out

	//Siggi in
	string name = SiggaClassi.getName();
	cout << name;
	//Siggi out

    return 0;
}
