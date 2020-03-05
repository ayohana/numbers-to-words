using System;


namespace ProjectName
{
  public class ClassName
  {
    public string Property1 { get; set; }
    public int Property2 { get; set; }
    private string _property3;
    public string Property3
    {
      get
      {
        return "this property is a secret and you can't access it";
      }
      set
      {
        _property3 = value;
      }
    }

    public ClassName(string property1, int property2, string property3)
    {
      Property1 = property1;
      Property2 = property2;
      Property3 = property3;
    }

    public bool MethodName () {
      return true;
    }
  }  
}

