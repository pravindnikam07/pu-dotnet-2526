// See https://aka.ms/new-console-template for more information

class PrimeNumberCheck
{
  static void Main()
  {
    while (true)
    {
      Console.WriteLine("Enter a number to check if it is prime or enter 0 to exit: ");

      int num = int.Parse(Console.ReadLine());

      if (num == 0)
      {
        Console.WriteLine("Exiting the program...");
        return;
      }

      bool isPrime = true;
      for (int i = 2; i < num; i++)
      {
        if (num % i == 0)
        {
          isPrime = false;
          break;
        }
      }

      if (isPrime)
      {
        Console.WriteLine("Prime Number");
      }
      else
      {
        Console.WriteLine("Not a Prime Number");
      }
    }
  }
}
