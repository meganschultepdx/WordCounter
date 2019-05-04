using System;
using System.Collections.Generic;

namespace WordCountMachine.Models
{
  public class WordCounter
  {
    public string UserKeyWord { get; set;}
    public string OriginalSentence { get; set;}
    public string[] ArraySentence { get; set;}
    public int Count { get;}

    public WordCounter (string userKeyWord, string userSentence)
    {
      UserKeyWord = userKeyWord.ToLower();
      OriginalSentence = userSentence;
      ArraySentence = userSentence.ToLower().Split('"', '.', '!', '?', '"');
      int count = WordCountTotal(userKeyWord, ArraySentence);
      Count = count;
    }

    public int WordCountTotal(string userKeyWord, string[] arraySentence)
    {
      int count = 0;

      for (int i=0; i < ArraySentence.Length; i++)
      {
        if (userKeyWord == ArraySentence[i])
        {
          count += 1;
        }
      }
      return count;
    }
  }
}
