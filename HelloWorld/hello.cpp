#include <iostream>
#include "FinnbjornsKlasi.h"
#include "jonhallur.h"
#include "hjalti.h"
using namespace std;

int main()
{
    jonhallur jonh;
    hjalti hs;
    cout<< "Hello world\nHello guys\n";

    cout << jonh << endl;

    // from: Finnbjorn
    FinnbjornsKlasi fk;
    string finnbjornSegir = fk.getName();
    cout << finnbjornSegir << endl;
    // finished from Finnbjorn

    // from: Hjalti
    cout << hs << endl;
    // Finished from Hjalti
    return 0;
}
