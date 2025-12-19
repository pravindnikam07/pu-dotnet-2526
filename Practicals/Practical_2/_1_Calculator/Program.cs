// See https://aka.ms/new-console-template for more information

// Write a program to implement a basic calculator using switch-case statements.

class Program {

  static void Main(string[] args) {
    Calculator calculator = new Calculator();

    Console.WriteLine("Enter first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter operator (+, -, *, /, %):  ");
    string oper = Console.ReadLine();

    switch(oper) {
      case "+": Console.WriteLine($"Addition of {a} and {b} is {calculator.add(a,b)}");
                break;

      case "-" : Console.WriteLine($"Subtration of {a} and {b} is {calculator.subtract(a,b)}");
                  break;

      case "*" : Console.WriteLine($"Multiplication of {a} and {b} is {calculator.multiply(a,b)}");
                 break;

      case "/" : Console.WriteLine($"Division  of {a} and {b} is {calculator.divide(a,b)}");
                 break;

      case "%" : Console.WriteLine($"Reminder of {a} and {b} is {calculator.modulus(a,b)}");
                break;

      default : Console.WriteLine("Enter correct operator");
                break;
    }

  }
}


