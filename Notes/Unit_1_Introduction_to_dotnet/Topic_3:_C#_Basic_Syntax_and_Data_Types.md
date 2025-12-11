## Topic 3: C# Basic Syntax and Data Types

## 📚 Topic 3.1: Variables, Constants, and Naming Conventions

### What is a Variable?

A **variable** is a named storage location in memory that holds a value. Think of it as a labeled box where you can store data.

**Simple Analogy:**

```
Variable = Box with a Label
┌─────────────┐
│   age = 20  │  ← The box stores value 20
│             │    Label is "age"
└─────────────┘

```

### Declaring Variables

### **Syntax:**

```csharp
dataType variableName = value;

```

### **Examples:**

```csharp
// Integer variable
int age = 20;

// String variable
string name = "Raj";

// Floating-point variable
double price = 99.99;

// Boolean variable
bool isStudent = true;

```

### Variable Declaration Styles

### **1. Declare and Initialize:**

```csharp
int age = 20;  // Declared and initialized in one line

```

### **2. Declare First, Initialize Later:**

```csharp
int age;       // Declaration
age = 20;      // Initialization

```

### **3. Multiple Variables of Same Type:**

```csharp
int x = 10, y = 20, z = 30;

// Or
int a, b, c;
a = 1;
b = 2;
c = 3;

```

### **4. Type Inference using `var`:**

```csharp
var age = 20;           // Compiler infers: int
var name = "Raj";       // Compiler infers: string
var price = 99.99;      // Compiler infers: double
var isActive = true;    // Compiler infers: bool

// Note: var can only be used with initialization
// var x;  // ERROR - Cannot infer type

```

**When to use `var`:**

- When type is obvious from right side
- With LINQ queries
- With anonymous types
- Makes code more readable in some cases

**When NOT to use `var`:**

- When type is not obvious
- When clarity is more important

```csharp
// Good use of var
var students = new List<string>();
var result = CalculateTotal(10, 20);

// Better without var (more clear)
int count = GetCount();  // Clear that it returns int
string name = GetName(); // Clear that it returns string

```

### Constants

A **constant** is a variable whose value cannot be changed after initialization.

### **Syntax:**

```csharp
const dataType CONSTANT_NAME = value;

```

### **Examples:**

```csharp
const double PI = 3.14159;
const int MAX_STUDENTS = 100;
const string UNIVERSITY_NAME = "Tech University";

// Attempting to change will cause error
// PI = 3.14;  // ERROR: Cannot assign to a constant

```

**When to use constants:**

- Mathematical constants (PI, E)
- Configuration values that never change
- Magic numbers that need names
- Application-wide fixed values

```csharp
// Bad practice - Magic numbers
if (age > 18) { }
double area = 3.14159 * radius * radius;

// Good practice - Named constants
const int ADULT_AGE = 18;
const double PI = 3.14159;

if (age > ADULT_AGE) { }
double area = PI * radius * radius;

```

### Naming Conventions

Following naming conventions makes code readable and professional.

### **1. Variables and Parameters - camelCase**

```csharp
int studentAge = 20;
string firstName = "Raj";
double totalAmount = 1500.50;
bool isActive = true;

// First letter lowercase, subsequent words capitalized

```

### **2. Constants - UPPER_SNAKE_CASE**

```csharp
const int MAX_VALUE = 100;
const double PI = 3.14159;
const string DEFAULT_NAME = "Guest";

// All uppercase with underscores

```

### **3. Classes and Methods - PascalCase**

```csharp
public class StudentManager  // Class
{
    public void CalculateGrade()  // Method
    {
        // code
    }
}

// First letter of each word capitalized

```

### **4. Private Fields - _camelCase or camelCase**

```csharp
public class Student
{
    private int _age;           // Convention 1: Underscore prefix
    private string _name;

    // OR

    private int age;            // Convention 2: Plain camelCase
    private string name;
}

```

### Rules for Variable Names

### **✅ Valid Names:**

```csharp
int age;
int age2;
int _age;
int studentAge;
int student_age;
int $price;  // Valid but not recommended

```

### **❌ Invalid Names:**

```csharp
int 2age;         // Cannot start with number
int student-age;  // Cannot use hyphen
int student age;  // Cannot have spaces
int class;        // Cannot use keywords (use @class if needed)
int @class;       // @ prefix allows using keywords (not recommended)

```

### Best Practices for Naming

### **1. Use Descriptive Names:**

```csharp
// Bad
int x = 20;
string s = "Raj";

// Good
int studentAge = 20;
string studentName = "Raj";

```

### **2. Avoid Single Letters (except in loops):**

```csharp
// Bad
int a, b, c;

// Good
int age, height, weight;

// Exception: Loop counters
for (int i = 0; i < 10; i++) { }  // 'i' is acceptable

```

### **3. Be Consistent:**

```csharp
// Pick one style and stick with it throughout your project
string firstName;
string lastName;
// NOT: string first_name; string LastName;

```

### **4. Use Meaningful Abbreviations Sparingly:**

```csharp
// Good
int studentCount;
string firstName;

// Acceptable
int stuCount;  // If context is clear
string fName;

// Bad
int sc;
string fn;

```

### Variable Scope

**Scope** determines where a variable can be accessed.

### **1. Local Variables (Method Scope):**

```csharp
public void Method1()
{
    int localVar = 10;  // Only accessible in Method1
    Console.WriteLine(localVar);
}

public void Method2()
{
    // Console.WriteLine(localVar);  // ERROR - localVar not accessible here
}

```

### **2. Class-Level Variables (Fields):**

```csharp
public class Student
{
    private int age;  // Accessible throughout the class

    public void SetAge(int value)
    {
        age = value;  // Can access class-level variable
    }

    public void DisplayAge()
    {
        Console.WriteLine(age);  // Can access class-level variable
    }
}

```

### **3. Block Scope:**

```csharp
public void CheckAge(int age)
{
    if (age >= 18)
    {
        string message = "Adult";  // Block scope
        Console.WriteLine(message);
    }

    // Console.WriteLine(message);  // ERROR - message not accessible outside if block
}

```

---

## 📚 Topic 3.2: Built-in Value Types

Value types store the actual data directly in memory (on the stack).

### Integer Types

Integers are whole numbers (no decimal points).

| Type | Size | Range | Example |
| --- | --- | --- | --- |
| **byte** | 8 bits | 0 to 255 | `byte age = 25;` |
| **sbyte** | 8 bits | -128 to 127 | `sbyte temp = -10;` |
| **short** | 16 bits | -32,768 to 32,767 | `short year = 2024;` |
| **ushort** | 16 bits | 0 to 65,535 | `ushort port = 8080;` |
| **int** | 32 bits | -2.1B to 2.1B | `int population = 1000000;` |
| **uint** | 32 bits | 0 to 4.2B | `uint fileSize = 500000;` |
| **long** | 64 bits | -9.2Q to 9.2Q | `long distance = 9876543210;` |
| **ulong** | 64 bits | 0 to 18.4Q | `ulong bigNumber = 10000000000;` |

**Note:** `u` prefix means **unsigned** (no negative values, larger positive range)

### **Examples:**

```csharp
// Most commonly used: int
int studentCount = 50;
int temperature = -5;
int score = 95;

// Use byte for small values (0-255)
byte percentage = 85;
byte red = 255, green = 128, blue = 64;  // RGB color

// Use long for very large numbers
long worldPopulation = 7900000000;
long milliseconds = 1234567890123;

// Default integer literal is int
var number = 42;  // Type: int

// Use suffix for other types
var longNumber = 42L;    // Type: long
var uintNumber = 42U;    // Type: uint
var ulongNumber = 42UL;  // Type: ulong

```

### **Min and Max Values:**

```csharp
Console.WriteLine($"int min: {int.MinValue}");    // -2,147,483,648
Console.WriteLine($"int max: {int.MaxValue}");    // 2,147,483,647

Console.WriteLine($"byte min: {byte.MinValue}");  // 0
Console.WriteLine($"byte max: {byte.MaxValue}");  // 255

Console.WriteLine($"long min: {long.MinValue}");  // -9,223,372,036,854,775,808
Console.WriteLine($"long max: {long.MaxValue}");  // 9,223,372,036,854,775,807

```

### Floating-Point Types

Floating-point numbers have decimal points.

| Type | Size | Precision | Range | Example |
| --- | --- | --- | --- | --- |
| **float** | 32 bits | ~6-9 digits | ±1.5E-45 to ±3.4E38 | `float price = 99.99f;` |
| **double** | 64 bits | ~15-17 digits | ±5.0E-324 to ±1.7E308 | `double pi = 3.14159;` |
| **decimal** | 128 bits | 28-29 digits | ±1.0E-28 to ±7.9E28 | `decimal money = 1234.56m;` |

### **Examples:**

```csharp
// float - use 'f' suffix
float height = 5.9f;
float weight = 70.5f;

// double - default for decimal literals
double pi = 3.14159265359;
double temperature = 36.6;

// decimal - use 'm' suffix, best for money
decimal price = 999.99m;
decimal salary = 50000.00m;
decimal tax = 0.18m;  // 18%

```

### **When to Use Which?**

```csharp
// Use float:
// - Graphics, games (less precision needed)
// - Scientific calculations where precision is not critical
float gameSpeed = 1.5f;

// Use double (most common):
// - General purpose calculations
// - Scientific calculations
// - When you need more precision than float
double distance = 384400000.0;  // Earth to Moon (meters)

// Use decimal:
// - Financial calculations (money, banking)
// - When exact precision is required
decimal accountBalance = 1234567.89m;
decimal interestRate = 0.045m;  // 4.5%

```

### **Precision Comparison:**

```csharp
float f = 0.1f + 0.2f;
double d = 0.1 + 0.2;
decimal m = 0.1m + 0.2m;

Console.WriteLine($"float:   {f}");    // 0.30000001 (precision issue)
Console.WriteLine($"double:  {d}");    // 0.30000000000000004 (precision issue)
Console.WriteLine($"decimal: {m}");    // 0.3 (exact!)

// This is why decimal is used for money!

```

### Boolean Type

Boolean stores **true** or **false** values.

```csharp
bool isStudent = true;
bool isGraduated = false;
bool hasLicense = true;

// Commonly used in conditions
bool isAdult = (age >= 18);
bool isPassing = (marks >= 40);

// Logical operations
bool canVote = isAdult && hasLicense;
bool needsHelp = !isPassing;  // NOT operator

```

### **Examples:**

```csharp
int age = 20;
bool isAdult = age >= 18;

if (isAdult)
{
    Console.WriteLine("You can vote!");
}

// Boolean expressions
bool result1 = (10 > 5);      // true
bool result2 = (10 == 5);     // false
bool result3 = (10 != 5);     // true

// Combining booleans
bool canEnter = (age >= 18) && (hasTicket == true);
bool isWeekend = (day == "Saturday") || (day == "Sunday");

```

### Character Type

**char** stores a single character (Unicode).

```csharp
char grade = 'A';
char symbol = '@';
char digit = '5';
char letter = 'Z';

// Must use single quotes!
// char wrong = "A";  // ERROR - double quotes are for strings

// Special characters (escape sequences)
char newline = '\n';
char tab = '\t';
char backslash = '\\';
char singleQuote = '\'';

```

### **Character Examples:**

```csharp
char firstLetter = 'R';
char lastLetter = 'J';

Console.WriteLine($"First: {firstLetter}, Last: {lastLetter}");

// Char operations
char ch = 'A';
int asciiValue = (int)ch;  // 65
Console.WriteLine($"ASCII of 'A': {asciiValue}");

// Char methods
bool isDigit = char.IsDigit('5');      // true
bool isLetter = char.IsLetter('A');    // true
bool isUpper = char.IsUpper('A');      // true
char lower = char.ToLower('A');        // 'a'
char upper = char.ToUpper('a');        // 'A'

```

### Value Type Memory Allocation

**Value types are stored on the STACK:**

```
Stack Memory:
┌─────────────────┐
│  age = 20       │  ← Value directly stored
├─────────────────┤
│  price = 99.99  │  ← Value directly stored
├─────────────────┤
│  isActive=true  │  ← Value directly stored
└─────────────────┘

```

**Characteristics:**

- Fast access
- Fixed size
- Copied by value
- Automatically cleaned up when out of scope

```csharp
// Value type behavior
int a = 10;
int b = a;     // b gets a COPY of a's value

b = 20;        // Changing b doesn't affect a

Console.WriteLine(a);  // 10 (unchanged)
Console.WriteLine(b);  // 20

```

---

## 📚 Topic 3.3: Reference Types (string, object)

Reference types store a **reference (address)** to the actual data in memory.

### String Type

**string** represents a sequence of characters (text).

```csharp
string name = "Raj Kumar";
string message = "Hello, World!";
string empty = "";
string nullString = null;

```

### **String Characteristics:**

- **Immutable** - Cannot be changed after creation
- **Reference type** - Stored on the heap
- **Double quotes** - Use "..." not '...'

### **String Operations:**

**1. Concatenation:**

```csharp
string firstName = "Raj";
string lastName = "Kumar";

// Method 1: + operator
string fullName = firstName + " " + lastName;

// Method 2: String.Concat
string fullName2 = string.Concat(firstName, " ", lastName);

Console.WriteLine(fullName);  // Raj Kumar

```

**2. String Interpolation (Modern, Recommended):**

```csharp
string name = "Raj";
int age = 20;

// Old way
string message1 = "My name is " + name + " and I am " + age + " years old.";

// Modern way - String interpolation
string message2 = $"My name is {name} and I am {age} years old.";

Console.WriteLine(message2);
// Output: My name is Raj and I am 20 years old.

```

**3. Verbatim Strings:**

```csharp
// Regular string - need to escape backslashes
string path1 = "C:\\Users\\Raj\\Documents\\file.txt";

// Verbatim string - use @ prefix
string path2 = @"C:\Users\Raj\Documents\file.txt";

// Multi-line strings
string multiLine = @"Line 1
Line 2
Line 3";

Console.WriteLine(multiLine);

```

**4. Common String Methods:**

```csharp
string text = "Hello World";

// Length
int length = text.Length;  // 11

// Convert case
string upper = text.ToUpper();      // "HELLO WORLD"
string lower = text.ToLower();      // "hello world"

// Substring
string sub = text.Substring(0, 5);  // "Hello"

// Contains
bool hasWorld = text.Contains("World");  // true

// Replace
string replaced = text.Replace("World", "C#");  // "Hello C#"

// Split
string csv = "Raj,20,Mumbai";
string[] parts = csv.Split(',');  // ["Raj", "20", "Mumbai"]

// Trim whitespace
string messy = "  Hello  ";
string clean = messy.Trim();  // "Hello"

// Check empty or null
bool isEmpty = string.IsNullOrEmpty(text);      // false
bool isWhitespace = string.IsNullOrWhiteSpace(text);  // false

```

**5. String Comparison:**

```csharp
string str1 = "Hello";
string str2 = "hello";

// Case-sensitive comparison
bool equal1 = (str1 == str2);  // false

// Case-insensitive comparison
bool equal2 = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);  // true

// Using Compare method
int result = string.Compare(str1, str2, true);  // 0 means equal (true = ignore case)

```

**6. Escape Sequences:**

```csharp
string withNewline = "Line 1\nLine 2";
string withTab = "Name:\tRaj";
string withQuotes = "He said \"Hello\"";
string withBackslash = "Path: C:\\Users";

Console.WriteLine(withNewline);
// Output:
// Line 1
// Line 2

```

### **String Immutability:**

```csharp
string original = "Hello";
string modified = original.ToUpper();

Console.WriteLine(original);   // "Hello" (unchanged!)
Console.WriteLine(modified);   // "HELLO" (new string)

// Strings cannot be modified in place
// original[0] = 'h';  // ERROR - strings are immutable

```

**Memory Visualization:**

```
Heap Memory:
┌──────────────────┐
│  "Hello"         │  ← Original string
├──────────────────┤
│  "HELLO"         │  ← New string created by ToUpper()
└──────────────────┘

Stack:
original → points to "Hello"
modified → points to "HELLO"

```

### Object Type

**object** is the base type of all types in C#. Everything inherits from object.

```csharp
object obj1 = 10;              // Can hold int
object obj2 = "Hello";         // Can hold string
object obj3 = 3.14;            // Can hold double
object obj4 = true;            // Can hold bool
object obj5 = new Student();   // Can hold any object

```

### **Boxing and Unboxing:**

**Boxing** - Converting value type to object (reference type)

```csharp
int number = 42;
object boxed = number;  // Boxing - value type wrapped in object

// Memory:
// Stack: number = 42
// Heap: object containing 42

```

**Unboxing** - Converting object back to value type

```csharp
object boxed = 42;
int unboxed = (int)boxed;  // Unboxing - explicit cast required

Console.WriteLine(unboxed);  // 42

```

**Note:** Boxing and unboxing have performance overhead. Use generics to avoid.

```csharp
// Avoid this (boxing overhead)
List<object> numbers = new List<object>();
numbers.Add(1);    // Boxing
numbers.Add(2);    // Boxing

// Better approach (no boxing)
List<int> numbers2 = new List<int>();
numbers2.Add(1);   // No boxing
numbers2.Add(2);   // No boxing

```

### **Working with object:**

```csharp
object obj = "Hello";

// Need to check type before using
if (obj is string)
{
    string str = (string)obj;
    Console.WriteLine(str.ToUpper());
}

// Using pattern matching (C# 7+)
if (obj is string text)
{
    Console.WriteLine(text.ToUpper());  // Can use 'text' directly
}

// Get type information
Type type = obj.GetType();
Console.WriteLine(type);  // System.String

```

### Reference Type Memory Allocation

**Reference types are stored on the HEAP:**

```
Stack Memory:              Heap Memory:
┌─────────────────┐       ┌──────────────────┐
│  name → [addr]  │  →    │  "Raj Kumar"     │
├─────────────────┤       ├──────────────────┤
│  obj  → [addr]  │  →    │  {object data}   │
└─────────────────┘       └──────────────────┘

```

**Reference type behavior:**

```csharp
// Reference type behavior
string a = "Hello";
string b = a;     // b gets a REFERENCE to same object

// But strings are immutable, so:
b = "World";      // Creates NEW string, doesn't modify original

Console.WriteLine(a);  // "Hello"
Console.WriteLine(b);  // "World"

// With mutable reference types (like arrays):
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;  // Both point to same array

arr2[0] = 99;       // Modifies the shared array

Console.WriteLine(arr1[0]);  // 99 (affected!)
Console.WriteLine(arr2[0]);  // 99

```

---

## 📚 Topic 3.4: Type Conversion

Type conversion is changing a value from one data type to another.

### Implicit Conversion (Automatic)

**Implicit conversion** happens automatically when there's no risk of data loss.

```csharp
// Small to large (safe conversions)
byte b = 10;
int i = b;      // byte → int (automatic)

int x = 100;
long l = x;     // int → long (automatic)

float f = 3.14f;
double d = f;   // float → double (automatic)

// Hierarchy: byte → short → int → long → float → double

```

**Safe conversion path:**

```
byte (8 bits)
  ↓
short (16 bits)
  ↓
int (32 bits)
  ↓
long (64 bits)
  ↓
float (32 bits)
  ↓
double (64 bits)

```

### Explicit Conversion (Casting)

**Explicit conversion** requires manual casting when data loss might occur.

```csharp
// Large to small (potential data loss)
double d = 3.14;
int i = (int)d;     // 3 (decimal part lost!)

long l = 1000;
int x = (int)l;     // Potential overflow if l is too large

float f = 5.99f;
int y = (int)f;     // 5 (decimal part lost)

```

### **Casting Examples:**

```csharp
// Double to int
double price = 99.99;
int roundedPrice = (int)price;  // 99 (truncates, doesn't round!)

Console.WriteLine(roundedPrice);  // 99

// To round instead of truncate:
int roundedPrice2 = (int)Math.Round(price);  // 100

// Char to int (gets ASCII value)
char ch = 'A';
int ascii = (int)ch;  // 65

// Int to char
int code = 66;
char letter = (char)code;  // 'B'

```

### **Overflow Example:**

```csharp
int bigNumber = 300;
byte small = (byte)bigNumber;  // Overflow! byte max is 255

Console.WriteLine(small);  // 44 (wraps around)

// To detect overflow, use checked:
checked
{
    int bigNum = 300;
    byte smallNum = (byte)bigNum;  // Throws OverflowException
}

```

### Conversion Methods

### **1. Convert Class:**

```csharp
// String to number
string strAge = "20";
int age = Convert.ToInt32(strAge);

string strPrice = "99.99";
double price = Convert.ToDouble(strPrice);

// Number to string
int number = 42;
string strNumber = Convert.ToString(number);

// Boolean conversions
string strBool = "true";
bool flag = Convert.ToBoolean(strBool);

// Common Convert methods:
Convert.ToInt32()    // To int
Convert.ToDouble()   // To double
Convert.ToBoolean()  // To bool
Convert.ToString()   // To string
Convert.ToChar()     // To char

```

### **2. Parse Method:**

```csharp
// String to number (throws exception if invalid)
string str1 = "123";
int num1 = int.Parse(str1);

string str2 = "3.14";
double num2 = double.Parse(str2);

// Parse will throw FormatException if invalid:
// int invalid = int.Parse("abc");  // ERROR!

```

### **3. TryParse Method (Safer):**

```csharp
// Returns true if successful, false if failed
string input = "123";

if (int.TryParse(input, out int result))
{
    Console.WriteLine($"Parsed successfully: {result}");
}
else
{
    Console.WriteLine("Invalid input");
}

// With invalid input:
string badInput = "abc";
if (int.TryParse(badInput, out int result2))
{
    Console.WriteLine($"Success: {result2}");
}
else
{
    Console.WriteLine("Failed to parse");  // This executes
}

```

### **TryParse vs Parse:**

```csharp
// Parse - throws exception on failure
try
{
    int num = int.Parse("abc");
}
catch (FormatException)
{
    Console.WriteLine("Invalid format");
}

// TryParse - returns false on failure (better approach)
if (!int.TryParse("abc", out int num2))
{
    Console.WriteLine("Invalid format");
}

```

### **4. ToString() Method:**

```csharp
// Convert any type to string
int age = 20;
string strAge = age.ToString();

double price = 99.99;
string strPrice = price.ToString();

bool flag = true;
string strFlag = flag.ToString();  // "True"

// With formatting
int number = 1234567;
string formatted = number.ToString("N0");  // "1,234,567"

double money = 1234.56;
string currency = money.ToString("C");  // "$1,234.56" (culture-dependent)

```

### Conversion Summary Table

| From | To | Method | Example |
| --- | --- | --- | --- |
| int | string | ToString() | `num.ToString()` |
| string | int | Parse / TryParse | `int.Parse(str)` |
| double | int | Cast | `(int)doubleValue` |
| int | double | Implicit | `double d = intValue;` |
| string | double | Parse / TryParse | `double.Parse(str)` |
| char | int | Cast | `(int)charValue` |
| int | char | Cast | `(char)intValue` |
| bool | string | ToString() | `flag.ToString()` |
| string | bool | Parse | `bool.Parse(str)` |

### Practical Examples

```csharp
// Example 1: User input conversion
Console.Write("Enter your age: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"You are {age} years old.");
}
else
{
    Console.WriteLine("Invalid age entered.");
}

// Example 2: Temperature conversion
double celsius = 25.0;
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

// Example 3: String to number calculation
string num1Str = "10";
string num2Str = "20";

int num1 = int.Parse(num1Str);
int num2 = int.Parse(num2Str);
int sum = num1 + num2;

Console.WriteLine($"{num1} + {num2} = {sum}");

// Example 4: Formatting output
double price = 1234.567;
Console.WriteLine($"Price: {price:C}");      // Currency: $1,234.57
Console.WriteLine($"Price: {price:F2}");     // Fixed: 1234.57
Console.WriteLine($"Price: {price:N2}");     // Number: 1,234.57

```

---

## 🎯 Student Tasks & Practice

### Task 1: Variable Practice

Create a program that declares and initializes:

```csharp
// Student information
string studentName = "Your Name";
int rollNumber = 101;
char grade = 'A';
double percentage = 85.5;
bool isPassed = true;

// Display all information

```

### Task 2: Constants

Create a program using constants for:

- PI (3.14159)
- Speed of light (299792458 m/s)
- Absolute zero (-273.15°C)

Calculate:

- Area of circle with radius 5
- Time for light to travel 1 km
- Kelvin temperature of 25°C

### Task 3: String Manipulation

```csharp
string sentence = "C# is awesome for programming";

// Tasks:
// 1. Convert to uppercase
// 2. Replace "awesome" with "excellent"
// 3. Extract the word "programming"
// 4. Split into words and count them
// 5. Check if it contains "C#"

```

### Task 4: Type Conversion Calculator

Create a calculator that:

1. Takes two numbers as string input
2. Converts to appropriate numeric types
3. Performs operations (+, -, *, /)
4. Displays results with proper formatting

### Task 5: Data Type Quiz Program

Create a program that:

1. Asks user to enter different data types
2. Validates each input using TryParse
3. Displays appropriate error messages
4. Shows the final values with their types

### Task 6: Temperature Converter

Build a program that:

- Accepts temperature in Celsius
- Converts to Fahrenheit and Kelvin
- Uses proper data types (double)
- Formats output to 2 decimal places

**Formulas:**

- Fahrenheit = (Celsius × 9/5) + 32
- Kelvin = Celsius + 273.15

### Task 7: Student Grade Calculator

```csharp
// Input: Subject marks (as strings from console)
// Process: Convert to numbers, calculate average
// Output: Average, percentage, grade

// Grading:
// >= 90: A
// >= 80: B
// >= 70: C
// >= 60: D
// < 60: F

```

---

## 🔍 Common Mistakes to Avoid

### 1. Forgetting to Initialize Variables

```csharp
// ❌ Wrong
int age;
Console.WriteLine(age);  // ERROR: Use of unassigned local variable

// ✅ Correct
int age = 0;
Console.WriteLine(age);  // OK

```

### 2. Confusing Single and Double Quotes

```csharp
// ❌ Wrong
char letter = "A";  // ERROR: Cannot convert string to char
string text = 'A';  // ERROR: Cannot convert char to string

// ✅ Correct
char letter = 'A';   // Single quotes for char
string text = "A";   // Double quotes for string

```

### 3. Integer Division

```csharp
// ❌ Wrong expectation
int a = 5;
int b = 2;
double result = a / b;  // Result: 2.0 (not 2.5!)

// ✅ Correct
double result = (double)a / b;  // Result: 2.5
// or
double result = a / (double)b;  // Result: 2.5

```

### 4. String Immutability Misunderstanding

```csharp
// ❌ Inefficient (creates many string objects)
string result = "";
for (int i = 0; i < 1000; i++)
{
    result = result + i;  // Creates new string each time
}

// ✅ Correct (use StringBuilder for concatenation in loops)
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 1000; i++)
{
    sb.Append(i);
}
string result = sb.ToString();

```

### 5. Not Using TryParse

```csharp
// ❌ Risky
Console.Write("Enter age: ");
int age = int.Parse(Console.ReadLine());  // Crashes on invalid input

// ✅ Safe
Console.Write("Enter age: ");
if (int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine($"Age: {age}");
}
else
{
    Console.WriteLine("Invalid input!");
}

```

### 6. Comparing Floating-Point Numbers

```csharp
// ❌ Wrong
double a = 0.1 + 0.2;
if (a == 0.3)  // May be false due to precision!
{
    Console.WriteLine("Equal");
}

// ✅ Correct
double a = 0.1 + 0.2;
double epsilon = 0.0001;
if (Math.Abs(a - 0.3) < epsilon)
{
    Console.WriteLine("Equal (within tolerance)");
}

```

### 7. Overflow Issues

```csharp
// ❌ Silent overflow
byte b = 255;
b = b + 1;  // Wraps to 0

// ✅ Detect overflow
checked
{
    byte b = 255;
    b = b + 1;  // Throws OverflowException
}

```

---

## 💡 Pro Tips

### 1. Use String Interpolation

```csharp
// Old way
string message = "Hello " + name + ", you are " + age + " years old.";

// Modern way (cleaner)
string message = $"Hello {name}, you are {age} years old.";

```

### 2. Use var for Obvious Types

```csharp
// Good use of var
var students = new List<Student>();
var connection = new SqlConnection(connectionString);
var result = calculator.Calculate(10, 20);

// Keep explicit type for clarity
int count = GetStudentCount();  // Clear return type

```

### 3. Constants for Magic Numbers

```csharp
// ❌ Bad
if (age > 18) { }
if (marks >= 40) { }

// ✅ Good
const int ADULT_AGE = 18;
const int PASSING_MARKS = 40;

if (age > ADULT_AGE) { }
if (marks >= PASSING_MARKS) { }

```

### 4. Use Decimal for Money

```csharp
// ❌ Wrong
double price = 19.99;
double tax = price * 0.18;  // Precision issues!

// ✅ Correct
decimal price = 19.99m;
decimal tax = price * 0.18m;  // Exact calculation

```

### 5. Verbatim Strings for Paths

```csharp
// ❌ Hard to read
string path = "C:\\Users\\Raj\\Documents\\file.txt";

// ✅ Cleaner
string path = @"C:\Users\Raj\Documents\file.txt";

```

---

## 📖 Key Takeaways

✅ **Variables** store data that can change; **constants** store fixed values

✅ **Follow naming conventions**: camelCase for variables, PascalCase for classes/methods, UPPER_SNAKE_CASE for constants

✅ **Value types** (int, double, bool, char) store data on stack; **reference types** (string, object) store on heap

✅ **Use appropriate data types**: int for whole numbers, double for decimals, decimal for money, string for text

✅ **Strings are immutable** - operations create new strings, don't modify existing ones

✅ **Use TryParse** for safe user input conversion instead of Parse

✅ **Implicit conversion** is automatic (safe); **explicit conversion** requires casting (potential data loss)

✅ **String interpolation** ($"...{variable}...") is the modern way to format strings

✅ **Use var judiciously** - only when type is obvious from the right-hand side

✅ **Constants improve code readability** and maintainability by giving names to magic numbers

---

## 📚 Complete Working Example

```csharp
// Complete Student Management Example
using System;

namespace StudentManagement
{
    class Program
    {
        // Constants
        const int PASSING_MARKS = 40;
        const int MAX_MARKS = 100;
        const double EXCELLENCE_PERCENTAGE = 90.0;

        static void Main(string[] args)
        {
            // Variable declarations
            string studentName;
            int rollNumber;
            double marks1, marks2, marks3;
            double totalMarks, percentage;
            char grade;
            bool isPassed;

            // Get student information
            Console.WriteLine("=== Student Grade Calculator ===\n");

            Console.Write("Enter student name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter roll number: ");
            while (!int.TryParse(Console.ReadLine(), out rollNumber))
            {
                Console.Write("Invalid! Enter roll number again: ");
            }

            // Get marks for 3 subjects
            Console.Write("Enter marks in Subject 1: ");
            while (!double.TryParse(Console.ReadLine(), out marks1) || marks1 < 0 || marks1 > MAX_MARKS)
            {
                Console.Write($"Invalid! Enter marks between 0 and {MAX_MARKS}: ");
            }

            Console.Write("Enter marks in Subject 2: ");
            while (!double.TryParse(Console.ReadLine(), out marks2) || marks2 < 0 || marks2 > MAX_MARKS)
            {
                Console.Write($"Invalid! Enter marks between 0 and {MAX_MARKS}: ");
            }

            Console.Write("Enter marks in Subject 3: ");
            while (!double.TryParse(Console.ReadLine(), out marks3) || marks3 < 0 || marks3 > MAX_MARKS)
            {
                Console.Write($"Invalid! Enter marks between 0 and {MAX_MARKS}: ");
            }

            // Calculate total and percentage
            totalMarks = marks1 + marks2 + marks3;
            percentage = (totalMarks / (MAX_MARKS * 3)) * 100;

            // Determine pass/fail
            isPassed = (marks1 >= PASSING_MARKS) &&
                       (marks2 >= PASSING_MARKS) &&
                       (marks3 >= PASSING_MARKS) &&
                       (percentage >= PASSING_MARKS);

            // Determine grade
            if (percentage >= 90)
                grade = 'A';
            else if (percentage >= 80)
                grade = 'B';
            else if (percentage >= 70)
                grade = 'C';
            else if (percentage >= 60)
                grade = 'D';
            else if (percentage >= PASSING_MARKS)
                grade = 'E';
            else
                grade = 'F';

            // Display results
            Console.WriteLine("\n=== Student Report Card ===");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"\nSubject 1: {marks1}");
            Console.WriteLine($"Subject 2: {marks2}");
            Console.WriteLine($"Subject 3: {marks3}");
            Console.WriteLine($"\nTotal Marks: {totalMarks}/{MAX_MARKS * 3}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Result: {(isPassed ? "PASSED" : "FAILED")}");

            if (percentage >= EXCELLENCE_PERCENTAGE)
            {
                Console.WriteLine("\n🎉 Excellent Performance!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

```

---

## 🔗 Additional Resources

- [C# Data Types Documentation](https://docs.microsoft.com/dotnet/csharp/language-reference/builtin-types/)
- [String Class Methods](https://docs.microsoft.com/dotnet/api/system.string)
- [Type Conversion Guide](https://docs.microsoft.com/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
- [Naming Conventions](https://docs.microsoft.com/dotnet/csharp/fundamentals/coding-style/coding-conventions)

---
