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
    public void GetUserKeyWord_UserKeyWordGet_True()
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
    public void GetUserSentence_UserSentenceGet_True()
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
    public void SentenceToArray_UserSentenceToLowerCaseArray_True()
    {
      //Arrange
      string userSentence = "This day really Sux!";
      WordCounter newSentence = new WordCounter("text", userSentence);
      //Act
      string[] sentenceArray = newSentence.SentenceToArray(userSentence);

      //Assert
      Assert.AreEqual("sux", sentenceArray[3]);
    }

    //test for 0 occurances
    [TestMethod]
    public void WordCountTotal_CountUserKeyWordInArrayZero_True()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("day", "This milk really sux!");
      string userKeyWord = newWordCounter.GetUserKeyWord();
      string userSentence = newWordCounter.GetUserSentence();
      string[] userArray = newWordCounter.SentenceToArray(userSentence);

      //Act
      int count = newWordCounter.WordCountTotal(userKeyWord, userArray);

      //Assert
      Assert.AreEqual(0, count);
    }
    //test for one occurance
    [TestMethod]
    public void WordCountTotal_CountUserKeyWordInArrayOne_True()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("day", "This day really sux!");
      string userKeyWord = newWordCounter.GetUserKeyWord();
      string userSentence = newWordCounter.GetUserSentence();
      string[] userArray = newWordCounter.SentenceToArray(userSentence);

      //Act
      int count = newWordCounter.WordCountTotal(userKeyWord, userArray);

      //Assert
      Assert.AreEqual(1, count);
    }
    //Test for 2 occurances
    [TestMethod]
    public void WordCountTotal_CountUserKeyWordInArrayTwo_True()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("day", "This day really sux day!");
      string userKeyWord = newWordCounter.GetUserKeyWord();
      string userSentence = newWordCounter.GetUserSentence();
      string[] userArray = newWordCounter.SentenceToArray(userSentence);

      //Act
      int count = newWordCounter.WordCountTotal(userKeyWord, userArray);

      //Assert
      Assert.AreEqual(2, count);
    }
  }
}
