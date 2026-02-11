
using System.Net;

namespace Revision;

class ConstructorDemo
{
  int a; // instance variable or non-static variable
  static int b = 20; // static variable or class variable

  // No argument constructor or default constructor
  public ConstructorDemo()
  {
    a = 10;
    Console.WriteLine("Inside no argument constructor");
  }

  // Parameterized constructor
  public ConstructorDemo(int x)
  {
    a = x;
  }

  static void Main(string[] args)
  {
    int c = 30; // local variable
    ConstructorDemo obj1 = new ConstructorDemo(); // object of ConstructorDemo class

  }
}
