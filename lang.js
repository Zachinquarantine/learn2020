using System;
using System.Collections.Generic;
class MainClass
{
  public static void Main(string[] args)
  {
    var keywords = new Dictionary<string, Action> {
      ["Hello"] = () => {
        Console.WriteLine("Hello!");
      },
      ["Hello World!"] = () => {
        Console.Write("Hello World!");
      }
    };
    string code = "Hello World!";
    var tokens = code.Split(' ');
    foreach (var token in tokens) {
      keywords[token]();
    }
  }
}
