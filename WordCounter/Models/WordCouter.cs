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
    _userKeyWord = userKeyWord;
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

  ;

  }

  }
}





//
//   public string SetWord(string newUserKeyWord, newUserSentence)
//   {
//       _userKeyWord = newUserKeyWord;
//       _userSentence = newUserSentence;
// }
//   public string WordCounterCheck(string newUserKeyWord, newUserSentence)
//   {
//     string [] sentenceArray = userSentence.split();
//
//   }

//
