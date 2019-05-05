using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCountMachine.Models;

namespace WordCountMachine.Tests
{
  [TestClass]
  public class EntriesTests: IDisposable
  {
    public void Dispose()
    {
      Entries.ClearAll();
    }

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
    public void userKeyWord_GetUserKeyWord_String()
    {
      // Arrange
      WordCounter newUserWord = new WordCounter("RaD", "I am tired.");

      // Act
      string testGetWord = newUserWord.UserKeyWord;

      // Assert
      Assert.AreEqual("rad", testGetWord);
    }

    [TestMethod]
public void UserSentence_SentenceToLowerArray_True()
{
  // Arrange
  WordCounter newUserSentence = new WordCounter("RaD", "I am fine.");

  // Act
  string[] testGetSentence = newUserSentence.ArraySentence;

  // Assert
  Assert.AreEqual("fine", testGetSentence[2]);
}

    //test for 0 occurances
    [TestMethod]
    public void WordCountTotal_CountUserKeyWordInArrayZero_True()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("day", "This milk really sux!");
      string userKeyWord = newWordCounter.UserKeyWord;
      string[] arraySentence = newWordCounter.ArraySentence;

      //Act
      int count = newWordCounter.WordCountTotal(userKeyWord, arraySentence);

//Assert
      Assert.AreEqual(0, count);
    }
    //test for one occurance
    [TestMethod]
    public void WordCountTotal_CountUserKeyWordInArrayOne_True()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("day", "This day really sux!");
      string userKeyWord = newWordCounter.UserKeyWord;
      string[] arraySentence = newWordCounter.ArraySentence;

      //Act
      int count = newWordCounter.WordCountTotal(userKeyWord, arraySentence);

      //Assert
      Assert.AreEqual(1, count);
    }
    //Test for 2 occurances
    [TestMethod]
    public void WordCountTotal_CountUserKeyWordInArrayTwo_True()
    {
      //Arrange
      WordCounter newWordCounter = new WordCounter("day", "This day really day sux!");
      string userKeyWord = newWordCounter.UserKeyWord;
      string[] arraySentence = newWordCounter.ArraySentence;

      //Act
      int count = newWordCounter.WordCountTotal(userKeyWord, arraySentence);

      //Assert
      Assert.AreEqual(2, count);
    }
  }
}
