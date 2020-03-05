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
  }
}