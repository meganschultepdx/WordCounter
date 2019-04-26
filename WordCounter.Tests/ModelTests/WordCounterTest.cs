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
      string userKeyWord = "rad";
      WordCounter newKeyWord = new WordCounter(userKeyWord);

      //Act
      string result = newKeyWord.GetUserKeyWord();

      //Assert
      Assert.AreEqual("rad", NewKeyWord);
    }

    [TestMethod]
    public void WordCounter_UserSentenceGet_string()
    {
      //Arrange


      //Act
      WordCounter NewSentence = new WordCounter("I went to a bookstore.");

      //Assert
      Assert.AreEqual("I went to a bookstore.", NewSentence);
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
