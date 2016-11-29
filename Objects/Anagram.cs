using System.Collections.Generic;
using System;

namespace Anagram.Objects
{
  public class AnagramGenerator
  {

    private string _wordOriginal;
    private string _wordAnagram;
    private List<string> _lettersList = new List<string>{};

    public Anagram(string wordOriginal, string wordAnagram)
    {
      _wordOriginal = wordOriginal;
      _wordAnagram = wordAnagram;
      Char[] lettersArray = wordOriginal.ToLower().ToCharArray();
      foreach (letter in lettersArray)
      {
        _lettersList.Add(letter.ToString());
      }
      _lettersList.Sort();
    }

  }
}
