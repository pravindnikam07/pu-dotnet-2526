
class Pragram {
  static void Main(string[] args) {
    Console.WriteLine("Hello C#");

    BTech.Student btechs1 = new BTech.Student("John", 89.5);
    btechs1.printDetails();

    BTech.Student btechs2 = new BTech.Student("Rahul");
    btechs2.printDetails();

    BTech.Student btechs3 = new BTech.Student();
    btechs3.printDetails();

    btechs3 = null;
    GC.Collect();

    MTech.Student mtechs1 = new MTech.Student("Devid", 9.3);
    mtechs1.printDetails();


    // Calculator

    Math.Calculator calc = new Math.Calculator();
    int a = 10;
    int b = 20;
    int c = 30;
    int sum = calc.Add(a, b, c);
    Console.WriteLine("Sum: " + sum);

    // Employee

    Employee emp1 = new Employee("Alice");
    emp1.printDetails();

    emp1.InternalMethod();
  }
}
