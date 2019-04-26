using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterModels;

namespace WordCounterTests
{
  [TestClass]
  public class WordCounterTests
  {

    [TestMethod]
    public void WordCounterMethod_KeyWordSave_true()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(true, testWordCounter.WordCounterMethod("userInput"));
    }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);
    //
    //   //Act
    //   string result = newItem.GetDescription();
    //
    //   //Assert
    //   Assert.AreEqual(description, result);
    // }
  }
}
