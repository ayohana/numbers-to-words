using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void MethodName1_DescriptionOfBehavior1_ExpectedResult1()
    {
      ClassName classObj = new ClassName("hi", 12, "hello");
      Assert.AreEqual("hi", classObj.Property1);
    }

    [TestMethod]
    public void MethodName2_DescriptionOfBehavior2_ExpectedResult2()
    {
      ClassName classObj = new ClassName("hi", 12, "hello");
      Assert.AreEqual(true, classObj.MethodName());
    }
  }
}