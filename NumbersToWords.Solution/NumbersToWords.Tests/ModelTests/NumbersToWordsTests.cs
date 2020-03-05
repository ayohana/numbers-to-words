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
      Assert.AreEqual("5", converter.Numeric);
    }
  }
}