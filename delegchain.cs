using System;
using System.Linq;
using System.Collections.Generic;
public class Chain<T> : List<Func<T, T>>
{
  public T Evaluate(T input)
  {
    foreach (var ix in this)
    {
      input = ix(input);
    }
    return input;
  }
}
class MainClass
{
  public static void Main(string[] args)
  {
    var keywords = new Dictionary<string, Func<string, string>>
    {
      ["capitalize"] = (input) =>
      {
        return input.Replace("e", "EE");
      },
      ["replace"] = (input) =>
      {
        return input.Replace("o", "0");
      }
    };
    string code = "capitalize replace";
    var tokens = code.Split(' ');
    var chain = new Chain<string>();
    chain.AddRange(tokens.Select(ix => keywords[ix]));
    var result = chain.Evaluate("Done!");
    Console.WriteLine(result);
  }
}
