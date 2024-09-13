using SC = System.Console;

namespace Quiz{

public class CGame
{
public int CorectAnswers = 0;
public int Points = 0;
public bool GameRun = false;
public string MenueChoice = "";
string PlayerName = "player";
public int ADQGusetions = 0;


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
    #   2. Add Question:            #   {ADQGusetions} Added questions
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
    
    SC.WriteLine($@" You got {CorectAnswers} Answers Corect, and a score of {Points} 
    Well done!"); 
    SC.ReadLine(); 
    
}
    
} // Class END

} // Namespace END
