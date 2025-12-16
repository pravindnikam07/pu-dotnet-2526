# Methods, Arrays, and Collections

## 📚 Topic 6.1: Defining and Calling Methods

### What is a Method?

A **method** is a block of code that performs a specific task. Methods help organize code, promote reusability, and make programs easier to understand and maintain.

**Simple Analogy:**
Think of methods like recipes in a cookbook:
- **Recipe name** = Method name
- **Ingredients** = Parameters
- **Cooking steps** = Method body
- **Final dish** = Return value

### Why Use Methods?

1. **Code Reusability** - Write once, use many times
2. **Organization** - Break large problems into smaller pieces
3. **Maintainability** - Easier to update and fix
4. **Readability** - Clear, descriptive names
5. **Testing** - Test individual pieces separately

### Method Syntax

```csharp
accessModifier returnType MethodName(parameters)
{
    // Method body
    // Code to execute
    return value;  // If returnType is not void
}
```

**Components:**
- **Access Modifier**: public, private, protected, internal
- **Return Type**: Data type of value returned (or void for no return)
- **Method Name**: Descriptive name (PascalCase)
- **Parameters**: Input values (optional)
- **Method Body**: Code to execute
- **Return Statement**: Returns value (if not void)

### Simple Methods (No Parameters, No Return)

```csharp
// Example 1: Simple greeting
static void SayHello()
{
    Console.WriteLine("Hello, World!");
}

// Calling the method
SayHello();
// Output: Hello, World!

// Example 2: Print separator
static void PrintSeparator()
{
    Console.WriteLine("=========================");
}

// Usage
PrintSeparator();
Console.WriteLine("Welcome");
PrintSeparator();
// Output:
// =========================
// Welcome
// =========================

// Example 3: Display menu
static void DisplayMenu()
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Exit");
}

DisplayMenu();
```

### Methods with Parameters

Parameters allow you to pass data to methods.

```csharp
// Example 1: Personalized greeting
static void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

// Calling with argument
Greet("Raj");      // Output: Hello, Raj!
Greet("Priya");    // Output: Hello, Priya!

// Example 2: Multiple parameters
static void DisplayInfo(string name, int age)
{
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
}

DisplayInfo("Raj", 20);
// Output:
// Name: Raj
// Age: 20

// Example 3: Calculate area of rectangle
static void PrintRectangleArea(double length, double width)
{
    double area = length * width;
    Console.WriteLine($"Area: {area}");
}

PrintRectangleArea(10.5, 5.2);
// Output: Area: 54.6

// Example 4: Check even/odd
static void CheckEvenOdd(int number)
{
    if (number % 2 == 0)
        Console.WriteLine($"{number} is even");
    else
        Console.WriteLine($"{number} is odd");
}

CheckEvenOdd(7);   // Output: 7 is odd
CheckEvenOdd(10);  // Output: 10 is even
```

### Methods with Return Values

Methods can return a value using the `return` statement.

```csharp
// Example 1: Return sum
static int Add(int a, int b)
{
    int sum = a + b;
    return sum;
}

// Using the returned value
int result = Add(5, 3);
Console.WriteLine(result);  // Output: 8

// Can use directly in expressions
Console.WriteLine(Add(10, 20));  // Output: 30

// Example 2: Return boolean
static bool IsEven(int number)
{
    return number % 2 == 0;
}

if (IsEven(10))
{
    Console.WriteLine("Even number");
}

// Example 3: Return string
static string GetGrade(int marks)
{
    if (marks >= 90)
        return "A";
    else if (marks >= 80)
        return "B";
    else if (marks >= 70)
        return "C";
    else if (marks >= 60)
        return "D";
    else
        return "F";
}

string grade = GetGrade(85);
Console.WriteLine($"Grade: {grade}");  // Output: Grade: B

// Example 4: Calculate and return
static double CalculateCircleArea(double radius)
{
    const double PI = 3.14159;
    return PI * radius * radius;
}

double area = CalculateCircleArea(5.0);
Console.WriteLine($"Area: {area:F2}");  // Output: Area: 78.54
```

### Complete Example - Calculator

```csharp
using System;

class Calculator
{
    // Method without return value
    static void DisplayWelcome()
    {
        Console.WriteLine("=== Simple Calculator ===");
        Console.WriteLine();
    }

    // Methods with return values
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return 0;
        }
        return a / b;
    }

    // Method to display result
    static void ShowResult(double result)
    {
        Console.WriteLine($"Result: {result}");
    }

    static void Main()
    {
        DisplayWelcome();

        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;

        switch (operation)
        {
            case '+':
                result = Add(num1, num2);
                break;
            case '-':
                result = Subtract(num1, num2);
                break;
            case '*':
                result = Multiply(num1, num2);
                break;
            case '/':
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation!");
                return;
        }

        ShowResult(result);
    }
}
```

### Parameter Passing

#### **1. Pass by Value (Default)**
A copy of the value is passed. Changes don't affect the original.

```csharp
static void Increment(int number)
{
    number = number + 1;
    Console.WriteLine($"Inside method: {number}");
}

int x = 5;
Increment(x);
Console.WriteLine($"Outside method: {x}");
// Output:
// Inside method: 6
// Outside method: 5  (unchanged)
```

#### **2. Pass by Reference (ref keyword)**
The original variable is passed. Changes affect the original.

```csharp
static void Increment(ref int number)
{
    number = number + 1;
    Console.WriteLine($"Inside method: {number}");
}

int x = 5;
Increment(ref x);  // Must use 'ref' when calling
Console.WriteLine($"Outside method: {x}");
// Output:
// Inside method: 6
// Outside method: 6  (changed!)

// Example 2: Swap two numbers
static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

int x = 10, y = 20;
Console.WriteLine($"Before: x={x}, y={y}");
Swap(ref x, ref y);
Console.WriteLine($"After: x={x}, y={y}");
// Output:
// Before: x=10, y=20
// After: x=20, y=10
```

#### **3. Out Parameters (out keyword)**
Used to return multiple values from a method.

```csharp
static void GetMinMax(int[] numbers, out int min, out int max)
{
    min = numbers[0];
    max = numbers[0];

    foreach (int num in numbers)
    {
        if (num < min) min = num;
        if (num > max) max = num;
    }
}

int[] values = { 5, 2, 9, 1, 7 };
GetMinMax(values, out int minimum, out int maximum);
Console.WriteLine($"Min: {minimum}, Max: {maximum}");
// Output: Min: 1, Max: 9

// Example 2: Division with remainder
static void DivideWithRemainder(int dividend, int divisor, out int quotient, out int remainder)
{
    quotient = dividend / divisor;
    remainder = dividend % divisor;
}

DivideWithRemainder(17, 5, out int q, out int r);
Console.WriteLine($"17 ÷ 5 = {q} remainder {r}");
// Output: 17 ÷ 5 = 3 remainder 2
```

### Optional Parameters

Parameters can have default values.

```csharp
// Example 1: Optional parameter
static void Greet(string name, string greeting = "Hello")
{
    Console.WriteLine($"{greeting}, {name}!");
}

Greet("Raj");                    // Output: Hello, Raj!
Greet("Raj", "Good morning");    // Output: Good morning, Raj!

// Example 2: Calculate power (default exponent = 2)
static double Power(double baseNum, int exponent = 2)
{
    return Math.Pow(baseNum, exponent);
}

Console.WriteLine(Power(5));      // 5^2 = 25
Console.WriteLine(Power(5, 3));   // 5^3 = 125

// Example 3: Display info with optional age
static void DisplayPerson(string name, int age = 0)
{
    Console.Write($"Name: {name}");
    if (age > 0)
        Console.WriteLine($", Age: {age}");
    else
        Console.WriteLine();
}

DisplayPerson("Raj");           // Name: Raj
DisplayPerson("Priya", 22);     // Name: Priya, Age: 22
```

### Named Arguments

You can specify parameter names when calling methods.

```csharp
static void CreateAccount(string username, string email, int age)
{
    Console.WriteLine($"Username: {username}");
    Console.WriteLine($"Email: {email}");
    Console.WriteLine($"Age: {age}");
}

// Positional arguments
CreateAccount("raj123", "raj@email.com", 20);

// Named arguments (any order)
CreateAccount(
    age: 20,
    email: "raj@email.com",
    username: "raj123"
);

// Mix of positional and named
CreateAccount("raj123", age: 20, email: "raj@email.com");
```

### Method Overloading

Multiple methods with the same name but different parameters.

```csharp
// Overloaded Add methods
static int Add(int a, int b)
{
    return a + b;
}

static double Add(double a, double b)
{
    return a + b;
}

static int Add(int a, int b, int c)
{
    return a + b + c;
}

// Usage
Console.WriteLine(Add(5, 3));           // Calls int version
Console.WriteLine(Add(5.5, 3.2));       // Calls double version
Console.WriteLine(Add(1, 2, 3));        // Calls three-parameter version

// Example 2: Area calculations
static double CalculateArea(double radius)  // Circle
{
    return 3.14159 * radius * radius;
}

static double CalculateArea(double length, double width)  // Rectangle
{
    return length * width;
}

static double CalculateArea(double baseLen, double height, bool isTriangle)  // Triangle
{
    return 0.5 * baseLen * height;
}

Console.WriteLine(CalculateArea(5));           // Circle
Console.WriteLine(CalculateArea(10, 5));       // Rectangle
Console.WriteLine(CalculateArea(10, 5, true)); // Triangle
```

---

## 📚 Topic 6.2: Single-Dimensional and Multi-Dimensional Arrays

### What is an Array?

An **array** is a collection of elements of the same data type stored in contiguous memory locations.

**Simple Analogy:**
Think of an array like a row of lockers:
- Each locker has a number (index)
- All lockers are the same size (same data type)
- Lockers are side by side (contiguous memory)

### Single-Dimensional Arrays

#### **Declaration and Initialization**

```csharp
// Method 1: Declare then initialize
int[] numbers;
numbers = new int[5];  // Array of 5 integers

// Method 2: Declare and allocate in one line
int[] numbers = new int[5];

// Method 3: Declare and initialize with values
int[] numbers = new int[] { 10, 20, 30, 40, 50 };

// Method 4: Simplified initialization
int[] numbers = { 10, 20, 30, 40, 50 };

// Method 5: Using var
var numbers = new int[] { 10, 20, 30, 40, 50 };
```

#### **Accessing Array Elements**

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

// Access by index (0-based)
Console.WriteLine(numbers[0]);  // 10
Console.WriteLine(numbers[2]);  // 30
Console.WriteLine(numbers[4]);  // 50

// Modify elements
numbers[1] = 25;
Console.WriteLine(numbers[1]);  // 25

// Array length
Console.WriteLine($"Length: {numbers.Length}");  // 5

// Last element
Console.WriteLine(numbers[numbers.Length - 1]);  // 50
```

#### **Array Operations**

```csharp
// Example 1: Fill array with values
int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i * 10;
}
// Result: [0, 10, 20, 30, 40]

// Example 2: Display array
int[] scores = { 85, 90, 78, 92, 88 };
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Score {i + 1}: {scores[i]}");
}

// Example 3: Sum of array elements
int[] values = { 5, 10, 15, 20, 25 };
int sum = 0;
for (int i = 0; i < values.Length; i++)
{
    sum += values[i];
}
Console.WriteLine($"Sum: {sum}");  // 75

// Example 4: Find maximum
int[] numbers = { 23, 45, 12, 67, 34 };
int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine($"Maximum: {max}");  // 67

// Example 5: Find minimum
int min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Minimum: {min}");  // 12

// Example 6: Search for element
int[] data = { 10, 20, 30, 40, 50 };
int searchFor = 30;
int foundIndex = -1;

for (int i = 0; i < data.Length; i++)
{
    if (data[i] == searchFor)
    {
        foundIndex = i;
        break;
    }
}

if (foundIndex != -1)
    Console.WriteLine($"Found at index {foundIndex}");
else
    Console.WriteLine("Not found");
```

#### **Array Methods**

```csharp
int[] numbers = { 50, 20, 40, 10, 30 };

// Sort array
Array.Sort(numbers);
// Result: [10, 20, 30, 40, 50]

// Reverse array
Array.Reverse(numbers);
// Result: [50, 40, 30, 20, 10]

// Find index of element
int index = Array.IndexOf(numbers, 30);
Console.WriteLine($"Index of 30: {index}");

// Clear array (set to default values)
Array.Clear(numbers, 0, numbers.Length);
// Result: [0, 0, 0, 0, 0]

// Copy array
int[] source = { 1, 2, 3, 4, 5 };
int[] destination = new int[5];
Array.Copy(source, destination, source.Length);

// Clone array
int[] original = { 1, 2, 3 };
int[] clone = (int[])original.Clone();
```

### Multi-Dimensional Arrays

#### **2D Arrays (Matrices)**

```csharp
// Declaration and initialization
int[,] matrix = new int[3, 4];  // 3 rows, 4 columns

// Initialize with values
int[,] matrix = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }
};

// Access elements
Console.WriteLine(matrix[0, 0]);  // 1
Console.WriteLine(matrix[1, 2]);  // 7
Console.WriteLine(matrix[2, 3]);  // 12

// Modify elements
matrix[1, 1] = 99;

// Get dimensions
int rows = matrix.GetLength(0);     // 3
int columns = matrix.GetLength(1);  // 4

// Traverse 2D array
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
// Output:
// 1 2 3 4
// 5 99 7 8
// 9 10 11 12
```

#### **Practical 2D Array Examples**

```csharp
// Example 1: Student marks (students × subjects)
int[,] marks = {
    { 85, 90, 78 },  // Student 1
    { 92, 88, 95 },  // Student 2
    { 76, 82, 88 }   // Student 3
};

// Calculate average for each student
for (int i = 0; i < marks.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < marks.GetLength(1); j++)
    {
        sum += marks[i, j];
    }
    double average = sum / (double)marks.GetLength(1);
    Console.WriteLine($"Student {i + 1} average: {average:F2}");
}

// Example 2: Tic-Tac-Toe board
char[,] board = {
    { 'X', 'O', 'X' },
    { 'O', 'X', 'O' },
    { 'O', 'X', 'X' }
};

// Display board
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{board[i, j]} ");
    }
    Console.WriteLine();
}

// Example 3: Matrix addition
int[,] matrix1 = {
    { 1, 2, 3 },
    { 4, 5, 6 }
};

int[,] matrix2 = {
    { 7, 8, 9 },
    { 10, 11, 12 }
};

int[,] sum = new int[2, 3];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        sum[i, j] = matrix1[i, j] + matrix2[i, j];
    }
}

// Display result
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{sum[i, j]} ");
    }
    Console.WriteLine();
}
// Output:
// 8 10 12
// 14 16 18
```

#### **Jagged Arrays (Array of Arrays)**

Unlike 2D arrays, jagged arrays can have rows of different lengths.

```csharp
// Declaration
int[][] jaggedArray = new int[3][];

// Initialize each row with different sizes
jaggedArray[0] = new int[] { 1, 2, 3, 4 };       // 4 elements
jaggedArray[1] = new int[] { 5, 6 };             // 2 elements
jaggedArray[2] = new int[] { 7, 8, 9 };          // 3 elements

// Or initialize directly
int[][] jaggedArray = {
    new int[] { 1, 2, 3, 4 },
    new int[] { 5, 6 },
    new int[] { 7, 8, 9 }
};

// Access elements
Console.WriteLine(jaggedArray[0][2]);  // 3
Console.WriteLine(jaggedArray[1][1]);  // 6

// Traverse jagged array
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($"{jaggedArray[i][j]} ");
    }
    Console.WriteLine();
}
// Output:
// 1 2 3 4
// 5 6
// 7 8 9
```

---

## 📚 Topic 6.3: Introduction to Collections - List<T>

### What is a List?

**List<T>** is a dynamic collection that can grow or shrink in size. Unlike arrays, you don't need to specify the size upfront.

**Key Differences from Arrays:**
- **Arrays**: Fixed size, faster access
- **Lists**: Dynamic size, more flexible

### Creating and Using Lists

```csharp
using System.Collections.Generic;

// Create empty list
List<int> numbers = new List<int>();

// Create with initial capacity
List<string> names = new List<string>(10);

// Create and initialize with values
List<int> scores = new List<int> { 85, 90, 78, 92 };

// Using var
var cities = new List<string> { "Mumbai", "Delhi", "Bangalore" };
```

### List Operations

#### **Adding Elements**

```csharp
List<int> numbers = new List<int>();

// Add single element
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
// List: [10, 20, 30]

// Add multiple elements
numbers.AddRange(new int[] { 40, 50, 60 });
// List: [10, 20, 30, 40, 50, 60]

// Insert at specific position
numbers.Insert(0, 5);  // Insert 5 at index 0
// List: [5, 10, 20, 30, 40, 50, 60]

// Insert multiple at position
numbers.InsertRange(2, new int[] { 15, 17 });
// List: [5, 10, 15, 17, 20, 30, 40, 50, 60]
```

#### **Accessing Elements**

```csharp
List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

// Access by index
Console.WriteLine(fruits[0]);  // Apple
Console.WriteLine(fruits[2]);  // Cherry

// Modify element
fruits[1] = "Blueberry";
Console.WriteLine(fruits[1]);  // Blueberry

// Get count
Console.WriteLine($"Count: {fruits.Count}");  // 3

// Check if empty
if (fruits.Count == 0)
    Console.WriteLine("List is empty");
```

#### **Removing Elements**

```csharp
List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

// Remove specific element
numbers.Remove(30);  // Removes first occurrence
// List: [10, 20, 40, 50]

// Remove at index
numbers.RemoveAt(0);  // Remove first element
// List: [20, 40, 50]

// Remove range
numbers.RemoveRange(0, 2);  // Remove 2 elements starting at index 0
// List: [50]

// Remove all elements matching condition
List<int> values = new List<int> { 5, 10, 15, 20, 25 };
values.RemoveAll(x => x < 15);  // Remove all values less than 15
// List: [15, 20, 25]

// Clear all elements
numbers.Clear();
// List: []
```

#### **Searching in Lists**

```csharp
List<string> names = new List<string> { "Raj", "Priya", "Amit", "Sneha" };

// Check if exists
bool hasRaj = names.Contains("Raj");
Console.WriteLine(hasRaj);  // True

// Find index
int index = names.IndexOf("Amit");
Console.WriteLine($"Index: {index}");  // 2

// Find last index (if duplicates)
List<int> numbers = new List<int> { 10, 20, 10, 30, 10 };
int lastIndex = numbers.LastIndexOf(10);
Console.WriteLine(lastIndex);  // 4

// Find element
List<int> scores = new List<int> { 85, 90, 78, 92, 88 };
int highScore = scores.Find(x => x > 90);
Console.WriteLine(highScore);  // 92 (first match)

// Find all elements
List<int> highScores = scores.FindAll(x => x >= 85);
// Result: [85, 90, 92, 88]

// Check if any element matches
bool hasHighScore = scores.Exists(x => x > 95);
Console.WriteLine(hasHighScore);  // False
```

#### **Sorting and Reversing**

```csharp
List<int> numbers = new List<int> { 50, 20, 40, 10, 30 };

// Sort in ascending order
numbers.Sort();
// List: [10, 20, 30, 40, 50]

// Reverse list
numbers.Reverse();
// List: [50, 40, 30, 20, 10]

// Sort strings
List<string> names = new List<string> { "Raj", "Amit", "Priya", "Sneha" };
names.Sort();
// List: [Amit, Priya, Raj, Sneha]
```

#### **Converting Between Arrays and Lists**

```csharp
// Array to List
int[] array = { 1, 2, 3, 4, 5 };
List<int> list = new List<int>(array);
// or
List<int> list2 = array.ToList();

// List to Array
List<int> numbers = new List<int> { 10, 20, 30 };
int[] array2 = numbers.ToArray();
```

### Practical List Examples

```csharp
// Example 1: Student names manager
List<string> students = new List<string>();

// Add students
students.Add("Raj Kumar");
students.Add("Priya Sharma");
students.Add("Amit Patel");

// Display all
Console.WriteLine("All Students:");
for (int i = 0; i < students.Count; i++)
{
    Console.WriteLine($"{i + 1}. {students[i]}");
}

// Search for student
string searchName = "Priya Sharma";
if (students.Contains(searchName))
{
    Console.WriteLine($"{searchName} found!");
}

// Remove student
students.Remove("Amit Patel");

// Example 2: Shopping cart
List<double> prices = new List<double>();
prices.Add(99.99);
prices.Add(49.50);
prices.Add(149.99);

double total = 0;
foreach (double price in prices)
{
    total += price;
}

Console.WriteLine($"Total: ₹{total}");

// Example 3: Filter even numbers
List<int> allNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> evenNumbers = allNumbers.FindAll(x => x % 2 == 0);

Console.WriteLine("Even numbers:");
foreach (int num in evenNumbers)
{
    Console.Write($"{num} ");
}
// Output: 2 4 6 8 10
```

---

## 📚 Topic 6.4: Iterating with foreach Loop

### What is foreach?

**foreach** is a simplified loop for iterating through collections. It's cleaner and less error-prone than for loops.

**Syntax:**
```csharp
foreach (dataType variableName in collection)
{
    // Code to execute for each element
}
```

### foreach with Arrays

```csharp
// Example 1: Simple iteration
int[] numbers = { 10, 20, 30, 40, 50 };

foreach (int num in numbers)
{
    Console.WriteLine(num);
}
// Output: 10 20 30 40 50

// Example 2: Calculate sum
int[] scores = { 85, 90, 78, 92, 88 };
int total = 0;

foreach (int score in scores)
{
    total += score;
}

double average = total / (double)scores.Length;
Console.WriteLine($"Average: {average:F2}");

// Example 3: String array
string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

foreach (string fruit in fruits)
{
    Console.WriteLine($"I like {fruit}");
}

// Example 4: Count occurrences
int[] data = { 1, 2, 3, 2, 4, 2, 5 };
int target = 2;
int count = 0;

foreach (int num in data)
{
    if (num == target)
    {
        count++;
    }
}

Console.WriteLine($"{target} appears {count} times");
```

