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
      string userKeyWord = "RaD";
      WordCounter newKeyWord = new WordCounter(userKeyWord, "test sentence");

      //Act
      string result = newKeyWord.GetUserKeyWord();

      //Assert
      Assert.AreEqual("rad", result);
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
    public void WordCounter_UserSentenceToLowerCaseArray_true()
    {
      //Arrange
      string userSentence = "This day really Sux.";
      WordCounter newSentence = new WordCounter("text", userSentence);
      //Act
      string[] sentenceArray = newSentence.SentenceToArray(userSentence);

      //Assert
      Assert.AreEqual("sux.", sentenceArray[3]);
    }

    // [TestMethod]
    // public void WordCounter_UserKeyWordToLowercase_string()
    // {
    //   //Arrange
    //   string userKeyWord = "rad";
    //   WordCounter newKeyWord = new WordCounter(userKeyWord, "test sentence");
    //
    //   //Act
    //   string lowerCaseWord = newKeyWord.WordCountTotal(userKeyword);
    //
    //   //Assert
    //   Assert.AreEqual("rad", lowerCaseWord);
    // }




  }
}
