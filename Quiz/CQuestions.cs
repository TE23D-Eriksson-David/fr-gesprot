using System.Diagnostics;
using System.Security.Cryptography;
using Quiz;
using SC = System.Console;

namespace MQuiz{

public class CQuestions
{
public bool AllAnswerd = false;
bool AddQuestions = true;
public int ADQusetions = 0;
public int AnsQuestions = 0;
public int  intefall= 0;
public int QuestionPoints= 0;
public int CorectQuestions =0;
string question = "0";
string Answer = "0";
string Question1 = "Question slot 1 ";
string Question2 = "Question slot 2 ";
string Question1Head = "Question catagory";
string Question2Head = "Question catagory";
string Question1Answer = "Question Answer";
string Question2Answer = "Question Answer";
string WADQuestion = "0";

public void AddQuestion() {
    while (AddQuestions == true) {
SC.Clear();
SC.WriteLine(@$"Write the number for your chossen action.

    ###############################################################################################
    #---------------------------------------------------------------------------------------------#
    #   1. {Question1Head} : {Question1} : {Question1Answer}                                          
    #---------------------------------------------------------------------------------------------#
    #   2. {Question2Head} : {Question2} : {Question2Answer}                                          
    #---------------------------------------------------------------------------------------------#
    ###############################################################################################
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
        SC.WriteLine(@"Write your question:
        ");
        Question1 = SC.ReadLine();
        SC.WriteLine("Write question answer");
        Question1Answer = SC.ReadLine();
        SC.WriteLine("Write question head");
        Question1Head = SC.ReadLine();
        SC.WriteLine("done");
        ADQusetions ++;
    break;    }

    case (string)"2": {
        SC.Clear();
        SC.WriteLine(Question2);
        SC.WriteLine(@"Write your question:
        ");
        Question2 = SC.ReadLine();
        SC.WriteLine("Write question answer");
        Question2Answer = SC.ReadLine();
        SC.WriteLine("Write question head");
        Question2Head = SC.ReadLine();
        SC.WriteLine("done");
        ADQusetions ++;
    break;    }
}
    }
}

public void ReadAnswer() {
Answer = SC.ReadLine();
}
public void PromptAnswer() {
SC.WriteLine("Answer");
AnsQuestions ++;
SC.WriteLine("PromptAnswer");

    switch ((string)(Answer)) {
    case (string)"Stanley Kubrick": {
        SC.WriteLine("Correct answer, you recive 50 points");
        QuestionPoints =+ 50;
        CorectQuestions++;
    break;    }

    case (string)"Top Gun": {
        SC.WriteLine("Correct answer, you recive 100 points");
        QuestionPoints =+ 100;
        CorectQuestions++;
    break;    }

    case (string)"Springfield": {
        SC.WriteLine("Correct answer, you recive 150 points");
        QuestionPoints =+ 150;
        CorectQuestions++;
    break;    }
    
    case (string)"Victoriasjön": {
        SC.WriteLine("Correct answer, you recive 50 points");
        QuestionPoints =+ 50;
        CorectQuestions++;
    break;    }
    case (string)"Vatikanstaten": {
        SC.WriteLine("Correct answer, you recive 100 points");
        QuestionPoints =+ 100;
        CorectQuestions++;
    break;    }
    case (string)"Canberra": {
        SC.WriteLine("Correct answer, you recive 150 points");
        QuestionPoints =+ 150;
        CorectQuestions++;
    break;    }
    case (string)"John Lennon": {
        SC.WriteLine("Correct answer, you recive 50 points");
        QuestionPoints =+ 50;
        CorectQuestions++;
    break;    }
    case (string)"Irland": {
        SC.WriteLine("Correct answer, you recive 100 points");
        QuestionPoints =+ 100;
        CorectQuestions++;
    break;    }
    case (string)"1977": {
        SC.WriteLine("Correct answer, you recive 150 points");
        QuestionPoints =+ 150;
        CorectQuestions++;
    break;    }
}
if (Question1Answer == Answer) {
    SC.WriteLine(Question1Answer);
        SC.WriteLine("Correct answer, you recive what ever you want for answering YOUR own question");
        intefall ++;
        CorectQuestions++;
}
if (Question2Answer == Answer) {
    SC.WriteLine(Question2Answer);
        SC.WriteLine("Correct answer, you recive what ever you want for answering YOUR own question");
         intefall ++;
         CorectQuestions++;
}
if ( intefall == 0) {
SC.WriteLine("Wrong Answer, No points for you!"); 
}
SC.ReadLine();  
 intefall = 0;
 Answer = "";
}


public void ChosingQuestion() {   
//SC.WriteLine("ChosingQuestion");
SC.WriteLine("Write the number for your chossen Catagory or press Esc to go back to the Menue.");
SC.WriteLine(@$"
    ####################################################
    #--------------------------------------------------#
    #   Film      | (1) 50  | (2)  100   | (3) 150  |  #
    #--------------------------------------------------#
    #   Geogrefy  | (4) 50  | (5)  100   | (6) 150  |  #
    #--------------------------------------------------#
    #   Music     | (7) 50  | (8)  100   | (9) 150  |  #
    #--------------------------------------------------#
    ####################################################
    ");
    if (ADQusetions > 0) {SC.WriteLine(@$"
    ##########################################################
    #--------------------------------------------------------#
    #  (11) {Question1Head}    
    #--------------------------------------------------------#                                      
    ##########################################################");} 
    if (ADQusetions > 0) {SC.WriteLine(@$"
    ##########################################################
    #--------------------------------------------------------#
    #  (12) {Question2Head}                                          
    #------------------------------------------------------- #
    ##########################################################");} 
question = Console.ReadLine();
 }



public void PromptQuestion () {
SC.WriteLine("question");

switch ((string)(question)) {
    
    case (string)"1": {
        SC.Clear();
        SC.WriteLine("Vilken känd regissör gjorde filmen 'The Shining'?");
    break;    }

    case (string)"2": {
         SC.Clear();
        SC.WriteLine(@"Från vilken film är följande citat hämtat?

        I feel the need...the need for speed!");
    break;    }

    case (string)"3": {
        SC.Clear();
        SC.WriteLine("Vad heter den fiktiva staden där TV-serien 'The Simpsons' utspelar sig?");
    break;    }
    
    case (string)"4": {
        SC.Clear();
        SC.WriteLine("Vilken är den största sjön i Afrika?");
    break;    }

    case (string)"5": {
        SC.Clear();
        SC.WriteLine("Vilket land är världens minsta till ytan?");
    break;    }

    case (string)"6": {
        SC.Clear();
        SC.WriteLine("Vad heter huvudstaden i Australien?");
    break;    }

    case (string)"7": {
         SC.Clear();
        SC.WriteLine(@"Måndagen den 8 december 1980 i New York sköts en man till döds av den förvirrade beundraren Mark Chapman. 

        Vem var det som mördades?");
    break;    }

    case (string)"8": {
        SC.Clear();
        SC.WriteLine(@"Från vilket land kommer rockgruppen U2?");
    break;    }

    case (string)"9": {
        SC.Clear();
        SC.WriteLine("Vilket år dog Elvis Presley?");
    break;    }

    case (string)"11": {
        SC.Clear();
        SC.WriteLine(Question1);
    break;    }

    case (string)"12": {
        SC.Clear();
        SC.WriteLine(Question2);
    break;    }

} //Switch End


} // Promt Question

public void Check() {
   if (ADQusetions == 2) {
    if (AnsQuestions == 11) {
        AllAnswerd = true;}
   } else { if (AnsQuestions == 9) {
        AllAnswerd = true;
    }
   }
}


}// Class End 

} // Namespace END
