using System;
using HigherLowerGame;
  public class Program {
    static void Main()
    {
      Game g = new Game();
      bool gameOver = false;
      Console.WriteLine("Let's play a game! Choose a number between 1 and 100 and I will guess it!");
      while(!gameOver) {
        Console.WriteLine("Is your number " + g.Number +  "? (Higher/Lower/Correct)");
        string answer = Console.ReadLine();
        gameOver = g.GuessNumber(answer);
      }
      if(gameOver) {
        Console.WriteLine("Good Game");
      }
    }
  }
