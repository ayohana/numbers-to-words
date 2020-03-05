using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Converter
  {
    public string Numeric { get; set; }
    private Dictionary<string, string> _ones;
    private Dictionary<string, string> _teens;
    private Dictionary<string, string> _tens;

    public Converter(string numeric)
    {
      Numeric = numeric;
      _ones = new Dictionary<string, string>()
      { { "1", "one" }, { "2", "two" }, { "3", "three" }, { "4", "four" }, { "5", "five" }, { "6", "six" }, { "7", "seven" }, { "8", "eight" }, { "9", "nine" }
      };
      _teens = new Dictionary<string, string>()
      { { "10", "ten" }, { "11", "eleven" }, { "12", "twelve" }, { "13", "thirteen" }, { "14", "fourteen" }, { "15", "fifteen" }, { "16", "sixteen" }, { "17", "seventeen" }, { "18", "eighteen" }, { "19", "nineteen" },
      };
      _tens = new Dictionary<string, string>()
      { { "2", "twenty" }, { "3", "thirty" }, { "4", "fourty" }, { "5", "fifty" }, { "6", "sixty" }, { "7", "seventy" }, { "8", "eighty" }, { "9", "ninety" },
      };
    }

    public string ConvertToWords()
    {
      string[] numArray = Numeric.Split("");
      int num;
      List<string> output = new List<string>();
      if (!int.TryParse(Numeric, out num))
      {
        return "Invalid Input";
      }
      for (int i = numArray.Length - 1; i >= 0; i--)
      {
        if (i == (numArray.Length - 1))
        {
          output.Insert(0, _ones[numArray[i]]);
        }
      }
      string outputString = String.Join(" ", output.ToArray());
      return outputString;
    }
  }
}