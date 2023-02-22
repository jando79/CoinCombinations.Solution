using CoinCombinations.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinCombinations.Tests 
{
  [TestClass]
  public class CoinCombinatorTest
  {
    [TestMethod]
    public void CoinCombinatorConstructor_CreatesInstanceOfCoinCombinator_CoinCombinator() 
    {
      CoinCombinator c = new CoinCombinator(); //testing creating class
      Assert.AreEqual(typeof(CoinCombinator), c.GetType());
    }

    [TestMethod]
    public void ConvertToCoinString_ReturnsStringOfCoins_String()//public is like export in java. what it does
    {
      Assert.AreEqual("1 penny", CoinCombinator.ConvertToCoinString(0.01));
    }

    [TestMethod]
    public void ConvertToCoinString_ReturnsTwoQuartersForFiftyCents_String()
    {
      Assert.AreEqual("2 quarters", CoinCombinator.ConvertToCoinString(0.50));
    }
  }
}