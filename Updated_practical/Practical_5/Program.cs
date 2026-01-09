// Write C# code to do the following
// • Convert binary to decimal
// • Convert decimal to hexadecimal
// • Convert decimal to binary
// • Convert decimal to octal


using System.Runtime.InteropServices.Marshalling;

namespace NumberConversion
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a binary number:");
      string binary = Console.ReadLine();
      Console.WriteLine($"Decimal: {BinaryToDecimal(binary)}");

      Console.WriteLine("Enter a decimal number: ");
      int decimalValue = int.Parse(Console.ReadLine());
      Console.WriteLine($"Binary : {DecimalToBinary(decimalValue)}");
    }

    // Convert binary to decimal
    static int BinaryToDecimal(string binary)
    {
      // Using built-in method
      // return Convert.ToInt32(binary, 2);

      // Using manual conversion
      int decimalValue = 0;
      int power = 0;
      for (int i = binary.Length - 1; i >= 0; i--)
      {
        int bit = binary[i] - '0';
        decimalValue += bit * (int)Math.Pow(2, power);
        power++;
      }
      return decimalValue;
    }

    static string DecimalToBinary(int decimalValue)
    {
      // Using manual conversion
      // return Convert.ToString(decimalValue, 2);

      // Using manual conversion
      string binary = "";
      while (decimalValue != 0)
      {
        int remainder = decimalValue % 2;
        binary = remainder.ToString() + binary;
        decimalValue /= 2;
      }
      return binary;
    }
  }
}
