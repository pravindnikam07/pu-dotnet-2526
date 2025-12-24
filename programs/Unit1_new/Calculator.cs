
namespace Math {
  public class Calculator{
    public int Add(int a, int b) {
      Console.WriteLine("Integer Add called with 2 parameters");
      return a + b;
    }

    public int Add(int a, int b, int c) {
      Console.WriteLine("Integer Add called with 3 parameters");
      return a + b + c;
    }

    public double Add(double a, double b) {
      Console.WriteLine("Double Add called");
      return a + b;
    }
  }
}
