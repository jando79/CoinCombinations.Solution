using System;
using CoinCombinations.Business;
namespace CoinCombinations {
  public class Program {
    static void Main() {
      Console.WriteLine("Hello, please enter a money amount that is of the type double.");
      try{
        double moneyNumber = double.Parse(Console.ReadLine());
        Console.WriteLine($"Your amount is {CoinCombinator.ConvertToCoinString(moneyNumber)}");
      } catch(Exception e) {
        Console.WriteLine(e.Message);
      }
        
      
      
    }
  }
}
