## *Topic 2: Control Flow and Conditional Statements*

## 📚 Topic 5.1: if, else if, else Statements

### What is Control Flow?

**Control flow** determines the order in which code is executed. By default, code runs line-by-line from top to bottom. Control flow statements allow us to:

- Make decisions (if, else, switch)
- Repeat code (loops)
- Jump to different parts of code

**Simple Analogy:**
Think of control flow like a GPS navigation system:

- **Default:** Go straight (execute line by line)
- **if statement:** If traffic ahead, turn left (make a decision)
- **loops:** Keep going around the block until you find parking (repeat)

### The if Statement

The **if statement** executes code only if a condition is true.

**Syntax:**

```csharp
if (condition)
{
    // Code executes if condition is true
}

```

### **Basic Examples:**

```csharp
// Example 1: Simple if
int age = 20;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
// Output: You are an adult.

// Example 2: Check even number
int number = 10;
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even.");
}
// Output: 10 is even.

// Example 3: Grade check
int marks = 85;
if (marks >= 90)
{
    Console.WriteLine("Grade: A");
}
// No output (condition is false)

// Example 4: Without braces (single statement)
int score = 100;
if (score == 100)
    Console.WriteLine("Perfect score!");  // Works, but braces are recommended

```

**Best Practice:** Always use braces `{}` even for single statements to avoid bugs.

```csharp
// ❌ Dangerous without braces
if (age >= 18)
    Console.WriteLine("Adult");
    Console.WriteLine("Can vote");  // Always executes! Not part of if

// ✅ Safe with braces
if (age >= 18)
{
    Console.WriteLine("Adult");
    Console.WriteLine("Can vote");  // Both part of if block
}

```

### The if-else Statement

**if-else** provides an alternative path when the condition is false.

**Syntax:**

```csharp
if (condition)
{
    // Code if condition is true
}
else
{
    // Code if condition is false
}

```

### **Examples:**

```csharp
// Example 1: Adult or Minor
int age = 15;
if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}
// Output: You are a minor.

// Example 2: Even or Odd
int number = 7;
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even.");
}
else
{
    Console.WriteLine($"{number} is odd.");
}
// Output: 7 is odd.

// Example 3: Pass or Fail
int marks = 35;
if (marks >= 40)
{
    Console.WriteLine("Result: PASS");
}
else
{
    Console.WriteLine("Result: FAIL");
}
// Output: Result: FAIL

// Example 4: Temperature check
double temp = 25.5;
if (temp > 37.0)
{
    Console.WriteLine("You have a fever.");
}
else
{
    Console.WriteLine("Temperature is normal.");
}
// Output: Temperature is normal.

```

### The if-else if-else Statement

**if-else if-else** allows checking multiple conditions sequentially.

**Syntax:**

```csharp
if (condition1)
{
    // Code if condition1 is true
}
else if (condition2)
{
    // Code if condition2 is true
}
else if (condition3)
{
    // Code if condition3 is true
}
else
{
    // Code if all conditions are false
}

```

**Important:** Only ONE block executes (the first true condition).

### **Examples:**

```csharp
// Example 1: Grade system
int marks = 85;

if (marks >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (marks >= 80)
{
    Console.WriteLine("Grade: B");  // This executes
}
else if (marks >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (marks >= 60)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}
// Output: Grade: B

// Example 2: Age categories
int age = 35;

if (age < 13)
{
    Console.WriteLine("Child");
}
else if (age < 20)
{
    Console.WriteLine("Teenager");
}
else if (age < 60)
{
    Console.WriteLine("Adult");  // This executes
}
else
{
    Console.WriteLine("Senior Citizen");
}
// Output: Adult

// Example 3: Time of day greeting
int hour = 14;

if (hour < 12)
{
    Console.WriteLine("Good Morning");
}
else if (hour < 18)
{
    Console.WriteLine("Good Afternoon");  // This executes
}
else
{
    Console.WriteLine("Good Evening");
}
// Output: Good Afternoon

// Example 4: BMI categories
double bmi = 22.5;

if (bmi < 18.5)
{
    Console.WriteLine("Underweight");
}
else if (bmi < 25)
{
    Console.WriteLine("Normal weight");  // This executes
}
else if (bmi < 30)
{
    Console.WriteLine("Overweight");
}
else
{
    Console.WriteLine("Obese");
}
// Output: Normal weight

```

### Nested if Statements

You can place if statements inside other if statements.

```csharp
// Example 1: Admission eligibility
int marks = 75;
bool hasDiploma = true;

if (marks >= 60)
{
    Console.WriteLine("Marks requirement met.");

    if (hasDiploma)
    {
        Console.WriteLine("Admission granted!");  // This executes
    }
    else
    {
        Console.WriteLine("Diploma required.");
    }
}
else
{
    Console.WriteLine("Insufficient marks.");
}
// Output:
// Marks requirement met.
// Admission granted!

// Example 2: Loan approval
int age = 30;
int salary = 50000;
int creditScore = 750;

if (age >= 21)
{
    if (salary >= 30000)
    {
        if (creditScore >= 700)
        {
            Console.WriteLine("Loan approved!");  // This executes
        }
        else
        {
            Console.WriteLine("Credit score too low.");
        }
    }
    else
    {
        Console.WriteLine("Insufficient salary.");
    }
}
else
{
    Console.WriteLine("Age requirement not met.");
}
// Output: Loan approved!

// Example 3: Better approach using logical operators
// Instead of deep nesting, use && operator
if (age >= 21 && salary >= 30000 && creditScore >= 700)
{
    Console.WriteLine("Loan approved!");
}
else
{
    Console.WriteLine("Loan not approved.");
}

```

### Practical Examples

### **Example 1: Leap Year Checker**

```csharp
Console.Write("Enter a year: ");
int year = int.Parse(Console.ReadLine());

bool isLeapYear = false;

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            isLeapYear = true;  // Divisible by 400
        }
    }
    else
    {
        isLeapYear = true;  // Divisible by 4 but not 100
    }
}

if (isLeapYear)
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}

```

### **Example 2: Triangle Validator**

```csharp
Console.WriteLine("Enter three sides of triangle:");
Console.Write("Side 1: ");
double side1 = double.Parse(Console.ReadLine());
Console.Write("Side 2: ");
double side2 = double.Parse(Console.ReadLine());
Console.Write("Side 3: ");
double side3 = double.Parse(Console.ReadLine());

// Check if valid triangle
if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
{
    Console.WriteLine("Valid triangle!");

    // Check type of triangle
    if (side1 == side2 && side2 == side3)
    {
        Console.WriteLine("Type: Equilateral");
    }
    else if (side1 == side2 || side2 == side3 || side1 == side3)
    {
        Console.WriteLine("Type: Isosceles");
    }
    else
    {
        Console.WriteLine("Type: Scalene");
    }
}
else
{
    Console.WriteLine("Invalid triangle!");
}

```

### **Example 3: Tax Calculator**

```csharp
Console.Write("Enter annual income: ₹");
double income = double.Parse(Console.ReadLine());

double tax = 0;

if (income <= 250000)
{
    tax = 0;  // No tax
    Console.WriteLine("Tax slab: No tax");
}
else if (income <= 500000)
{
    tax = (income - 250000) * 0.05;  // 5% on income above 2.5L
    Console.WriteLine("Tax slab: 5%");
}
else if (income <= 1000000)
{
    tax = 12500 + (income - 500000) * 0.20;  // 20% on income above 5L
    Console.WriteLine("Tax slab: 20%");
}
else
{
    tax = 112500 + (income - 1000000) * 0.30;  // 30% on income above 10L
    Console.WriteLine("Tax slab: 30%");
}

Console.WriteLine($"Tax amount: ₹{tax:F2}");
Console.WriteLine($"Net income: ₹{income - tax:F2}");

```

---

## 📚 Topic 5.2: switch Statements

The **switch statement** is an alternative to multiple if-else if statements when checking a single variable against multiple values.

**Syntax:**

```csharp
switch (expression)
{
    case value1:
        // Code for value1
        break;
    case value2:
        // Code for value2
        break;
    case value3:
        // Code for value3
        break;
    default:
        // Code if no case matches
        break;
}

```

### Basic switch Examples

```csharp
// Example 1: Day of week
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");  // This executes
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}
// Output: Wednesday

// Example 2: Grade message
char grade = 'B';

switch (grade)
{
    case 'A':
        Console.WriteLine("Excellent!");
        break;
    case 'B':
        Console.WriteLine("Good job!");  // This executes
        break;
    case 'C':
        Console.WriteLine("Well done!");
        break;
    case 'D':
        Console.WriteLine("You passed.");
        break;
    case 'F':
        Console.WriteLine("Better try next time.");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;
}
// Output: Good job!

// Example 3: Month days
int month = 2;

switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("31 days");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("30 days");
        break;
    case 2:
        Console.WriteLine("28 or 29 days");  // This executes
        break;
    default:
        Console.WriteLine("Invalid month");
        break;
}
// Output: 28 or 29 days

```

### switch with Strings

```csharp
// Example 1: Command processor
string command = "start";

switch (command.ToLower())
{
    case "start":
        Console.WriteLine("Starting the application...");  // This executes
        break;
    case "stop":
        Console.WriteLine("Stopping the application...");
        break;
    case "pause":
        Console.WriteLine("Pausing the application...");
        break;
    case "restart":
        Console.WriteLine("Restarting the application...");
        break;
    default:
        Console.WriteLine("Unknown command");
        break;
}
// Output: Starting the application...

// Example 2: Color code
string color = "red";

switch (color)
{
    case "red":
        Console.WriteLine("RGB: (255, 0, 0)");  // This executes
        break;
    case "green":
        Console.WriteLine("RGB: (0, 255, 0)");
        break;
    case "blue":
        Console.WriteLine("RGB: (0, 0, 255)");
        break;
    case "white":
        Console.WriteLine("RGB: (255, 255, 255)");
        break;
    case "black":
        Console.WriteLine("RGB: (0, 0, 0)");
        break;
    default:
        Console.WriteLine("Color not found");
        break;
}
// Output: RGB: (255, 0, 0)

```

### switch vs if-else if

**When to use switch:**

- Testing one variable against multiple specific values
- Values are constants (not ranges)
- Code is more readable than multiple if-else

**When to use if-else if:**

- Testing ranges (e.g., age >= 18)
- Complex conditions with logical operators
- Different variables in each condition

```csharp
// ✅ Good use of switch (specific values)
int choice = 2;
switch (choice)
{
    case 1: Console.WriteLine("Option 1"); break;
    case 2: Console.WriteLine("Option 2"); break;
    case 3: Console.WriteLine("Option 3"); break;
}

// ✅ Better with if-else (ranges)
int marks = 85;
if (marks >= 90)
    Console.WriteLine("A");
else if (marks >= 80)
    Console.WriteLine("B");
else if (marks >= 70)
    Console.WriteLine("C");

// ❌ Can't use switch for ranges (without C# 8+ patterns)
// switch (marks)  // Doesn't work well for ranges
// {
//     case >= 90: Console.WriteLine("A"); break;  // Old C# doesn't support
// }

```

### Fall-Through in switch

**Note:** C# doesn't allow implicit fall-through (unlike C/C++). You must use `break`.

```csharp
// ❌ This causes compile error in C#
switch (day)
{
    case 1:
        Console.WriteLine("Weekend");
        // Missing break - ERROR!
    case 2:
        Console.WriteLine("Weekday");
        break;
}

// ✅ Explicit fall-through with goto (rarely used)
int number = 1;
switch (number)
{
    case 1:
        Console.WriteLine("One");
        goto case 2;  // Explicit fall-through
    case 2:
        Console.WriteLine("One or Two");
        break;
}
// Output:
// One
// One or Two

```

### Modern switch Expression (C# 8+)

```csharp
// Traditional switch statement
string day = "Monday";
string dayType;

switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        dayType = "Weekday";
        break;
    case "Saturday":
    case "Sunday":
        dayType = "Weekend";
        break;
    default:
        dayType = "Invalid";
        break;
}

// Modern switch expression (C# 8+)
dayType = day switch
{
    "Monday" or "Tuesday" or "Wednesday" or "Thursday" or "Friday" => "Weekday",
    "Saturday" or "Sunday" => "Weekend",
    _ => "Invalid"
};

Console.WriteLine(dayType);

```

### Practical switch Examples

### **Example 1: Simple Calculator**

```csharp
Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter operator (+, -, *, /): ");
char op = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());

double result = 0;

switch (op)
{
    case '+':
        result = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {result}");
        break;
    case '-':
        result = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {result}");
        break;
    case '*':
        result = num1 * num2;
        Console.WriteLine($"{num1} × {num2} = {result}");
        break;
    case '/':
        if (num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine($"{num1} ÷ {num2} = {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero!");
        }
        break;
    default:
        Console.WriteLine("Invalid operator!");
        break;
}

```

### **Example 2: Menu-Driven Program**

```csharp
bool exit = false;

while (!exit)
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");
    Console.Write("Enter choice: ");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("You selected: Add");
            // Add logic here
            break;
        case 2:
            Console.WriteLine("You selected: Subtract");
            // Subtract logic here
            break;
        case 3:
            Console.WriteLine("You selected: Multiply");
            // Multiply logic here
            break;
        case 4:
            Console.WriteLine("You selected: Divide");
            // Divide logic here
            break;
        case 5:
            Console.WriteLine("Goodbye!");
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice! Try again.");
            break;
    }
}

```

---

## 📚 Topic 5.3: Looping - for, while, do-while

Loops allow you to execute code repeatedly.

### The for Loop

The **for loop** is used when you know how many times to repeat.

**Syntax:**

```csharp
for (initialization; condition; increment/decrement)
{
    // Code to repeat
}

```

**Execution Flow:**

1. Initialization (runs once)
2. Check condition
3. If true: Execute body
4. Run increment/decrement
5. Go to step 2
6. If false: Exit loop

### **Basic for Loop Examples:**

```csharp
// Example 1: Print numbers 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
// Output: 1 2 3 4 5

// Example 2: Print even numbers
for (int i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i);
}
// Output: 0 2 4 6 8 10

// Example 3: Countdown
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Blast off!");
// Output: 10 9 8 7 6 5 4 3 2 1 Blast off!

// Example 4: Sum of first 10 numbers
int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += i;
}
Console.WriteLine($"Sum: {sum}");  // 55

// Example 5: Multiplication table
int number = 5;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} × {i} = {number * i}");
}
// Output:
// 5 × 1 = 5
// 5 × 2 = 10
// ...
// 5 × 10 = 50

```

### **Nested for Loops:**

```csharp
// Example 1: Pattern printing
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
// Output:
// *
// * *
// * * *
// * * * *
// * * * * *

// Example 2: Multiplication table (1-5)
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}
// Output:
// 1  2  3  4  5
// 2  4  6  8  10
// 3  6  9  12 15
// 4  8  12 16 20
// 5  10 15 20 25

// Example 3: 2D matrix
for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write($"[{row},{col}] ");
    }
    Console.WriteLine();
}
// Output:
// [0,0] [0,1] [0,2]
// [1,0] [1,1] [1,2]
// [2,0] [2,1] [2,2]

```

### The while Loop

The **while loop** repeats as long as a condition is true.

**Syntax:**

```csharp
while (condition)
{
    // Code to repeat
    // Don't forget to update condition!
}

```

**Key Point:** Condition is checked BEFORE executing the body.

### **while Loop Examples:**

```csharp
// Example 1: Print numbers 1 to 5
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
// Output: 1 2 3 4 5

// Example 2: Sum until user enters 0
int sum = 0;
int num = -1;  // Initialize with non-zero

while (num != 0)
{
    Console.Write("Enter number (0 to stop): ");
    num = int.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine($"Total sum: {sum}");

// Example 3: Number guessing game
Random random = new Random();
int target = random.Next(1, 101);  // 1-100
int guess = 0;
int attempts = 0;

while (guess != target)
{
    Console.Write("Guess the number (1-100): ");
    guess = int.Parse(Console.ReadLine());
    attempts++;

    if (guess < target)
        Console.WriteLine("Too low!");
    else if (guess > target)
        Console.WriteLine("Too high!");
    else
        Console.WriteLine($"Correct! You guessed in {attempts} attempts.");
}

// Example 4: Factorial calculation
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());
int factorial = 1;
int count = n;

while (count > 0)
{
    factorial *= count;
    count--;
}
Console.WriteLine($"{n}! = {factorial}");

```

### The do-while Loop

The **do-while loop** executes at least once, then repeats while condition is true.

**Syntax:**

```csharp
do
{
    // Code to repeat
    // Executes at least once!
} while (condition);

```

**Key Difference:** Condition is checked AFTER executing the body.

### **do-while Loop Examples:**

```csharp
// Example 1: Print numbers 1 to 5
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);
// Output: 1 2 3 4 5

// Example 2: Menu (executes at least once)
int choice;
do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Exit");
    Console.Write("Enter choice: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("You selected Option 1");
            break;
        case 2:
            Console.WriteLine("You selected Option 2");
            break;
        case 3:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
} while (choice != 3);

// Example 3: Input validation
int age;
do
{
    Console.Write("Enter your age (1-120): ");
    age = int.Parse(Console.ReadLine());

    if (age < 1 || age > 120)
        Console.WriteLine("Invalid age! Try again.");
} while (age < 1 || age > 120);

Console.WriteLine($"Your age is {age}");

// Example 4: Password retry
string correctPassword = "secret123";
string enteredPassword;
int attempts = 0;
const int MAX_ATTEMPTS = 3;

do
{
    Console.Write("Enter password: ");
    enteredPassword = Console.ReadLine();
    attempts++;

    if (enteredPassword != correctPassword)
    {
        Console.WriteLine($"Wrong password! {MAX_ATTEMPTS - attempts} attempts remaining.");
    }
} while (enteredPassword != correctPassword && attempts < MAX_ATTEMPTS);

if (enteredPassword == correctPassword)
{
    Console.WriteLine("Access granted!");
}
else
{
    Console.WriteLine("Access denied! Too many failed attempts.");
}

```

### Comparison: for vs while vs do-while

| Feature | for | while | do-while |
| --- | --- | --- | --- |
| **Use When** | Know iteration count | Unknown iterations | Execute at least once |
| **Condition Check** | Before body | Before body | After body |
| **Minimum Executions** | 0 | 0 | 1 |
| **Syntax** | Compact | Simple | Simple |
| **Best For** | Counting | Condition-based | Menus, validation |

```csharp
// Equivalent loops (all print 1 to 5)

// for loop
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// while loop
int j = 1;
while (j <= 5)
{
    Console.WriteLine(j);
    j++;
}

// do-while loop
int k = 1;
do
{
    Console.WriteLine(k);
    k++;
} while (k <= 5);

```

### Loop Control Statements

### **break Statement**

Immediately exits the loop.

```csharp
// Example 1: Exit when found
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Found 5, stopping!");
        break;  // Exit loop
    }
    Console.WriteLine(i);
}
// Output: 1 2 3 4 Found 5, stopping!

// Example 2: Search in array
int[] numbers = { 10, 20, 30, 40, 50 };
int searchFor = 30;
bool found = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchFor)
    {
        Console.WriteLine($"Found {searchFor} at index {i}");
        found = true;
        break;  // No need to continue searching
    }
}

if (!found)
{
    Console.WriteLine($"{searchFor} not found");
}

```

### **continue Statement**

Skips the rest of current iteration and moves to next.

```csharp
// Example 1: Skip odd numbers
for (int i = 1; i <= 10; i++)
{
    if (i % 2 != 0)
    {
        continue;  // Skip odd numbers
    }
    Console.WriteLine(i);  // Only even numbers printed
}
// Output: 2 4 6 8 10

// Example 2: Skip negative numbers
int[] numbers = { 5, -2, 10, -7, 15, -3, 20 };

foreach (int num in numbers)
{
    if (num < 0)
    {
        continue;  // Skip negative
    }
    Console.WriteLine(num);
}
// Output: 5 10 15 20

// Example 3: Skip specific values
for (int i = 1; i <= 10; i++)
{
    if (i == 5 || i == 7)
    {
        continue;  // Skip 5 and 7
    }
    Console.WriteLine(i);
}
// Output: 1 2 3 4 6 8 9 10

```

### Infinite Loops

**Warning:** Infinite loops run forever if condition never becomes false!

```csharp
// ❌ Infinite loop (condition always true)
while (true)
{
    Console.WriteLine("This runs forever!");
    // No way to exit!
}

// ✅ Infinite loop with exit condition
while (true)
{
    Console.Write("Enter 'q' to quit: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        break;  // Exit the loop
    }

    Console.WriteLine("You entered: " + input);
}

// ❌ Common mistake - forgetting to update condition
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    // Forgot i++; - infinite loop!
}

// ✅ Correct - update loop variable
int j = 1;
while (j <= 5)
{
    Console.WriteLine(j);
    j++;  // Update condition
}

```

---

## 🎯 Student Tasks & Practice

### Task 1: Grade Calculator

```csharp
// Write a program that:
// 1. Accepts marks for 5 subjects
// 2. Calculates total and percentage
// 3. Determines grade using if-else if:
//    - >= 90: A
//    - >= 80: B
//    - >= 70: C
//    - >= 60: D
//    - < 60: F
// 4. Checks pass/fail (all subjects >= 40)

```

### Task 2: Simple ATM System

```csharp
// Create an ATM menu using switch:
// 1. Check Balance
// 2. Deposit Money
// 3. Withdraw Money
// 4. Exit
// Use do-while for menu loop
// Validate withdrawal (sufficient balance)

```

### Task 3: Number Pattern

```csharp
// Use nested for loops to print:
// 1
// 1 2
// 1 2 3
// 1 2 3 4
// 1 2 3 4 5

```

### Task 4: Prime Number Checker

```csharp
// Accept a number from user
// Check if it's prime using a loop
// Prime: divisible only by 1 and itself
// Hint: Check divisibility from 2 to n-1

```

### Task 5: Fibonacci Series

```csharp
// Print first n Fibonacci numbers
// Series: 0, 1, 1, 2, 3, 5, 8, 13, 21...
// Each number is sum of previous two
// Use any loop type

```

### Task 6: Multiplication Table

```csharp
// Print multiplication table from 1 to 10
// For each number 1-10, show table from 1-10
// Use nested loops
// Format output nicely

```

### Task 7: Palindrome Checker

```csharp
// Check if a number is palindrome
// Palindrome: reads same forwards and backwards
// Example: 121, 12321 are palindromes
// Use while loop to reverse digits

```

### Task 8: Sum of Digits

```csharp
// Accept a number
// Calculate sum of its digits
// Example: 1234 → 1+2+3+4 = 10
// Use while loop

```

### Task 9: Password Validator

```csharp
// Create password validation using if statements:
// - Minimum 8 characters
// - At least one uppercase letter
// - At least one lowercase letter
// - At least one digit
// Keep asking until valid password is entered (do-while)

```

### Task 10: Number Guessing Game

```csharp
// Computer generates random number (1-100)
// User guesses
// Provide hints: "Too high" or "Too low"
// Count attempts
// Use while loop until correct guess

```

---

## 🔍 Common Mistakes to Avoid

### 1. Missing Braces in if Statements

```csharp
// ❌ Dangerous
if (age >= 18)
    Console.WriteLine("Adult");
    Console.WriteLine("Can vote");  // Always executes!

// ✅ Safe
if (age >= 18)
{
    Console.WriteLine("Adult");
    Console.WriteLine("Can vote");
}

```

### 2. Using = Instead of == in Conditions

```csharp
// ❌ Assignment, not comparison
if (age = 18)  // Assigns 18 to age!
{
    Console.WriteLine("Adult");
}

// ✅ Correct comparison
if (age == 18)
{
    Console.WriteLine("Adult");
}

```

### 3. Forgetting break in switch

```csharp
// ❌ Compile error
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        // Missing break!
    case 2:
        Console.WriteLine("Tuesday");
        break;
}

// ✅ Correct
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
}

```

### 4. Infinite Loop - Forgetting to Update

```csharp
// ❌ Infinite loop
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    // Forgot i++!
}

// ✅ Correct
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}

```

### 5. Off-by-One Errors

```csharp
// ❌ Prints 0 to 9 (not 1 to 10)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// ✅ Prints 1 to 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

```

### 6. Semicolon After if/while

```csharp
// ❌ Empty if statement
if (age >= 18);  // Semicolon ends the if!
{
    Console.WriteLine("Adult");  // Always executes
}

// ✅ Correct
if (age >= 18)
{
    Console.WriteLine("Adult");
}

```

---

## 💡 Pro Tips

### 1. Use Descriptive Loop Variables

```csharp
// ❌ Not clear
for (int i = 0; i < students.Length; i++)

// ✅ More readable for nested loops
for (int studentIndex = 0; studentIndex < students.Length; studentIndex++)
for (int subjectIndex = 0; subjectIndex < subjects.Length; subjectIndex++)

```

### 2. Extract Complex Conditions

```csharp
// ❌ Hard to read
if (age >= 18 && age <= 65 && hasExperience && !isRetired && salary > 30000)

// ✅ Clearer
bool isWorkingAge = age >= 18 && age <= 65;
bool isQualified = hasExperience && !isRetired;
bool meetsIncome = salary > 30000;

if (isWorkingAge && isQualified && meetsIncome)

```

### 3. Prefer switch for Multiple Exact Matches

```csharp
// ❌ Too many if-else
if (day == "Monday") { }
else if (day == "Tuesday") { }
else if (day == "Wednesday") { }
// ...

// ✅ Cleaner with switch
switch (day)
{
    case "Monday": break;
    case "Tuesday": break;
    case "Wednesday": break;
}

```

### 4. Use foreach for Collections

```csharp
// ❌ More code
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

// ✅ Simpler (covered in next topic)
foreach (var item in array)
{
    Console.WriteLine(item);
}

```

### 5. Guard Clauses

```csharp
// ❌ Deep nesting
if (user != null)
{
    if (user.IsActive)
    {
        if (user.HasPermission)
        {
            // Do something
        }
    }
}

// ✅ Early returns (guard clauses)
if (user == null) return;
if (!user.IsActive) return;
if (!user.HasPermission) return;

// Do something

```

---

## 📖 Key Takeaways

✅ **if statements** execute code conditionally based on boolean expressions

✅ **if-else** provides alternative path when condition is false

✅ **if-else if-else** checks multiple conditions sequentially (first true wins)

✅ **switch statements** are cleaner for checking one variable against multiple values

✅ **for loops** are best when you know the iteration count

✅ **while loops** repeat while condition is true (checked before body)

✅ **do-while loops** execute at least once (checked after body)

✅ **break** exits a loop immediately

✅ **continue** skips to next iteration

✅ **Always use braces** with if statements to avoid bugs

✅ **Don't forget break** in switch cases (required in C#)

✅ **Watch for infinite loops** - ensure loop condition can become false

---

## 📚 Complete Working Examples

### Example 1: Student Management System

```csharp
using System;

class StudentManagement
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== STUDENT MANAGEMENT SYSTEM ===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Calculate Grade");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input!");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n--- Add Student ---");
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter roll number: ");
                    int roll = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Student {name} (Roll: {roll}) added!");
                    break;

                case 2:
                    Console.WriteLine("\n--- View Students ---");
                    Console.WriteLine("List of students displayed here...");
                    break;

                case 3:
                    Console.WriteLine("\n--- Calculate Grade ---");
                    Console.Write("Enter marks: ");
                    double marks = double.Parse(Console.ReadLine());

                    char grade;
                    if (marks >= 90)
                        grade = 'A';
                    else if (marks >= 80)
                        grade = 'B';
                    else if (marks >= 70)
                        grade = 'C';
                    else if (marks >= 60)
                        grade = 'D';
                    else
                        grade = 'F';

                    Console.WriteLine($"Grade: {grade}");

                    if (marks >= 40)
                        Console.WriteLine("Status: PASS");
                    else
                        Console.WriteLine("Status: FAIL");
                    break;

                case 4:
                    Console.WriteLine("Exiting... Goodbye!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}

```

### Example 2: Number Pattern Generator

```csharp
using System;

class PatternGenerator
{
    static void Main()
    {
        Console.WriteLine("=== PATTERN GENERATOR ===\n");

        // Pattern 1: Right triangle
        Console.WriteLine("Pattern 1: Right Triangle");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Pattern 2: Number pyramid
        Console.WriteLine("Pattern 2: Number Pyramid");
        for (int i = 1; i <= 5; i++)
        {
            // Print spaces
            for (int j = 1; j <= 5 - i; j++)
            {
                Console.Write(" ");
            }

            // Print numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Pattern 3: Diamond
        Console.WriteLine("Pattern 3: Diamond");
        int n = 5;

        // Upper half
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");
            Console.WriteLine();
        }

        // Lower half
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (int j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}

```

### Example 3: Number Analysis Program

```csharp
using System;

class NumberAnalysis
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;

        // Count digits
        int digitCount = 0;
        int temp = number;
        while (temp > 0)
        {
            digitCount++;
            temp /= 10;
        }

        // Sum of digits
        int sumOfDigits = 0;
        temp = number;
        while (temp > 0)
        {
            sumOfDigits += temp % 10;
            temp /= 10;
        }

        // Reverse number
        int reversed = 0;
        temp = number;
        while (temp > 0)
        {
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }

        // Check palindrome
        bool isPalindrome = (originalNumber == reversed);

        // Check prime
        bool isPrime = true;
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        // Check even/odd
        bool isEven = (number % 2 == 0);

        // Display results
        Console.WriteLine($"\n=== Analysis of {originalNumber} ===");
        Console.WriteLine($"Number of digits: {digitCount}");
        Console.WriteLine($"Sum of digits: {sumOfDigits}");
        Console.WriteLine($"Reversed number: {reversed}");
        Console.WriteLine($"Is palindrome: {(isPalindrome ? "Yes" : "No")}");
        Console.WriteLine($"Is prime: {(isPrime ? "Yes" : "No")}");
        Console.WriteLine($"Is even: {(isEven ? "Even" : "Odd")}");

        Console.ReadKey();
    }
}

```

---

## 🔗 Additional Resources

- [C# if-else Documentation](https://docs.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements)
- [C# switch Documentation](https://docs.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement)
- [C# Loops Documentation](https://docs.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements)

---
