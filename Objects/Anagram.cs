using System.Collections.Generic;
using System;
using System.Linq;

namespace Anagram.Objects
{
  public class AnagramGenerator
  {

    private string _wordOriginal;
    private List<string> _letters = new List<string>{};

    public AnagramGenerator(string word)
    {
      _wordOriginal = word;
      Char[] charArray = word.ToUpper().ToCharArray();
      foreach (char letter in charArray)
      {
        _letters.Add(letter.ToString());
      }
      _letters.Sort();
    }
  }
}
