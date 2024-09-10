using SC = System.Console;
using System.IO;



string fråga = "";

while (true) {
making();
qustion();

anser();
fråga_anser();

}


void making () {

SC.WriteLine(making);
string fråga = SC.ReadLine();
fråga = Console.ReadLine();

}

void qustion () {
SC.WriteLine(qustion);
switch ((string)(fråga)) {
    case (string)"1": {
        SC.WriteLine("Vilken känd regissör gjorde filmen 'The Shining'?");
    break;    }

    case (string)"2": {
        SC.WriteLine(@"Från vilken film är följande citat hämtat?

        I feel the need...the need for speed!");
    break;    }

    case (string)"3": {
        SC.WriteLine("Vad heter den fiktiva staden där TV-serien 'The Simpsons' utspelar sig?");
    break;    }
    
    case (string)"4": {
        SC.WriteLine("Vilken är den största sjön i Afrika?");
    break;    }

    case (string)"5": {
        SC.WriteLine("Vilket land är världens minsta till ytan?");
    break;    }

    case (string)"6": {
        SC.WriteLine("Vad heter huvudstaden i Australien?");
    break;    }

    case (string)"7": {
        SC.WriteLine(@"Måndagen den 8 december 1980 i New York sköts en man till döds av den förvirrade beundraren Mark Chapman. 

        Vem var det som mördades?");
    break;    }

    case (string)"8": {
        SC.WriteLine(@"Från vilket land kommer rockgruppen U2?");
    break;    }

    case (string)"9": {
        SC.WriteLine("Vilket år dog Elvis Presley?");
    break;    }

}



} 

void anser () {
SC.WriteLine(anser);
//string svar = SC.ReadLine();

}

void fråga_anser () {
    SC.WriteLine(fråga_anser);
    switch ((string)(fråga)) {
    case (string)"1": {
        SC.WriteLine("Stanley Kubrick");
    break;    }

    case (string)"2": {
        SC.WriteLine("Top Gun");
    break;    }

    case (string)"3": {
        SC.WriteLine("Springfield");
    break;    }
    
    case (string)"4": {
        SC.WriteLine("Victoriasjön");
    break;    }
    case (string)"5": {
        SC.WriteLine("Vatikanstaten");
    break;    }
    case (string)"6": {
        SC.WriteLine("Canberra");
    break;    }
    case (string)"7": {
        SC.WriteLine("John Lennon");
    break;    }
    case (string)"8": {
        SC.WriteLine("Irland");
    break;    }
    case (string)"9": {
        SC.WriteLine("1977");
    break;    }
    
}
}