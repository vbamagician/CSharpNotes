/*
Multiple Inheritance with Interface:

How many types of inheritance? five type! mentioned following..
1. Single //possible
2. Multi-level //possible
3. Hierarchical //possible
4. Hybrid //not possible 
5. Multiple // not possible

- Even if multiple inheritance is not supported through classes in C#, it is still supported through interfaces. 

- A Class can have one and only one immediate parent class, where as the same class can have any number of interfaces as it's parent. i.e. multiple inheritance is supported in c# through Interfaces.

? Why multiple inheritance is not supported through classes and how is it supported through interfaces? 

ANS? Consuming will cause you an ambiguity but implementation will not because in classes, methods have been already implemented and they both _might_ have some specific lines of instructions. So compiler gets confused which is of which! But in case of Interfaces, we can pass same method to the child class from multiple interfaces, because, we can now implement methods which will not cause any issues. In short, the control in classes have under parent class while in interfaces, control is in child class that's why it will not cause any issues. 

*/

// => Example 1:

namespace InterfaceProject
{

  interface Interface1
  {
    void Test();
    void Show();
  }

  interface Interface2
  {
    void Test();
    void Show();
  }

  class MultipleInheritanceTest : Interface1, Interface2
  {

    public void Test()
    {
      Console.WriteLine("Interface Methods Implemented");
    }

    void Interface1.Show() 
    {
      Console.WriteLine("Declared In Inteface1 and Implemented in Class");
    }

    void Interface2.Show() 
    {
      Console.WriteLine("Declared In Inteface2 and Implemented in Class");
    }

    static void Main()
    {
      MultipleIn heritanceTest obj = new MultipleInheritanceTest();
      obj.Test();

      Interface1 i1 = obj;
      i1.Show();

      Interface2 i2 = obj;
      i2.Show();

      Console.ReadLine(); 
    }

  }
}

//<= End of Example 1

