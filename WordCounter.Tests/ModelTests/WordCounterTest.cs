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
      WordCounter newKeyWord = new WordCounter(userKeyWord, "test sentence");

      //Act
      string result = newKeyWord.GetUserKeyWord();

      //Assert
      Assert.AreEqual(userKeyWord, result);
    }

    [TestMethod]
    public void WordCounter_UserSentenceGet_string()
    {
      //Arrange
      string userSentence = "I went to a bookstore.";
      WordCounter newSentence = new WordCounter("text", userSentence);
      //Act
      string sentenceResult = newSentence.GetUserSentence();

      //Assert
      Assert.AreEqual(userSentence, sentenceResult);
    }

    [TestMethod]
    public void WordCounter_UserSentenceToArray_array()
    {
      //Arrange
      string userSentence = "I went to a bookstore.";
      SentenceToArray newSentence = new SentenseToArray(userSentence);
      //Act
      string[] sentenceArray = newSentence.SentenceToArray();

      //Assert
      Assert.AreEqual(userSentence, sentenceArray);
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
