
// Write C# code to display the asterisk pattern as shown below:
/*
rows = 2
columns = 5
*****
*****


rows = 4
columns = 3
***
***
***
***
*/

using System;
namespace PatternPrinting
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Entern the number of rows: ");
      int rows = int.Parse(Console.ReadLine());
      Console.WriteLine("Entern the number of colums: ");
      int col = int.Parse(Console.ReadLine());

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < col; j++)
        {
          Console.Write("* ");
        }
        Console.WriteLine();
      }
    }
  }
}
