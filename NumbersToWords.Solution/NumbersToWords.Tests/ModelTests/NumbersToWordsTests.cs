using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ConverterTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      Converter converter = new Converter("hi", 12, "hello");
      Assert.AreEqual("hi", converter.Property1);
    }

    [TestMethod]
    public void MethodName2_DescriptionOfBehavior2_ExpectedResult2()
    {
      Converter converter = new Converter("hi", 12, "hello");
      Assert.AreEqual(true, converter.MethodName());
    }
  }
}