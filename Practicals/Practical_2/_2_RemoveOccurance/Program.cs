// See https://aka.ms/new-console-template for more information

// Implement a program that removes all occurrences of a specific character from a string.

class Program {
  static void Main(string[] args){

    string originalString = "this is a test string. this string is for testing.";

    string charToRemove = "a";

    string modifiedString = originalString.Replace(charToRemove, "");

    Console.WriteLine($"Original String: {originalString}");
    Console.WriteLine($"Modified String: {modifiedString}");
  }
}
