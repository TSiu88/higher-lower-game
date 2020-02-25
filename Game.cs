using System;

namespace HigherLowerGame {
  public class Game {

    public int LowBound {get; set;}
    public int HighBound {get;set;}

    public int Number { get; set;}
     
    public Game() {
      Number = 50;
      LowBound = 1;
      HighBound = 100;
    }
    public bool GuessNumber(string userInput) {
      if(userInput == "Higher") {
        LowBound = Number;
      } else if (userInput == "Lower") {
        HighBound = Number;
      } else if (userInput == "Correct") {
        return true;
      }
      Number = ((HighBound - LowBound)/2) + LowBound;
      return false;
    }
  }
}