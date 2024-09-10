using SC = System.Console;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Quiz;
using MQuiz;


CGame MyGame = new CGame();
CQuestions MyQuestions = new CQuestions();




while (true) {
MyGame.ShowMenue(); // Meny där du kan välja saker
MyQuestions.AddQuestion(); // Välja att läga till fråga / Editerara existerande frågor
MyGame.StartGame(); // Starta spelet

MyQuestions.ChosingQuestion(); // Välja vilken fråga man vill besvara 
MyQuestions.PromptQuestion(); // skriva utt frågan på skärmen
MyQuestions.ReadAnswer(); // Läsa in svaret 
MyQuestions.PromptAnswer(); // Skriva svaret och ge poäng

MyGame.ShowResult(); // visas i sluttet med antal rätt och poäng
MyGame.EndGame(); // sätter allt till orginal och återgår till Menyn




}








