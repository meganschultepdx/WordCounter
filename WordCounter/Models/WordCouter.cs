using System;
using System.Collections.Generic;

namespace WordCounterModels
{
  public class WordCounter
  {
    private string _userKeyWord;
    private string _userSentence;

    public string WordCounterContructor(string userKeyWord, string userSentence)
    {
      _userKeyWord = userKeyWord;
      _userSentence = userSentence;
    }

  public string GetWord()
    {
      return _userKeyWord;
      return _userSentence;
    }



  }

}
