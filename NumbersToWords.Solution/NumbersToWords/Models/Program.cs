using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Program
  {
    public static void Main()
    {
      Converter converter = new Converter("311");
      string output = converter.ConvertToWords();
    }
  }
}