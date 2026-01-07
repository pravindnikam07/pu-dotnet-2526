
namespace Math
{
  class Program
  {
    static void Main(string[] agrs)
    {
      Vector v1 = new Vector(2, 5);
      Vector v2 = new Vector(3, 4);

      // without operator overloading
      Vector v3 = new Vector(v1.x + v2.x, v1.y + v2.y);
      Console.WriteLine($"v3: ({v3.x}, {v3.y})");

      // with operator overloading
      Vector v4 = v1 + v2;
      Console.WriteLine($"v4: ({v4.x}, {v4.y})");

    }
  }

  class Vector
  {
    public int x, y;
    public Vector(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
      // Vector v3 = new Vector(v1.x + v2.x, v1.y + v2.y);
      // return v3;
      return new Vector(v1.x + v2.x, v1.y + v2.y);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
      return new Vector(v1.x - v2.x, v1.y - v2.y);
    }
  }
}
