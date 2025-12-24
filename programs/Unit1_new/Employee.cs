
class Employee {
  string name;

  public Employee(string name) {
    this.name = name;
  }

  internal void InternalMethod() {
    Console.WriteLine("This is an internal method.");
  }

  private void privateMethod() {
    Console.WriteLine("This is a private method.");
  }

  public void printDetails() {
    Console.WriteLine("Employee Name: " + this.name);
    privateMethod();
  }
}
