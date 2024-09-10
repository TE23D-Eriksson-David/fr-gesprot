using SC = System.Console;

namespace Quiz{

public class CGame
{
int CorectAnswers = 0;
int Points = 0;



public void EndGame() {}
public void ShowMenue () {}

public void StartGame() {
    SC.WriteLine("start game");
    CorectAnswers = 0;
    Points = 0;
}

public void ShowResult() {
    
    SC.WriteLine($@" {CorectAnswers} , {Points}"); //Points & CorectAnsers
    
    //SC.WriteLine ($"{Points},{CorrectAnswer}");
}
    
} // Class END

} // Namespace END
