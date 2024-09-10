using System.Diagnostics;
using SC = System.Console;

namespace MQuiz{

public class CQuestions
{





public void ReadAnswer() {}
public void AddQuestion() {}

public void PromptAnswer() {
SC.WriteLine("Answer");
string Answer = SC.ReadLine();

SC.WriteLine("PromptAnswer");
int Points;
    switch ((string)(Answer)) {
    case (string)"1": {
        SC.WriteLine("Stanley Kubrick");
        Points =+ 50;
    break;    }

    case (string)"2": {
        SC.WriteLine("Top Gun");
        Points =+ 100;
    break;    }

    case (string)"3": {
        SC.WriteLine("Springfield");
        Points =+ 150;
    break;    }
    
    case (string)"4": {
        SC.WriteLine("Victoriasjön");
        Points =+ 50;
    break;    }
    case (string)"5": {
        SC.WriteLine("Vatikanstaten");
        Points =+ 100;
    break;    }
    case (string)"6": {
        SC.WriteLine("Canberra");
        Points =+ 150;
    break;    }
    case (string)"7": {
        SC.WriteLine("John Lennon");
        Points =+ 50;
    break;    }
    case (string)"8": {
        SC.WriteLine("Irland");
        Points =+ 100;
    break;    }
    case (string)"9": {
        SC.WriteLine("1977");
        Points =+ 150;
    break;    }
    
}
}


public void ChosingQuestion() {   

SC.WriteLine("ChosingQuestion");
string question = Console.ReadLine();

                                        }



public void PromptQuestion () {
SC.WriteLine("question");
string question = Console.ReadLine();
switch ((string)(question)) {
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

} //Switch End


} // Promt Question


}// Class End 

} // Namespace END
