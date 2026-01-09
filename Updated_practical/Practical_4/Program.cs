
// Write C# code to prompt a user to input his/her name and country name and then the output will be shown as an example below: Hello Ram from country India!


namespace PrintDetails
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter your country name: ");
      string country = Console.ReadLine();

      // Using concatenation
      Console.WriteLine("Hello " + name + " from country " + country + "!");

      // Using string interpolation/Literals
      Console.WriteLine($"Hello {name} from country {country}!");
    }
  }

}
