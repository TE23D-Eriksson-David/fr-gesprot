using SC = System.Console;

namespace Quiz{

public class CGame
{
int CorectAnswers = 0;
int Points = 0;
public bool GameRun = false;
public string MenueChoice = "";
string PlayerName = "player";



public void ChoceName() {
SC.Clear();
SC.WriteLine(@"Write the name that you want to have:
"); 
PlayerName = SC.ReadLine();
}
public void EndGame() {
    GameRun = false;
}
public void ShowMenue () {
    SC.WriteLine(@$"
    #################################
    #                               #
    #   1. Chose player name:       #   Name: {PlayerName} 
    #                               #
    #   2. Add Question:            #   Added questions
    #                               #
    #   3. Start Game:              #
    #                               #
    #################################

   ");  /* ({MyQuestions.ADQusetions}) */
} 

public void StartGame() {
    SC.WriteLine("start game");
    CorectAnswers = 0;
    Points = 0;
    GameRun = true;
}

public void ShowResult() {
    
    SC.WriteLine($@" {CorectAnswers} , {Points}"); //Points & CorectAnsers
    
    //SC.WriteLine ($"{Points},{CorrectAnswer}");
}
    
} // Class END

} // Namespace END
