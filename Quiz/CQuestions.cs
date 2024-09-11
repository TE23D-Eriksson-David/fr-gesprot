using System.Diagnostics;
using System.Security.Cryptography;
using Quiz;
using SC = System.Console;

namespace MQuiz{

public class CQuestions
{
bool AddQuestions;
public int ADQusetions = 0;
string question = "0";
string Answer = "0";
string Question1 = "Question slot 1 (max char length 60)";
string Question2 = "Question slot 2 (max char length 60)";
string Question1Head = "Question catagory";
string Question2Head = "Question catagory";
string Question1Answer = "Question Answer";
string Question2Answer = "Question Answer";
string WADQuestion = "0";
public void ReadAnswer() {
Answer = SC.ReadLine();
}
public void AddQuestion() {
    while (AddQuestions == true) {
SC.Clear();
SC.WriteLine(@$"Write the number for your chossen action.

    ##########################################################
    #--------------------------------------------------------#
    #   1. {Question1Head} : {Question1} : {Question1Answer}                                          
    #--------------------------------------------------------#
    #   2. {Question2Head} : {Question2} : {Question2Answer}                                          
    #------------------------------------------------------- #
    ##########################################################
    Chose question slot or press Esc to go back to the Menue.

");
WADQuestion = SC.ReadLine();

if (ADQusetions == 2) {
    ADQusetions --;
}
//if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))  {AddQuestions = false;}

switch ((string)(WADQuestion)) {
    case (string)"1": {
        SC.Clear();
        SC.WriteLine(Question1);
        Question1 = SC.ReadLine();
        Question1Answer = SC.ReadLine();
        Question1Head = SC.ReadLine();
        ADQusetions ++;
    break;    }

    case (string)"2": {
        SC.Clear();
        SC.WriteLine(Question2);
        Question2 = SC.ReadLine();
        Question2Answer = SC.ReadLine();
        Question2Head = SC.ReadLine();
        ADQusetions ++;
    break;    }
}
    }
}

public void PromptAnswer() {
SC.WriteLine("Answer");

SC.WriteLine("PromptAnswer");

    switch ((string)(Answer)) {
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


public void ChosingQuestion() {   
//SC.WriteLine("ChosingQuestion");
SC.WriteLine("Write the number for your chossen Catagory or press Esc to go back to the Menue.");
SC.WriteLine(@$"
    ##############################################
    #--------------------------------------------#
    #  (1) Film      |  50   |   100   |  150  | #
    #--------------------------------------------#
    #  (2) Geogrefy  |  50   |   100   |  150  | #
    #--------------------------------------------#
    #  (3) Music     |  50   |   100   |  150  | #
    #--------------------------------------------#
    ##############################################
    ");
    if (ADQusetions > 0) {SC.WriteLine(@$"
    ##########################################################
    #--------------------------------------------------------#
    #  (4) {Question1}                                          
    #--------------------------------------------------------#
    #  (5) {Question2}                                          
    #------------------------------------------------------- #
    ####################################W#####################
    
    ");} 

question = Console.ReadLine();

 }



public void PromptQuestion () {
SC.WriteLine("question");

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
