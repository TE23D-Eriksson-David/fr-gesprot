using SC = System.Console;

namespace Quiz{

public class CGame
{
int CorectAnswers = 0;
int Points = 0;
public bool GameRun = false;
public bool AllAnswerd = false;
public string MenueChoice = "";



public void ChoceName() {

}
public void EndGame() {
    GameRun = false;
}
public void ShowMenue () {
    SC.WriteLine(@$"
    #################################
    #                               #
    #   1. Chose player name:       #
    #                               #
    #   2. Add Question:            #
    #                               #
    #   3. Start Game:              #
    #                               #
    #################################
    "); 
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
