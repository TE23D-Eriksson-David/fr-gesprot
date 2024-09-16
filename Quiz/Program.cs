using SC = System.Console;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Quiz;
using MQuiz;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Threading;


CGame MyGame = new CGame();
CQuestions MyQuestions = new CQuestions();
//Raylib.SetExitKey(KeyboardKey.KEY_Q); // Gör så Q avslutar spelet



while /* MAIN */ (true) {
while (MyGame.GameRun == false){
MyGame.ADGQusetions = MyQuestions.ADQusetions;
MyQuestions.AddQuestions = true;
    SC.Clear();
SC.WriteLine("Write the number for your chossen action.");
MyGame.ShowMenue(); // Meny där du kan välja saker
MyGame.MenueChoice = SC.ReadLine();

switch ((string)(MyGame.MenueChoice)) {
    case (string) "1": {
        MyGame.ChoceName();
    break;    }
    case (string) "2": {
        MyQuestions.AddQuestion(); // Välja att läga till fråga / Editerara existerande frågor
    break;    }
    case (string) "3": {
        MyGame.StartGame(); // Starta spelet
    break;    }

}


} // while Menue

while (MyGame.GameRun == true) {
    SC.Clear();
MyQuestions.ChosingQuestion(); // Välja vilken fråga man vill besvara 
MyQuestions.AnsQuestions ++;
MyQuestions.PromptQuestion(); // skriva utt frågan på skärmen
MyQuestions.ReadAnswer(); // Läsa in svaret 
MyQuestions.PromptAnswer(); // Skriva rätta svaret och ge poäng
MyQuestions.Check();

if (MyQuestions.AllAnswerd ==  true) {
MyQuestions.CorectQuestions = MyGame.CorectAnswers;
MyQuestions.QuestionPoints = MyGame.Points;
MyGame.ShowResult(); // visas i sluttet med antal rätt och poäng
MyGame.EndGame(); // sätter allt till orginal och återgår till Menyn
}  
}




}








