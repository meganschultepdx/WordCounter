using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounterModels;

namespace WordCounterTests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void WordCounter_UserKeyWordUserSentenceProperties_True()
    {
      WordCounter testUserInput = new WordCounter("rad", "I went to a bookstore.");
      Assert.AreEqual(typeof(WordCounter), testUserInput.GetType());
    }
    //
    // [TestMethod]
    // public void WordCounter_UserKeyWordUserSentenceSave_()
    // {
    //   WordCounter testUserInputs = new WordCounter("rad");
    //   Assert.AreEqual("rad", testInputs.GetWord("rad"));
    // }

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
