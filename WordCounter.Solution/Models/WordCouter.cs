using System;
using System.Collections.Generic;

namespace WordCounterModels
{
  public class WordCounter
  {
    private string _userKeyWord;
    private string _userSentence;

    public WordCounter (string userKeyWord, string userSentence)
    {
      _userKeyWord = userKeyWord.ToLower();
      _userSentence = userSentence;
    }

    public string GetUserKeyWord()
    {
      return _userKeyWord;
    }

    public string GetUserSentence()
    {
      return _userSentence;
    }

    public string[] SentenceToArray(string userSentence)
    {
      string lowerCaseSentence = userSentence.ToLower();
      string[] sentenceArray = lowerCaseSentence.Split(' ', '.', '!', '?');
      return sentenceArray;
    }

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
