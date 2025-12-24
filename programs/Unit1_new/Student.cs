
namespace BTech {
  public class Student {
    public string name;
    public double HSCmarks;

    // Default constructor
    public Student() {
      Console.WriteLine("Default Constructor called");
    }

    // one parameterized constructor
    public Student(string name) {
      Console.WriteLine("One Parameterized Constructor called");
      this.name = name;
    }

    public Student(int marks) {
      Console.WriteLine("One Parameterized Constructor called");
      this.HSCmarks = marks;
    }

    // two parameterized constructor
    public Student(string name, double HSCmarks) {
      Console.WriteLine("Two Parameterized Constructor called");
      this.name = name;
      this.HSCmarks = HSCmarks;
    }

    ~Student() {
      Console.WriteLine("Destructor called for Student: " + this.name);
    }

    public void printDetails() {
      Console.WriteLine($"Name: {this.name}, HSC Marks: {this.HSCmarks}");
    }
  }
}


namespace MTech {
  public class Student {
    public string name;
    public double BtechCGPA;


    public Student(string name, double BtechCGPA) {
      this.name = name;
      this.BtechCGPA = BtechCGPA;
    }

    public void printDetails() {
      Console.WriteLine($"Name: {this.name}, BTech CGPA: {this.BtechCGPA}");
    }
  }
}
