using System.Collections.Generic;
using System;
using System.Linq;

namespace Anagram.Objects
{
  public class AnagramGenerator
  {

    private string _wordOriginal; // holds user input
    private List<string> _letters = new List<string>{};  //holds letters after sorting

    public AnagramGenerator(string word) // Constructor
    {
      _wordOriginal = word;
      Char[] charArray = word.ToUpper().ToCharArray();
      foreach (char letter in charArray)
      {
        _letters.Add(letter.ToString());
      }
      _letters.Sort();
    }
    
    public List<string> GetLettersList()
    {
      return _letters;
    }
  }
}
