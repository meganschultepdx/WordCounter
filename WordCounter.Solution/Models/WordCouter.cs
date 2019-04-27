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
      string[] sentenceArray = lowerCaseSentence.Split(' ');
      return sentenceArray;
    }

    // public int WordCountTotal(string userKeyWord, string userSentence)
    // {
    //   int count = 0;
    //   string lowerCaseSentence = userSentence.ToLower();
    //   string[] sentenceArray = lowerCaseSentence.Split(' ');
    //
    //   foreach (string userKeyWord in sentanceArray)
    //   {
    //     count += 1;
    //   }
    //
    //   return count;
    
  }
}
