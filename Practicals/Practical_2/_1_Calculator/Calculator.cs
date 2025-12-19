
class Calculator {
  public int add(int a, int b) {
    return a + b;
  }

  public int subtract(int a, int b) {
    return a - b;
  }

  public int multiply(int a, int b) {
    return a * b;
  }

  public int divide(int a, int b) {
    if(b == 0) {
      Console.WriteLine("Cannot divide by zero");
      return 0;
    }
    return a / b;
  }

  public int modulus(int a, int b) {
    return a % b;
  }
}
