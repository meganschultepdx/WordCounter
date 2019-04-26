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
    public void WordCounter_CreatesInstanceOfItem_True()
    {
      //Arrange
      //Act
      WordCounter testUserInput = new WordCounter("rad", "I went to a bookstore.");
      //Assert
      Assert.AreEqual(typeof(WordCounter), testUserInput.GetType());
    }

    [TestMethod]
    public void WordCounter_UserKeyWordGet_string()
    {
      //Arrange
      // string UserKeyWord = "rad";
      WordCounter NewKeyWord = new WordCounter("rad");

      //Act
      string result = NewKeyWord.GetUserKeyWord();

      //Assert
      Assert.AreEqual("rad", result);
    }

    [TestMethod]
    public void WordCounter_UserSentenceGet_string()
    {
      //Arrange
      // string UserKeyWord = "rad";
      WordCounter NewKeyWord = new WordCounter("rad");

      //Act
      string result = NewKeyWord.GetUserKeyWord();

      //Assert
      Assert.AreEqual("rad", result);
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
