using System;
namespace CoinCombinations.Business
{
  public class CoinCombinator
  { //class that passes first test
    public static string ConvertToCoinString(double moneyNumber) //double is used to define numeric variables holding numbers with decimal points.
    {
      try
      {
        double quarter = 0.25;
        double penny = 0.01;
        double dime = 0.10;
        double nickel = 0.05;
        int totalQuarters = (int)Math.Floor(moneyNumber / quarter); //math.floor rounds decimals down to zero //checking for quarters first before passing into rest of code
        moneyNumber -= totalQuarters * quarter;// -= is minus equals
        int totalDimes = 0;
        int totalNickels = 0;
        int totalPennies = 0;
        if (moneyNumber > 0)
        {
          totalDimes = (int)Math.Floor(moneyNumber / dime);
          moneyNumber -= totalDimes * dime;
        }
        if (moneyNumber > 0)
        {
          totalNickels = (int)Math.Floor(moneyNumber / nickel);
          moneyNumber -= totalNickels * nickel;
        }
        if (moneyNumber > 0)
        {
          totalPennies = (int)Math.Floor(moneyNumber / penny); ;
        }

        string returnString = "";
        if (totalQuarters > 0)
        {
          returnString += $"{totalQuarters} quarters";
        }

        if (totalDimes > 0)
        {
          returnString += ", ";
          returnString += $"{totalDimes} dimes";
        }

        if (totalNickels > 0)
        {
          returnString += ", ";
          returnString += $"{totalNickels} nickels";
        }

        if (totalPennies > 0)
        {
          returnString += ", ";
          returnString += (totalPennies == 1) ? $"{totalPennies} penny" : $"{totalPennies} pennies";
        }

        return returnString;
      }
      catch (Exception e)
      {
        return e.Message;
      }

    }
  }
}