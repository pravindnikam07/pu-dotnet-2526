# Introduction to Object-Oriented Programming (OOP)

---

## 📚 Topic 7.1: What is OOP? The Four Pillars Explained

### What is Object-Oriented Programming?

**Object-Oriented Programming (OOP)** is a programming paradigm that organizes code around **objects** rather than functions and logic. Objects represent real-world entities with properties (data) and behaviors (methods).

**Simple Analogy:**
Think of OOP like building with LEGO blocks:
- **Class** = LEGO instruction manual (blueprint)
- **Object** = The actual LEGO structure you build
- **Properties** = Color, size, shape of blocks
- **Methods** = What you can do with it (move, rotate, connect)

### Why Use OOP?

1. **Real-world Modeling** - Code mirrors real-world entities
2. **Code Reusability** - Write once, use multiple times
3. **Maintainability** - Easier to modify and update
4. **Scalability** - Better for large applications
5. **Security** - Data hiding and encapsulation
6. **Modularity** - Organized into logical units

### Procedural vs Object-Oriented Programming

```csharp
// PROCEDURAL APPROACH (Functions and data separate)
string studentName = "Raj";
int studentAge = 20;
double studentMarks = 85.5;

void DisplayStudent(string name, int age, double marks)
{
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Marks: {marks}");
}

DisplayStudent(studentName, studentAge, studentMarks);

// OBJECT-ORIENTED APPROACH (Data and functions together)
class Student
{
    public string Name;
    public int Age;
    public double Marks;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Marks: {Marks}");
    }
}

Student student = new Student();
student.Name = "Raj";
student.Age = 20;
student.Marks = 85.5;
student.Display();
```

### The Four Pillars of OOP

```
┌─────────────────────────────────────┐
│     FOUR PILLARS OF OOP             │
├─────────────────────────────────────┤
│                                     │
│  1. ENCAPSULATION                   │
│     └─ Bundling data and methods    │
│        Hiding internal details      │
│                                     │
│  2. INHERITANCE                     │
│     └─ Creating new classes from    │
│        existing ones                │
│        Code reuse                   │
│                                     │
│  3. POLYMORPHISM                    │
│     └─ Same interface, different    │
│        implementations              │
│        Flexibility                  │
│                                     │
│  4. ABSTRACTION                     │
│     └─ Hiding complexity            │
│        Showing only essentials      │
│                                     │
└─────────────────────────────────────┘
```

#### **1. Encapsulation**

**Definition:** Bundling data (fields) and methods that work on that data into a single unit (class), and hiding internal details.

**Example:**
```csharp
class BankAccount
{
    // Private fields (hidden from outside)
    private double balance;

    // Public methods (controlled access)
    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

// Usage
BankAccount account = new BankAccount();
account.Deposit(1000);
Console.WriteLine(account.GetBalance());  // 1000
// account.balance = -500;  // ERROR! Can't access private field
```

**Benefits:**
- Data protection
- Controlled access
- Flexibility to change implementation
- Validation of data

#### **2. Inheritance**

**Definition:** Creating new classes based on existing classes, inheriting their properties and methods.

**Example:**
```csharp
// Base class (Parent)
class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}

// Derived class (Child)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking");
    }
}

// Usage
Dog dog = new Dog();
dog.Name = "Buddy";
dog.Eat();   // Inherited from Animal
dog.Bark();  // Own method
```

**Benefits:**
- Code reusability
- Logical hierarchy
- Method overriding
- Extensibility

#### **3. Polymorphism**

**Definition:** Same interface, multiple implementations. "Many forms" - same method behaving differently.

**Example:**
```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow!");
    }
}

// Usage - Same method, different behavior
Animal animal1 = new Dog();
Animal animal2 = new Cat();

animal1.MakeSound();  // Dog barks: Woof!
animal2.MakeSound();  // Cat meows: Meow!
```

**Benefits:**
- Flexibility
- Code reusability
- Easier maintenance
- Interface consistency

#### **4. Abstraction**

**Definition:** Hiding complex implementation details and showing only essential features.

**Example:**
```csharp
abstract class Vehicle
{
    // Abstract method (no implementation)
    public abstract void Start();

    // Concrete method
    public void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car started with key");
    }
}

class Motorcycle : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Motorcycle started with button");
    }
}

// Usage
Vehicle car = new Car();
car.Start();  // Car started with key
car.Stop();   // Vehicle stopped
```

**Benefits:**
- Reduces complexity
- Focuses on "what" not "how"
- Easier to maintain
- Better security

---

## 📚 Topic 7.2: Classes and Objects - Creating and Instantiating

### What is a Class?

A **class** is a blueprint or template that defines the structure and behavior of objects.

**Analogy:**
- **Class** = Architectural blueprint of a house
- **Object** = The actual house built from the blueprint

### Class Syntax

```csharp
class ClassName
{
    // Fields (data members)
    // Properties
    // Methods (functions)
    // Constructors
}
```

### Creating a Simple Class

```csharp
// Define a class
class Student
{
    // Fields (data)
    public string Name;
    public int Age;
    public int RollNumber;

    // Method (behavior)
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Roll Number: {RollNumber}");
    }
}
```

### What is an Object?

An **object** is an instance of a class. It's the actual entity created from the class blueprint.

**Creating Objects (Instantiation):**

```csharp
// Syntax: ClassName objectName = new ClassName();

// Example 1: Create a Student object
Student student1 = new Student();

// Example 2: Using var
var student2 = new Student();

// Example 3: Object initializer (C# 3.0+)
Student student3 = new Student
{
    Name = "Raj",
    Age = 20,
    RollNumber = 101
};
```

### Working with Objects

```csharp
class Student
{
    public string Name;
    public int Age;
    public int RollNumber;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Roll: {RollNumber}");
    }
}

// Create and use objects
Student student1 = new Student();
student1.Name = "Raj Kumar";
student1.Age = 20;
student1.RollNumber = 101;
student1.DisplayInfo();

Student student2 = new Student();
student2.Name = "Priya Sharma";
student2.Age = 19;
student2.RollNumber = 102;
student2.DisplayInfo();

// Output:
// Name: Raj Kumar
// Age: 20
// Roll: 101
// Name: Priya Sharma
// Age: 19
// Roll: 102
```

### Multiple Objects from Same Class

```csharp
// One class can create many objects
Student s1 = new Student { Name = "Raj", Age = 20, RollNumber = 101 };
Student s2 = new Student { Name = "Priya", Age = 19, RollNumber = 102 };
Student s3 = new Student { Name = "Amit", Age = 21, RollNumber = 103 };

// Each object is independent
s1.DisplayInfo();
s2.DisplayInfo();
s3.DisplayInfo();
```

### Complete Class Example - Calculator

```csharp
class Calculator
{
    // Fields
    public double Result;

    // Methods
    public void Add(double a, double b)
    {
        Result = a + b;
    }

    public void Subtract(double a, double b)
    {
        Result = a - b;
    }

    public void Multiply(double a, double b)
    {
        Result = a * b;
    }

    public void Divide(double a, double b)
    {
        if (b != 0)
            Result = a / b;
        else
            Console.WriteLine("Cannot divide by zero!");
    }

    public void DisplayResult()
    {
        Console.WriteLine($"Result: {Result}");
    }
}

// Usage
Calculator calc = new Calculator();
calc.Add(10, 5);
calc.DisplayResult();  // Result: 15

calc.Multiply(3, 4);
calc.DisplayResult();  // Result: 12
```

---

## 📚 Topic 7.3: Fields, Properties, and Constructors

### Fields

**Fields** are variables declared at class level. They store data for each object.

```csharp
class Person
{
    // Public fields (accessible from outside)
    public string Name;
    public int Age;

    // Private fields (accessible only within class)
    private double salary;

    // Protected fields (accessible in derived classes)
    protected string address;
}
```

#### **Field Initialization**

```csharp
class Student
{
    // Initialize at declaration
    public string Name = "Unknown";
    public int Age = 0;
    public bool IsActive = true;

    // Will be initialized when object is created
    public int RollNumber;
}

Student s = new Student();
Console.WriteLine(s.Name);      // Unknown
Console.WriteLine(s.IsActive);  // True
```

### Properties

**Properties** provide controlled access to fields with get and set accessors.

#### **Why Use Properties?**

1. **Validation** - Check values before setting
2. **Encapsulation** - Hide internal representation
3. **Computed values** - Calculate on-the-fly
4. **Read-only or write-only** - Control access

#### **Property Syntax**

```csharp
class Student
{
    // Private field
    private int age;

    // Public property
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 120)
                age = value;
            else
                Console.WriteLine("Invalid age!");
        }
    }
}

// Usage
Student s = new Student();
s.Age = 20;           // Calls set accessor
Console.WriteLine(s.Age);  // Calls get accessor

s.Age = -5;           // Validation prevents invalid value
```

#### **Auto-Implemented Properties**

```csharp
class Student
{
    // Auto-implemented properties (C# 3.0+)
    public string Name { get; set; }
    public int Age { get; set; }
    public int RollNumber { get; set; }
}

// Equivalent to:
class Student
{
    private string name;
    private int age;
    private int rollNumber;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    // ... and so on
}
```

#### **Read-Only Properties**

```csharp
class Student
{
    // Read-only (only get accessor)
    public string University { get; } = "Tech University";

    // Calculated property
    private int birthYear;
    public int Age
    {
        get { return DateTime.Now.Year - birthYear; }
    }

    public Student(int year)
    {
        birthYear = year;
    }
}

Student s = new Student(2003);
Console.WriteLine(s.Age);        // Calculated: 22 (if current year is 2025)
Console.WriteLine(s.University); // Tech University
// s.University = "New University";  // ERROR! Read-only
```

#### **Property Examples**

```csharp
class BankAccount
{
    private double balance;

    // Property with validation
    public double Balance
    {
        get { return balance; }
        private set  // Private setter - can only be set internally
        {
            if (value >= 0)
                balance = value;
        }
    }

    // Read-only property
    public string AccountNumber { get; }

    // Auto-property with default value
    public string AccountType { get; set; } = "Savings";

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }
}

// Usage
BankAccount account = new BankAccount("ACC001");
account.Deposit(1000);
Console.WriteLine(account.Balance);     // 1000
Console.WriteLine(account.AccountType); // Savings
```

### Constructors

**Constructors** are special methods that initialize objects when they're created.

#### **Characteristics:**
- Same name as class
- No return type (not even void)
- Called automatically when object is created
- Used to initialize fields/properties

#### **Default Constructor**

```csharp
class Student
{
    public string Name;
    public int Age;

    // Default constructor (no parameters)
    public Student()
    {
        Name = "Unknown";
        Age = 0;
        Console.WriteLine("Student object created");
    }
}

// Usage
Student s = new Student();  // Constructor called automatically
// Output: Student object created
Console.WriteLine(s.Name);  // Unknown
```

#### **Parameterized Constructor**

```csharp
class Student
{
    public string Name;
    public int Age;
    public int RollNumber;

    // Constructor with parameters
    public Student(string name, int age, int roll)
    {
        Name = name;
        Age = age;
        RollNumber = roll;
    }
}

// Usage
Student s = new Student("Raj", 20, 101);
Console.WriteLine(s.Name);  // Raj
```

#### **Constructor Overloading**

```csharp
class Student
{
    public string Name;
    public int Age;
    public int RollNumber;

    // Constructor 1: No parameters
    public Student()
    {
        Name = "Unknown";
        Age = 0;
        RollNumber = 0;
    }

    // Constructor 2: Name only
    public Student(string name)
    {
        Name = name;
        Age = 0;
        RollNumber = 0;
    }

    // Constructor 3: All parameters
    public Student(string name, int age, int roll)
    {
        Name = name;
        Age = age;
        RollNumber = roll;
    }
}

// Usage - Different ways to create objects
Student s1 = new Student();                    // Uses constructor 1
Student s2 = new Student("Raj");               // Uses constructor 2
Student s3 = new Student("Priya", 19, 102);    // Uses constructor 3
```

#### **Constructor Chaining (this keyword)**

```csharp
class Student
{
    public string Name;
    public int Age;
    public int RollNumber;

    // Main constructor
    public Student(string name, int age, int roll)
    {
        Name = name;
        Age = age;
        RollNumber = roll;
    }

    // Constructor calling another constructor
    public Student(string name) : this(name, 0, 0)
    {
        // Calls the main constructor with default values
    }

    public Student() : this("Unknown")
    {
        // Calls the second constructor
    }
}

// Usage
Student s1 = new Student();           // Unknown, 0, 0
Student s2 = new Student("Raj");      // Raj, 0, 0
Student s3 = new Student("Priya", 19, 102);  // Priya, 19, 102
```

#### **Static Constructor**

```csharp
class Configuration
{
    public static string AppName;
    public static string Version;

    // Static constructor (runs once, before any instance is created)
    static Configuration()
    {
        AppName = "Student Management System";
        Version = "1.0.0";
        Console.WriteLine("Configuration initialized");
    }

    public Configuration()
    {
        Console.WriteLine("Instance created");
    }
}

// Usage
Configuration c1 = new Configuration();
Configuration c2 = new Configuration();
// Output:
// Configuration initialized  (only once)
// Instance created
// Instance created
```

### Complete Example - Student Class

```csharp
class Student
{
    // Private fields
    private string name;
    private int age;
    private double marks;

    // Properties with validation
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 5 && value <= 100)
                age = value;
        }
    }

    public double Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
        }
    }

    // Read-only property (calculated)
    public string Grade
    {
        get
        {
            if (Marks >= 90) return "A";
            else if (Marks >= 80) return "B";
            else if (Marks >= 70) return "C";
            else if (Marks >= 60) return "D";
            else return "F";
        }
    }

    // Auto-property
    public int RollNumber { get; set; }

    // Constructors
    public Student()
    {
        Name = "Unknown";
        Age = 0;
        Marks = 0;
        RollNumber = 0;
    }

    public Student(string name, int age, double marks, int roll)
    {
        Name = name;
        Age = age;
        Marks = marks;
        RollNumber = roll;
    }

    // Methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Roll: {RollNumber}");
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Grade: {Grade}");
    }

    public bool IsPassed()
    {
        return Marks >= 40;
    }
}

// Usage
Student s1 = new Student("Raj Kumar", 20, 85.5, 101);
s1.DisplayInfo();
Console.WriteLine($"Passed: {s1.IsPassed()}");

// Test validation
s1.Age = -5;  // Validation prevents invalid value
Console.WriteLine($"Age: {s1.Age}");  // Still 20
```

---

## 📚 Topic 7.4: The this Keyword

### What is 'this'?

The **this** keyword refers to the current instance of the class. It's used to:
1. Distinguish between class fields and parameters
2. Call other constructors
3. Pass current object as parameter
4. Return current object from method

### 1. Distinguishing Fields from Parameters

```csharp
class Student
{
    private string name;
    private int age;

    // Parameter names same as field names
    public Student(string name, int age)
    {
        this.name = name;  // this.name is field, name is parameter
        this.age = age;    // this.age is field, age is parameter
    }

    public void SetInfo(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
```

### 2. Constructor Chaining

```csharp
class Employee
{
    public string Name;
    public int Age;
    public double Salary;

    // Main constructor
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    // Constructor calling main constructor
    public Employee(string name, int age) : this(name, age, 0.0)
    {
        // Additional logic if needed
    }

    public Employee(string name) : this(name, 0, 0.0)
    {
    }
}

// Usage
Employee e1 = new Employee("Raj", 25, 50000);
Employee e2 = new Employee("Priya", 23);      // Salary defaults to 0
Employee e3 = new Employee("Amit");           // Age and Salary default to 0
```

### 3. Passing Current Object

```csharp
class Student
{
    public string Name;
    public int Age;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void CompareAge(Student other)
    {
        if (this.Age > other.Age)
            Console.WriteLine($"{this.Name} is older");
        else
            Console.WriteLine($"{other.Name} is older");
    }
}

// Usage
Student s1 = new Student("Raj", 20);
Student s2 = new Student("Priya", 19);

s1.CompareAge(s2);  // Raj is older
```

### 4. Method Chaining (Fluent Interface)

```csharp
class StudentBuilder
{
    private string name;
    private int age;
    private int rollNumber;

    public StudentBuilder SetName(string name)
    {
        this.name = name;
        return this;  // Return current object
    }

    public StudentBuilder SetAge(int age)
    {
        this.age = age;
        return this;
    }

    public StudentBuilder SetRollNumber(int roll)
    {
        this.rollNumber = roll;
        return this;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Roll: {rollNumber}");
    }
}

// Usage - Method chaining
StudentBuilder builder = new StudentBuilder()
    .SetName("Raj")
    .SetAge(20)
    .SetRollNumber(101);

builder.Display();
// Output: Name: Raj, Age: 20, Roll: 101
```

### Complete Example with 'this'

```csharp
class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    // Constructor using this for parameters
    public BankAccount(string accountNumber, string holderName, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = initialBalance;
    }

    // Constructor chaining using this
    public BankAccount(string accountNumber, string holderName)
        : this(accountNumber, holderName, 0.0)
    {
    }

    // Method using this for clarity
    public void Transfer(BankAccount destination, double amount)
    {
        if (this.balance >= amount)
        {
            this.balance -= amount;
            destination.balance += amount;
            Console.WriteLine($"Transferred {amount} from {this.holderName} to {destination.holderName}");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    // Method chaining using this
    public BankAccount Deposit(double amount)
    {
        this.balance += amount;
        return this;
    }

    public BankAccount Withdraw(double amount)
    {
        if (this.balance >= amount)
            this.balance -= amount;
        return this;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Account: {this.accountNumber}");
        Console.WriteLine($"Holder: {this.holderName}");
        Console.WriteLine($"Balance: ₹{this.balance}");
    }
}

// Usage
BankAccount acc1 = new BankAccount("ACC001", "Raj", 5000);
BankAccount acc2 = new BankAccount("ACC002", "Priya");

// Method chaining
acc1.Deposit(1000).Withdraw(500).Deposit(200);
acc1.DisplayInfo();

// Transfer between accounts
acc1.Transfer(acc2, 1000);
acc2.DisplayInfo();
```

---

## 🎯 Student Tasks & Practice

### Task 1: Create a Book Class
```csharp
// Create a Book class with:
// - Properties: Title, Author, ISBN, Price, Pages
// - Constructor to initialize all properties
// - Method DisplayInfo()
// - Method ApplyDiscount(double percentage)
// - Property IsExpensive (read-only, true if price > 500)
```

### Task 2: Rectangle Class
```csharp
// Create a Rectangle class with:
// - Properties: Length, Width
// - Constructor with validation (positive values only)
// - Method CalculateArea()
// - Method CalculatePerimeter()
// - Method IsSquare() - returns bool
// - Override constructors for different scenarios
```

### Task 3: Bank Account System
```csharp
// Create BankAccount class with:
// - Private fields: accountNumber, balance, holderName
// - Properties with appropriate access levels
// - Methods: Deposit, Withdraw, Transfer
// - Method GetStatement() to display account info
// - Validation: balance cannot be negative
```

### Task 4: Student Management
```csharp
// Create Student class with:
// - Auto-properties: Name, RollNumber
// - Property Marks with validation (0-100)
// - Read-only property Grade (calculated from marks)
// - Constructor overloading (default, with name, with all params)
// - Method DisplayReport()
// - Static property to count total students created
```

### Task 5: Product Inventory
```csharp
// Create Product class with:
// - Properties: ProductID, Name, Price, Stock
// - Constructor with 'this' keyword
// - Method AddStock(int quantity)
// - Method SellProduct(int quantity) - reduce stock
// - Method ApplyDiscount(double percent)
// - Method IsInStock() - returns bool
// - Validation: Price and Stock cannot be negative
```

---

## 🧠 Quick Quiz

**Q1:** What is the difference between a class and an object?
<details>
<summary>Answer</summary>
A class is a blueprint/template, while an object is an instance created from that class.
</details>

**Q2:** What are the four pillars of OOP?
<details>
<summary>Answer</summary>
Encapsulation, Inheritance, Polymorphism, and Abstraction
</details>

**Q3:** What is a constructor?
<details>
<summary>Answer</summary>
A special method with the same name as the class, used to initialize objects when created. Has no return type.
</details>

**Q4:** What is the difference between a field and a property?
<details>
<summary>Answer</summary>
Fields are variables; properties are methods (get/set accessors) that provide controlled access to fields.
</details>

**Q5:** What does the 'this' keyword refer to?
<details>
<summary>Answer</summary>
The current instance of the class
</details>

**Q6:** Can a constructor have a return type?
<details>
<summary>Answer</summary>
No, constructors never have a return type, not even void.
</details>

**Q7:** What is constructor overloading?
<details>
<summary>Answer</summary>
Having multiple constructors in the same class with different parameters.
</details>

**Q8:** What is an auto-implemented property?
<details>
<summary>Answer</summary>
A property with simplified syntax where the compiler automatically creates the backing field: public string Name { get; set; }
</details>

**Q9:** Can you create a read-only property?
<details>
<summary>Answer</summary>
Yes, by having only a get accessor: public string Name { get; }
</details>

**Q10:** What is encapsulation?
<details>
<summary>Answer</summary>
Bundling data and methods together in a class and hiding internal details using access modifiers.
</details>

---

## 📖 Key Takeaways

✅ **OOP** organizes code around objects that represent real-world entities

✅ **Four Pillars**: Encapsulation, Inheritance, Polymorphism, Abstraction

✅ **Class** is a blueprint; **Object** is an instance of a class

✅ **Fields** store data; **Properties** provide controlled access with validation

✅ **Constructors** initialize objects when created; can be overloaded

✅ **this** keyword refers to the current instance of the class

✅ **Auto-properties** simplify property declaration

✅ **Properties** can be read-only, write-only, or read-write

✅ **Constructor chaining** uses this() to call other constructors

✅ **Encapsulation** protects data using private fields and public properties

---

## 🔗 Additional Resources

- [C# Classes and Objects](https://docs.microsoft.com/dotnet/csharp/fundamentals/types/classes)
- [Properties in C#](https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/properties)
- [Constructors](https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- [OOP Concepts](https://docs.microsoft.com/dotnet/csharp/fundamentals/object-oriented/)

---

**
