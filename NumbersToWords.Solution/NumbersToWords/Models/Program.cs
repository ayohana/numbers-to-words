using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number between 0-999:");
      string input = Console.ReadLine();
      Converter converter = new Converter(input);
      string output = converter.ConvertToWords();
      Console.WriteLine(output);
    }
  }
}