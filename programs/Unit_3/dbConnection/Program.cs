

using Microsoft.Data.Sqlite;
namespace dbConnetion
{
  class Program
  {
    static void Main(string[] args)
    {
      string connString = @"Data Source=dbtest.db";

      using (SqliteConnection conn = new SqliteConnection(connString))
      {
        try
        {
          conn.Open();
          Console.WriteLine("Opened database successfully");
        }
        catch (SqliteException ex)
        {
          Console.WriteLine($"[ERROR] {ex.Message}");
        }
      }
    }
  }
}
