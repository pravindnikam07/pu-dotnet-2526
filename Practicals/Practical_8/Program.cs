using System;

class Program
{
  static void Main(string[] agrs)
  {
    Console.WriteLine("Welocome to Currency Converter");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1. INR to USD");
    Console.WriteLine("2. INR to Euro");
    Console.WriteLine("3. INR to Frank");
    Console.WriteLine("4. USD to INR");
    Console.WriteLine("5. Euro to INR");
    Console.WriteLine("6. Frank to INR");
    Console.WriteLine("7. Exit");
    Console.WriteLine("-----------------------------------");

    while(true) {
      Console.WriteLine("Choose the conversion option from the above: ");
      int choice = int.Parse(Console.ReadLine());
      if(choice == 7) {
        Console.WriteLine("Thank you for using the Currency Converter. visit the app again!");
        return;
      }
      Console.WriteLine("Enter the amount to be convert: ");
      double amount = double.Parse(Console.ReadLine());

      switch(choice) {
        case 1 : Console.WriteLine($"INR {amount} = USD {InrToUsd(amount)}");
        break;

        case 2 : Console.WriteLine($"INR {amount} = Euro {InrToEuro(amount)}");
        break;

        case 3 : Console.WriteLine($"INR {amount} = Frank {InrToFrank(amount)}");
        break;

        case 4 : Console.WriteLine($"USD {amount} = INR {UsdToInr(amount)}");
        break;

        case 5 : Console.WriteLine($"Euro {amount} = INR {EuroToInr(amount)}");
        break;

        case 6 : Console.WriteLine($"Frank {amount} = INR {FrankToInr(amount)}");
        break;

        case 7 : return; // Environment.Exit(0);
      }
    }

  }

  static double InrToUsd(double inr)
  {
    return inr / 90.0;
  }

  static double InrToEuro(double inr)
  {
    return inr / 106.0;
  }

  static double InrToFrank(double inr)
  {
    return inr / 118.0;
  }

  static double UsdToInr(double usd)
  {
    return usd * 90;
  }

  static double EuroToInr(double euro)
  {
    return euro * 106;
  }

  static double FrankToInr(double frank)
  {
    return frank * 118;
  }
}
