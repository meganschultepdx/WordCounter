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

  public string WordCounter ()

  }
}





//   public string GetWord()
//     {
//       return _userKeyWord;
//       return _userSentence;
//     }
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
