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
        AnagramGenerator newAnagramGenerator = new AnagramGenerator(Request.Form["originalWord"]);
        return View["result.cshtml", newAnagramGenerator];
      };
    }
  }
}
