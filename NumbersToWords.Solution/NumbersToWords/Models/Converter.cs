using System;

namespace NumbersToWords.Models
{
  public class Converter
  {
    public string Property1 { get; set; }
    public int Property2 { get; set; }

    public Converter(string property1, int property2)
    {
      Property1 = property1;
      Property2 = property2;
    }

    public bool MethodName()
    {
      return true;
    }
  }
}