// See https://aka.ms/new-console-template for more information

class Program {
  static void Main(){
    Console.WriteLine("Enter students details: ");
    Console.WriteLine("Enter Student Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Roll No: ");
    int rollNo = int.Parse(Console.ReadLine());
    Students student1 = new Students(name, rollNo);
    student1.DisplayDetails();
  }
}

class Students{
  public string Name {get; set;}
  public int RollNo {get; set;}

  public Students() {

  }

  public Students(string name, int rollNo) {
    Name = name;
    RollNo = rollNo;
  }

  public void DisplayDetails() {
    Console.WriteLine($"Name: {Name}, Roll No: {RollNo}");
  }
}
