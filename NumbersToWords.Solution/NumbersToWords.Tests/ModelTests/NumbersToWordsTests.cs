using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ConverterTests
  {
    [TestMethod]
    public void ConverterConstructor_CreateConverter_Converter()
    {
      Converter converter = new Converter("5");
      Assert.AreEqual(typeof(Converter), converter.GetType());
    }

    [TestMethod]
    public void ConverterConstructor_StoresUserInput_UserInput()
    {
      Converter converter = new Converter("5");
      string expected = "5";
      Assert.AreEqual(expected, converter.Numeric);
    }

    [TestMethod]
    public void ConvertToWords_ConvertSingleDigit_String()
    {
      Converter converter = new Converter("5");
      string expected = "five";
      string output = converter.ConvertToWords();
      Assert.AreEqual(expected, output);
    }

    [TestMethod]
    public void ConvertToWords_ConvertDoubleDigits_String()
    {
      Converter converter = new Converter("85");
      string expected = "eighty five";
      string output = converter.ConvertToWords();
      Assert.AreEqual(expected, output);
    }

    [TestMethod]
    public void ConvertToWords_ConvertTripleDigits_String()
    {
      Converter converter = new Converter("385");
      string expected = "three hundred eighty five";
      string output = converter.ConvertToWords();
      Assert.AreEqual(expected, output);
    }

    [TestMethod]
    public void ConvertToWords_AccountForZeros_String()
    {
      Converter converter = new Converter("330");
      string expected = "three hundred thirty";
      string output = converter.ConvertToWords();
      Assert.AreEqual(expected, output);
    }

    [TestMethod]
    public void ConvertToWords_AccountForSingleZero_String()
    {
      Converter converter = new Converter("0");
      string expected = "zero";
      string output = converter.ConvertToWords();
      Assert.AreEqual(expected, output);
    }

    [TestMethod]
    public void ConvertToWords_InvalidInput_String()
    {
      Converter converter = new Converter("1invalid");
      string expected = "Invalid Input";
      string output = converter.ConvertToWords();
      Assert.AreEqual(expected, output);
    }
  }
}