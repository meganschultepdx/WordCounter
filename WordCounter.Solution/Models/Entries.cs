using System;
using System.Collections.Generic;

namespace WordCountMachine.Models
{
  public class WordCounter
  {
    private string _userKeyWord;
    private string _originalSentence;
    private string[] _userSentence;
    private int _count;

    public WordCounter (string userKeyWord, string userSentence)
    {
      _userKeyWord = userKeyWord.ToLower();
      _originalSentence = userSentence;
      _userSentence = userSentence.ToLower().Split(' ', '.', '!', '?');

      int count = WordCountTotal();
      _count = count;
    }

    public string GetUserKeyWord()
    {
      return _userKeyWord;
    }

    public void SetUserKeyWord(string newUserKeyWord)
    {
      _userKeyWord = newUserKeyWord;
    }

    public string[] GetUserSentence()
    {
      return _userSentence;
    }

    public void SetUserSentence(string[] newUserSentence)
    {
      _userSentence = newUserSentence;
    }

    public string GetOriginalSentence()
    {
      return _originalSentence;
    }

    public void SetOriginalSentence(string newUserSentence)
    {
      _originalSentence = newUserSentence;
    }

    public int GetWordCountTotal()
    {
      return _count;
    }

    // public string[] SentenceToArray(string userSentence)
    // {
    //   string lowerCaseSentence = userSentence.ToLower();
    //   string[] sentenceArray = lowerCaseSentence.Split(' ', '.', '!', '?');
    //   return sentenceArray;
    // }

    public int WordCountTotal(string userKeyWord, string[] userArray)
    {
      int count = 0;

      for (int i=0; i<userArray.Length; i++)
      {
        if (userKeyWord == userArray[i])
        {
          count += 1;
        }
      }
      return count;
    }
  }
}
