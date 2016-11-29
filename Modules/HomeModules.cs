using Nancy;
using System.Collections.Generic;
using Anagram.Objects;

namespace Anagram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/form"] = _ => {
        string wordOriginal = Request.Form["word-original"];
        string wordAnagram = Request.Form["word-anagram"];
        AnagramGenerator newAnagramGenerator = new AnagramGenerator(wordOriginal, wordAnagram);
      };
    }
  }
}
