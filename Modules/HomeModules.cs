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
        var word1 = Request.Form["word1"];
        var word2 = Request.Form["word2"];
        AnagramGenerator newAnagramGenerator = new AnagramGenerator();
        newAnagramGenerator.Compare(word1, word2);
        return View["result.cshtml", newAnagramGenerator];
      };
    }
  }
}
