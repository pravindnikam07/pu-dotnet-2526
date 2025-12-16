## Topic 1: Operators and Expressions in C#

## 📚 Topic 4.1: Arithmetic Operators

Arithmetic operators perform mathematical calculations on numeric values.

### Basic Arithmetic Operators

| Operator | Name | Description | Example |
| --- | --- | --- | --- |
| **+** | Addition | Adds two values | `5 + 3 = 8` |
| **-** | Subtraction | Subtracts right from left | `5 - 3 = 2` |
| ***** | Multiplication | Multiplies two values | `5 * 3 = 15` |
| **/** | Division | Divides left by right | `10 / 2 = 5` |
| **%** | Modulus | Returns remainder | `10 % 3 = 1` |

### Addition (+)

```csharp
// Integer addition
int a = 10;
int b = 5;
int sum = a + b;
Console.WriteLine(sum);  // 15

// Floating-point addition
double x = 10.5;
double y = 3.2;
double total = x + y;
Console.WriteLine(total);  // 13.7

// String concatenation (special case)
string firstName = "Raj";
string lastName = "Kumar";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);  // "Raj Kumar"

// Mixed types (automatic conversion)
int num = 10;
double dec = 5.5;
double result = num + dec;  // int promoted to double
Console.WriteLine(result);  // 15.5

```

### Subtraction (-)

```csharp
// Basic subtraction
int a = 20;
int b = 8;
int difference = a - b;
Console.WriteLine(difference);  // 12

// With negative numbers
int x = 5;
int y = -3;
int result = x - y;  // 5 - (-3) = 5 + 3
Console.WriteLine(result);  // 8

// Temperature difference
double tempMorning = 15.5;
double tempEvening = 22.3;
double change = tempEvening - tempMorning;
Console.WriteLine($"Temperature increased by {change}°C");  // 6.8°C

```

### Multiplication (*)

```csharp
// Basic multiplication
int quantity = 5;
int pricePerItem = 100;
int totalPrice = quantity * pricePerItem;
Console.WriteLine(totalPrice);  // 500

// Area calculation
double length = 10.5;
double width = 8.2;
double area = length * width;
Console.WriteLine($"Area: {area} sq meters");  // 86.1

// Scientific notation
double distance = 3.0e8;  // 3 × 10^8 (speed of light)
double time = 2.0;
double totalDistance = distance * time;
Console.WriteLine(totalDistance);  // 600000000

```

### Division (/)

```csharp
// Integer division (truncates decimal)
int a = 10;
int b = 3;
int quotient = a / b;
Console.WriteLine(quotient);  // 3 (not 3.333...)

// Floating-point division
double x = 10.0;
double y = 3.0;
double result = x / y;
Console.WriteLine(result);  // 3.333333...

// Mixed division (int / double)
int num = 10;
double divisor = 3.0;
double answer = num / divisor;  // int promoted to double
Console.WriteLine(answer);  // 3.333333...

// Avoiding integer division
int p = 10;
int q = 3;
double properResult = (double)p / q;  // Cast to double
Console.WriteLine(properResult);  // 3.333333...

// Division by zero (runtime error with integers)
try
{
    int bad = 10 / 0;  // Throws DivideByZeroException
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero!");
}

// Division by zero with floating-point (returns Infinity)
double floatResult = 10.0 / 0.0;
Console.WriteLine(floatResult);  // Infinity
Console.WriteLine(double.IsInfinity(floatResult));  // True

```

### Modulus (%)

The modulus operator returns the **remainder** after division.

```csharp
// Basic modulus
int a = 10;
int b = 3;
int remainder = a % b;
Console.WriteLine(remainder);  // 1 (10 ÷ 3 = 3 remainder 1)

// Check if even or odd
int number = 17;
if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");  // This executes
}

// Clock arithmetic (wrapping around)
int hours = 15;  // 3 PM in 24-hour format
int displayHours = hours % 12;  // Convert to 12-hour
if (displayHours == 0) displayHours = 12;
Console.WriteLine($"{displayHours} PM");  // 3 PM

// Cycling through array indices
int[] colors = { 0, 1, 2, 3, 4 };  // 5 colors
int currentIndex = 17;
int actualIndex = currentIndex % 5;
Console.WriteLine(actualIndex);  // 2 (17 % 5 = 2)

// Check divisibility
int num = 20;
if (num % 5 == 0)
{
    Console.WriteLine($"{num} is divisible by 5");
}

```

### Practical Examples

### **Example 1: Simple Calculator**

```csharp
Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter operator (+, -, *, /, %): ");
char op = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());

double result = 0;

switch (op)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
            result = num1 / num2;
        else
            Console.WriteLine("Error: Division by zero!");
        break;
    case '%':
        result = num1 % num2;
        break;
    default:
        Console.WriteLine("Invalid operator!");
        return;
}

Console.WriteLine($"{num1} {op} {num2} = {result}");

```

### **Example 2: Time Conversion**

```csharp
// Convert total seconds to hours, minutes, seconds
int totalSeconds = 3665;

int hours = totalSeconds / 3600;
int remainingSeconds = totalSeconds % 3600;
int minutes = remainingSeconds / 60;
int seconds = remainingSeconds % 60;

Console.WriteLine($"{totalSeconds} seconds = {hours}h {minutes}m {seconds}s");
// Output: 3665 seconds = 1h 1m 5s

```

### **Example 3: Bill Splitter**

```csharp
double totalBill = 1250.75;
int numberOfPeople = 4;

double perPersonAmount = totalBill / numberOfPeople;
Console.WriteLine($"Each person pays: ₹{perPersonAmount:F2}");
// Output: Each person pays: ₹312.69

```

---

## 📚 Topic 4.2: Relational and Logical Operators

### Relational Operators (Comparison)

Relational operators compare two values and return **true** or **false**.

| Operator | Name | Description | Example |
| --- | --- | --- | --- |
| **==** | Equal to | Checks if equal | `5 == 5` → true |
| **!=** | Not equal to | Checks if not equal | `5 != 3` → true |
| **>** | Greater than | Left > Right | `5 > 3` → true |
| **<** | Less than | Left < Right | `3 < 5` → true |
| **>=** | Greater than or equal | Left >= Right | `5 >= 5` → true |
| **<=** | Less than or equal | Left <= Right | `3 <= 5` → true |

### **Examples:**

```csharp
int a = 10;
int b = 5;

// Equal to
bool isEqual = (a == b);
Console.WriteLine(isEqual);  // False

// Not equal to
bool notEqual = (a != b);
Console.WriteLine(notEqual);  // True

// Greater than
bool greater = (a > b);
Console.WriteLine(greater);  // True

// Less than
bool less = (a < b);
Console.WriteLine(less);  // False

// Greater than or equal
bool greaterEqual = (a >= 10);
Console.WriteLine(greaterEqual);  // True

// Less than or equal
bool lessEqual = (b <= 5);
Console.WriteLine(lessEqual);  // True

// Chaining comparisons (each returns bool)
int x = 5;
bool inRange = (x >= 1 && x <= 10);  // Check if x is between 1 and 10
Console.WriteLine(inRange);  // True

```

### **Common Use Cases:**

```csharp
// Age verification
int age = 20;
bool canVote = (age >= 18);
Console.WriteLine($"Can vote: {canVote}");  // True

// Grade checking
int marks = 85;
bool isPassing = (marks >= 40);
bool isExcellent = (marks >= 90);

// Temperature check
double temp = 38.5;
bool hasFever = (temp > 37.0);
Console.WriteLine($"Has fever: {hasFever}");  // True

// String comparison
string name1 = "Raj";
string name2 = "raj";
bool sameName = (name1 == name2);
Console.WriteLine(sameName);  // False (case-sensitive)

// Case-insensitive comparison
bool sameNameIgnoreCase = name1.Equals(name2, StringComparison.OrdinalIgnoreCase);
Console.WriteLine(sameNameIgnoreCase);  // True

```

### Logical Operators

Logical operators combine multiple boolean expressions.

| Operator | Name | Description | Example |
| --- | --- | --- | --- |
| **&&** | Logical AND | Both must be true | `true && true` → true |
| **||** | Logical OR | At least one true | `true || false` → true |
| **!** | Logical NOT | Inverts boolean | `!true` → false |

### **AND Operator (&&)**

Both conditions must be **true** for the result to be **true**.

**Truth Table:**

```
A     | B     | A && B
------|-------|--------
true  | true  | true
true  | false | false
false | true  | false
false | false | false

```

```csharp
// Both conditions must be true
int age = 20;
bool hasLicense = true;

bool canDrive = (age >= 18) && hasLicense;
Console.WriteLine(canDrive);  // True

// Loan eligibility
int salary = 50000;
int creditScore = 750;

bool eligibleForLoan = (salary >= 30000) && (creditScore >= 700);
Console.WriteLine(eligibleForLoan);  // True

// Range checking
int marks = 85;
bool isGradeA = (marks >= 80) && (marks <= 100);
Console.WriteLine(isGradeA);  // True

// Short-circuit evaluation
int x = 5;
if (x != 0 && 10 / x > 1)  // First check prevents division by zero
{
    Console.WriteLine("Safe division");
}

```

### **OR Operator (||)**

At least **one** condition must be **true** for the result to be **true**.

**Truth Table:**

```
A     | B     | A || B
------|-------|--------
true  | true  | true
true  | false | true
false | true  | true
false | false | false

```

```csharp
// At least one condition must be true
bool isWeekend = false;
bool isHoliday = true;

bool canRelax = isWeekend || isHoliday;
Console.WriteLine(canRelax);  // True

// Login check (username OR email)
string input = "raj@email.com";
bool validLogin = input.Contains("@") || input.Length == 10;
Console.WriteLine(validLogin);  // True

// Discount eligibility (student OR senior citizen)
bool isStudent = true;
int age = 25;
bool getDiscount = isStudent || (age >= 60);
Console.WriteLine(getDiscount);  // True

// Multiple conditions
int day = 7;  // Sunday
bool isRestDay = (day == 6) || (day == 7);  // Saturday or Sunday
Console.WriteLine(isRestDay);  // True

```

### **NOT Operator (!)**

**Inverts** the boolean value (true becomes false, false becomes true).

```csharp
// Basic NOT
bool isRaining = false;
bool isSunny = !isRaining;
Console.WriteLine(isSunny);  // True

// Double NOT (back to original)
bool value = true;
bool result = !!value;
Console.WriteLine(result);  // True

// NOT with conditions
int age = 15;
bool isMinor = !(age >= 18);
Console.WriteLine(isMinor);  // True

// Checking for invalid data
string username = "";
bool isInvalid = string.IsNullOrEmpty(username);
bool isValid = !isInvalid;
Console.WriteLine(isValid);  // False

// NOT with AND
bool hasMembership = false;
bool paidFee = true;
bool cannotEnter = !hasMembership && !paidFee;
Console.WriteLine(cannotEnter);  // False

```

### **Combining Logical Operators**

```csharp
// Complex conditions
int age = 25;
int experience = 3;
bool hasReference = true;

// Job eligibility: (age 22-35 AND experience >= 2) OR has reference
bool eligible = ((age >= 22 && age <= 35) && experience >= 2) || hasReference;
Console.WriteLine(eligible);  // True

// Admission criteria
int marks = 75;
bool isSports = false;
bool isMinority = false;

// Admission: marks >= 70 AND (sports OR minority quota)
bool admitted = (marks >= 70) && (isSports || isMinority);
Console.WriteLine(admitted);  // False

// Parentheses for clarity
bool condition = (true || false) && (true && !false);
Console.WriteLine(condition);  // True

```

### Short-Circuit Evaluation

**Important:** && and || use short-circuit evaluation.

```csharp
// AND short-circuit: If first is false, second is not evaluated
int x = 0;
bool result1 = (x != 0) && (10 / x > 1);  // Second part not executed (prevents error)
Console.WriteLine(result1);  // False

// OR short-circuit: If first is true, second is not evaluated
bool hasPermission = true;
bool result2 = hasPermission || CheckDatabase();  // CheckDatabase() not called
Console.WriteLine(result2);  // True

// Using this for null checking
string name = null;
if (name != null && name.Length > 0)  // Safe - second part not evaluated if name is null
{
    Console.WriteLine(name);
}

```

---

## 📚 Topic 4.3: Assignment and Compound Assignment Operators

### Simple Assignment (=)

```csharp
// Basic assignment
int age = 20;
string name = "Raj";
double price = 99.99;

// Multiple assignments
int a, b, c;
a = b = c = 10;  // All get value 10

// Swap values using temporary variable
int x = 5, y = 10;
int temp = x;
x = y;
y = temp;
Console.WriteLine($"x = {x}, y = {y}");  // x = 10, y = 5

// Swap without temporary (arithmetic)
int p = 5, q = 10;
p = p + q;  // p = 15
q = p - q;  // q = 5
p = p - q;  // p = 10
Console.WriteLine($"p = {p}, q = {q}");  // p = 10, q = 5

```

### Compound Assignment Operators

Compound operators perform an operation and assignment in one step.

| Operator | Equivalent | Example | Result |
| --- | --- | --- | --- |
| **+=** | a = a + b | `x += 5` | x = x + 5 |
| **-=** | a = a - b | `x -= 3` | x = x - 3 |
| ***=** | a = a * b | `x *= 2` | x = x * 2 |
| **/=** | a = a / b | `x /= 4` | x = x / 4 |
| **%=** | a = a % b | `x %= 3` | x = x % 3 |

### **Addition Assignment (+=)**

```csharp
// Basic usage
int score = 100;
score += 50;  // Same as: score = score + 50;
Console.WriteLine(score);  // 150

// Accumulating in loop
int total = 0;
for (int i = 1; i <= 5; i++)
{
    total += i;  // total = total + i
}
Console.WriteLine(total);  // 15 (1+2+3+4+5)

// String concatenation
string message = "Hello";
message += " World";  // Same as: message = message + " World";
Console.WriteLine(message);  // "Hello World"

// Accumulating salary
double salary = 50000;
salary += 5000;  // Increment
Console.WriteLine(salary);  // 55000

```

### **Subtraction Assignment (-=)**

```csharp
// Reducing inventory
int stock = 100;
stock -= 15;  // Same as: stock = stock - 15;
Console.WriteLine(stock);  // 85

// Countdown
int timer = 60;
timer -= 1;
Console.WriteLine(timer);  // 59

// Reducing balance
double balance = 1000.50;
balance -= 250.25;
Console.WriteLine(balance);  // 750.25

```

### **Multiplication Assignment (*=)**

```csharp
// Doubling value
int number = 5;
number *= 2;  // Same as: number = number * 2;
Console.WriteLine(number);  // 10

// Compound interest calculation
double amount = 1000;
amount *= 1.05;  // 5% increase
Console.WriteLine(amount);  // 1050

// Scaling
int size = 10;
size *= 3;
Console.WriteLine(size);  // 30

```

### **Division Assignment (/=)**

```csharp
// Halving value
int number = 100;
number /= 2;  // Same as: number = number / 2;
Console.WriteLine(number);  // 50

// Average calculation
int sum = 100;
int count = 4;
sum /= count;  // sum = sum / count
Console.WriteLine(sum);  // 25

// Splitting
double total = 1000.0;
total /= 5;
Console.WriteLine(total);  // 200

```

### **Modulus Assignment (%=)**

```csharp
// Keeping within range
int value = 17;
value %= 10;  // Same as: value = value % 10;
Console.WriteLine(value);  // 7

// Circular buffer
int index = 25;
index %= 5;  // Keep within 0-4
Console.WriteLine(index);  // 0

// Extract last digit
int number = 12345;
number %= 10;
Console.WriteLine(number);  // 5

```

### Practical Examples

```csharp
// Example 1: Shopping cart total
double cartTotal = 0;
cartTotal += 99.99;   // Add item 1
cartTotal += 149.50;  // Add item 2
cartTotal += 49.99;   // Add item 3
Console.WriteLine($"Total: ₹{cartTotal}");  // 299.48

// Example 2: Game score
int playerScore = 0;
playerScore += 10;  // Kill enemy
playerScore += 50;  // Complete level
playerScore -= 5;   // Hit by enemy
playerScore *= 2;   // Score multiplier
Console.WriteLine($"Final Score: {playerScore}");  // 110

// Example 3: Bank account
double balance = 5000;
balance += 2000;  // Deposit
balance -= 1500;  // Withdrawal
balance *= 1.03;  // 3% interest
Console.WriteLine($"Balance: ₹{balance:F2}");  // 5665.00

```

---

## 📚 Topic 4.4: Increment, Decrement, and Ternary Operators

### Increment Operator (++)

Increases value by 1.

### **Post-Increment (x++)**

Use value first, then increment.

```csharp
int x = 5;
int y = x++;  // y gets 5, then x becomes 6

Console.WriteLine($"x = {x}");  // 6
Console.WriteLine($"y = {y}");  // 5

```

### **Pre-Increment (++x)**

Increment first, then use value.

```csharp
int x = 5;
int y = ++x;  // x becomes 6, then y gets 6

Console.WriteLine($"x = {x}");  // 6
Console.WriteLine($"y = {y}");  // 6

```

### **Comparison:**

```csharp
// Post-increment
int a = 10;
Console.WriteLine(a++);  // Prints 10, then a becomes 11
Console.WriteLine(a);    // Prints 11

// Pre-increment
int b = 10;
Console.WriteLine(++b);  // b becomes 11, then prints 11
Console.WriteLine(b);    // Prints 11

```

### **In Loops:**

```csharp
// Common usage in for loop
for (int i = 0; i < 5; i++)  // Post-increment
{
    Console.WriteLine(i);
}
// Output: 0 1 2 3 4

// Both work the same in for loops
for (int i = 0; i < 5; ++i)  // Pre-increment
{
    Console.WriteLine(i);
}
// Output: 0 1 2 3 4

```

### Decrement Operator (--)

Decreases value by 1.

### **Post-Decrement (x--)**

```csharp
int x = 5;
int y = x--;  // y gets 5, then x becomes 4

Console.WriteLine($"x = {x}");  // 4
Console.WriteLine($"y = {y}");  // 5

```

### **Pre-Decrement (--x)**

```csharp
int x = 5;
int y = --x;  // x becomes 4, then y gets 4

Console.WriteLine($"x = {x}");  // 4
Console.WriteLine($"y = {y}");  // 4

```

### **Practical Examples:**

```csharp
// Countdown timer
int countdown = 10;
while (countdown > 0)
{
    Console.WriteLine(countdown--);  // Print then decrement
}
// Output: 10 9 8 7 6 5 4 3 2 1

// Lives in game
int lives = 3;
Console.WriteLine($"Lives remaining: {--lives}");  // 2
Console.WriteLine($"Lives remaining: {--lives}");  // 1
Console.WriteLine($"Lives remaining: {--lives}");  // 0
Console.WriteLine("Game Over!");

// Array traversal backward
int[] numbers = { 10, 20, 30, 40, 50 };
int index = numbers.Length - 1;
while (index >= 0)
{
    Console.WriteLine(numbers[index--]);
}
// Output: 50 40 30 20 10

```

### Ternary Operator (?:)

The ternary operator is a shorthand for if-else statements.

**Syntax:**

```csharp
condition ? valueIfTrue : valueIfFalse

```

### **Basic Examples:**

```csharp
// Simple ternary
int age = 20;
string status = (age >= 18) ? "Adult" : "Minor";
Console.WriteLine(status);  // "Adult"

// Equivalent if-else
string status2;
if (age >= 18)
{
    status2 = "Adult";
}
else
{
    status2 = "Minor";
}

// Finding maximum
int a = 10, b = 20;
int max = (a > b) ? a : b;
Console.WriteLine($"Max: {max}");  // 20

// Finding minimum
int min = (a < b) ? a : b;
Console.WriteLine($"Min: {min}");  // 10

// Even or odd
int number = 17;
string parity = (number % 2 == 0) ? "Even" : "Odd";
Console.WriteLine(parity);  // "Odd"

```

### **Nested Ternary (Use Carefully):**

```csharp
// Grade assignment
int marks = 85;
string grade = (marks >= 90) ? "A" :
               (marks >= 80) ? "B" :
               (marks >= 70) ? "C" :
               (marks >= 60) ? "D" : "F";
Console.WriteLine($"Grade: {grade}");  // "B"

// Better readability with if-else for complex cases
string grade2;
if (marks >= 90)
    grade2 = "A";
else if (marks >= 80)
    grade2 = "B";
else if (marks >= 70)
    grade2 = "C";
else if (marks >= 60)
    grade2 = "D";
else
    grade2 = "F";

```

### **Practical Uses:**

```csharp
// Display message based on time
int hour = 14;
string greeting = (hour < 12) ? "Good Morning" :
                  (hour < 18) ? "Good Afternoon" : "Good Evening";
Console.WriteLine(greeting);  // "Good Afternoon"

// Discount calculation
double price = 1000;
bool isMember = true;
double finalPrice = isMember ? (price * 0.9) : price;  // 10% discount for members
Console.WriteLine($"Price: ₹{finalPrice}");  // 900

// Null coalescing with ternary
string username = null;
string display = (username != null) ? username : "Guest";
Console.WriteLine($"Welcome, {display}");  // "Welcome, Guest"

// Sign determination
int value = -5;
string sign = (value > 0) ? "Positive" : (value < 0) ? "Negative" : "Zero";
Console.WriteLine(sign);  // "Negative"

```

---

## 📚 Topic 4.5: Operator Precedence

Operator precedence determines the order in which operators are evaluated in an expression.

### Precedence Table (High to Low)

| Priority | Operators | Description | Example |
| --- | --- | --- | --- |
| **1 (Highest)** | `()` | Parentheses | `(a + b)` |
| **2** | `++`, `--`, `!` | Unary operators | `++x`, `--y`, `!flag` |
| **3** | `*`, `/`, `%` | Multiplicative | `a * b / c` |
| **4** | `+`, `-` | Additive | `a + b - c` |
| **5** | `<`, `<=`, `>`, `>=` | Relational | `a < b` |
| **6** | `==`, `!=` | Equality | `a == b` |
| **7** | `&&` | Logical AND | `a && b` |
| **8** | ` |  | ` |
| **9** | `?:` | Ternary | `a ? b : c` |
| **10 (Lowest)** | `=`, `+=`, `-=`, etc. | Assignment | `a = b` |

### Examples Without Parentheses

```csharp
// Multiplication before addition
int result1 = 2 + 3 * 4;
Console.WriteLine(result1);  // 14 (not 20)
// Evaluation: 2 + (3 * 4) = 2 + 12 = 14

// Division before subtraction
int result2 = 10 - 8 / 2;
Console.WriteLine(result2);  // 6 (not 1)
// Evaluation: 10 - (8 / 2) = 10 - 4 = 6

// Multiple operators
int result3 = 10 + 5 * 2 - 3;
Console.WriteLine(result3);  // 17
// Evaluation: 10 + (5 * 2) - 3 = 10 + 10 - 3 = 17

// Mixed operators
int result4 = 20 / 4 + 3 * 2;
Console.WriteLine(result4);  // 11
// Evaluation: (20 / 4) + (3 * 2) = 5 + 6 = 11

```

### Using Parentheses for Clarity

```csharp
// Force addition first
int result1 = (2 + 3) * 4;
Console.WriteLine(result1);  // 20
// Evaluation: (2 + 3) * 4 = 5 * 4 = 20

// Force subtraction first
int result2 = (10 - 8) / 2;
Console.WriteLine(result2);  // 1
// Evaluation: (10 - 8) / 2 = 2 / 2 = 1

// Multiple parentheses
int result3 = ((10 + 5) * 2) - 3;
Console.WriteLine(result3);  // 27
// Evaluation: ((10 + 5) * 2) - 3 = (15 * 2) - 3 = 30 - 3 = 27

// Complex expression
int result4 = (20 / (4 + 1)) * 2;
Console.WriteLine(result4);  // 8
// Evaluation: (20 / (4 + 1)) * 2 = (20 / 5) * 2 = 4 * 2 = 8

```

### Logical Operator Precedence

```csharp
// && has higher precedence than ||
bool result1 = true || false && false;
Console.WriteLine(result1);  // True
// Evaluation: true || (false && false) = true || false = true

// Using parentheses to change order
bool result2 = (true || false) && false;
Console.WriteLine(result2);  // False
// Evaluation: (true || false) && false = true && false = false

// Complex boolean expression
bool a = true, b = false, c = true;
bool result3 = a || b && c;
Console.WriteLine(result3);  // True
// Evaluation: a || (b && c) = true || (false && true) = true

// With parentheses for clarity
bool result4 = (a || b) && c;
Console.WriteLine(result4);  // True
// Evaluation: (true || false) && true = true && true = true

```

### Assignment Operator Precedence

```csharp
// Assignment has lowest precedence
int x = 5 + 3;  // Addition happens first, then assignment
Console.WriteLine(x);  // 8

// Right-to-left associativity
int a, b, c;
a = b = c = 10;  // Evaluated right to left: c=10, b=c, a=b
Console.WriteLine($"a={a}, b={b}, c={c}");  // a=10, b=10, c=10

// With compound operators
int y = 5;
y += 3 * 2;  // Multiplication first: y = y + (3 * 2) = 5 + 6 = 11
Console.WriteLine(y);  // 11

```

### Common Mistakes and Best Practices

```csharp
// ❌ MISTAKE 1: Forgetting precedence
int wrong = 10 + 5 * 2;  // Might expect 30, but gets 20
Console.WriteLine(wrong);  // 20

// ✅ CORRECT: Use parentheses for intended order
int correct = (10 + 5) * 2;
Console.WriteLine(correct);  // 30

// ❌ MISTAKE 2: Complex boolean without parentheses
bool result = true || false && false;  // Confusing!

// ✅ CORRECT: Use parentheses for clarity
bool clearResult = true || (false && false);

// ❌ MISTAKE 3: Mixing relational and logical
int age = 20;
bool invalid = age >= 18 && <= 65;  // SYNTAX ERROR

// ✅ CORRECT: Complete both conditions
bool valid = (age >= 18) && (age <= 65);

// ❌ MISTAKE 4: Division with integers
double bad = 5 / 2;  // Gives 2.0, not 2.5
Console.WriteLine(bad);  // 2.0

// ✅ CORRECT: Cast to double
double good = 5.0 / 2;  // or (double)5 / 2
Console.WriteLine(good);  // 2.5

```

### Real-World Examples

### **Example 1: Formula Calculation**

```csharp
// Area of trapezoid: A = ((a + b) / 2) * h
double a = 5.0, b = 7.0, h = 4.0;

// Without parentheses (WRONG)
double wrongArea = a + b / 2 * h;
Console.WriteLine(wrongArea);  // 19.0 (incorrect!)

// With parentheses (CORRECT)
double correctArea = ((a + b) / 2) * h;
Console.WriteLine(correctArea);  // 24.0 (correct!)

```

### **Example 2: Discount Calculation**

```csharp
double price = 100;
double discount = 20;  // 20%
double tax = 18;       // 18%

// Calculate final price: (price - discount%) + tax%
// WRONG: Order matters!
double wrong = price - discount / 100 * price + tax / 100 * price;
Console.WriteLine(wrong);  // 98.0 (incorrect)

// CORRECT: Use clear parentheses
double discountAmount = (discount / 100) * price;
double priceAfterDiscount = price - discountAmount;
double taxAmount = (tax / 100) * priceAfterDiscount;
double finalPrice = priceAfterDiscount + taxAmount;
Console.WriteLine(finalPrice);  // 94.4 (correct!)

// Or more concise with proper parentheses
double final = (price * (1 - discount / 100)) * (1 + tax / 100);
Console.WriteLine(final);  // 94.4

```

### **Example 3: Temperature Check**

```csharp
double temp = 37.5;
bool isFever = temp > 37.0;
bool isCritical = temp > 40.0;

// Check if needs doctor: fever but not critical
bool needsDoctor = isFever && !isCritical;
Console.WriteLine(needsDoctor);  // True

// Or in one expression with clear parentheses
bool needs = (temp > 37.0) && !(temp > 40.0);
Console.WriteLine(needs);  // True

```

---

## 🎯 Student Tasks & Practice

### Task 1: Basic Arithmetic

Create a program that:

```csharp
// Accept two numbers from user
// Perform all arithmetic operations (+, -, *, /, %)
// Display results in a formatted manner

// Example Output:
// Enter first number: 10
// Enter second number: 3
// 10 + 3 = 13
// 10 - 3 = 7
// 10 * 3 = 30
// 10 / 3 = 3.333333
// 10 % 3 = 1

```

### Task 2: Temperature Converter

```csharp
// Create a program that:
// 1. Accepts temperature in Celsius
// 2. Converts to Fahrenheit and Kelvin
// 3. Determines if temperature is:
//    - Below freezing (< 0°C)
//    - Room temperature (20-25°C)
//    - Body temperature (37°C)
//    - Boiling point (100°C)

// Formulas:
// Fahrenheit = (Celsius × 9/5) + 32
// Kelvin = Celsius + 273.15

```

### Task 3: Leap Year Checker

```csharp
// A year is a leap year if:
// 1. Divisible by 4 AND not divisible by 100
//    OR
// 2. Divisible by 400

// Examples:
// 2020 → Leap year (divisible by 4, not by 100)
// 1900 → Not leap year (divisible by 100, not by 400)
// 2000 → Leap year (divisible by 400)

// Use relational and logical operators

```

### Task 4: Grade Calculator

```csharp
// Accept marks for 5 subjects
// Calculate:
// - Total marks
// - Percentage
// - Grade using ternary operator:
//   >= 90: A
//   >= 80: B
//   >= 70: C
//   >= 60: D
//   < 60: F
// Display all results

```

### Task 5: Even/Odd Counter

```csharp
// Accept 10 numbers from user
// Use increment operators to count:
// - How many are even
// - How many are odd
// Display the counts

```

### Task 6: Simple Interest Calculator

```csharp
// Formula: SI = (P * R * T) / 100
// P = Principal amount
// R = Rate of interest (%)
// T = Time (years)

// Calculate both Simple Interest and Amount
// Amount = Principal + Simple Interest

// Test precedence: ensure formula is correct!

```

### Task 7: BMI Calculator

```csharp
// BMI = weight (kg) / (height (m))²
// Categories:
// < 18.5: Underweight
// 18.5 - 24.9: Normal
// 25 - 29.9: Overweight
// >= 30: Obese

// Use relational and logical operators

```

### Task 8: Operator Precedence Quiz

Evaluate these expressions manually, then verify with code:

```csharp
// What will these print?
Console.WriteLine(10 + 5 * 2);           // ?
Console.WriteLine((10 + 5) * 2);         // ?
Console.WriteLine(20 - 10 / 2);          // ?
Console.WriteLine((20 - 10) / 2);        // ?
Console.WriteLine(5 + 3 * 2 - 1);        // ?
Console.WriteLine(true || false && false); // ?
Console.WriteLine((true || false) && false); // ?

```

### Task 9: Swap Numbers

Create three different methods to swap two numbers:

```csharp
// Method 1: Using temporary variable
// Method 2: Using arithmetic operations (+ and -)
// Method 3: Using compound assignment operators

// Input: a = 5, b = 10
// Output: a = 10, b = 5

```

### Task 10: Discount Calculator

```csharp
// Product price: Get from user
// Discount rules using logical operators:
// - If price > 1000 AND customer is member: 20% discount
// - If price > 1000 OR customer is member: 10% discount
// - If price > 500: 5% discount
// - Otherwise: No discount

// Calculate final price after discount and 18% tax
// Use proper operator precedence

```

---

## 🔍 Common Mistakes to Avoid

### 1. Integer Division Trap

```csharp
// ❌ Wrong
int result = 5 / 2;
Console.WriteLine(result);  // 2 (not 2.5!)

// ✅ Correct
double result = 5.0 / 2;
// or
double result = (double)5 / 2;
Console.WriteLine(result);  // 2.5

```

### 2. Modulus with Negative Numbers

```csharp
// Be careful with negative numbers
Console.WriteLine(10 % 3);    // 1
Console.WriteLine(-10 % 3);   // -1 (not 2!)
Console.WriteLine(10 % -3);   // 1
Console.WriteLine(-10 % -3);  // -1

```

### 3. Post vs Pre Increment in Expressions

```csharp
// ❌ Confusing
int x = 5;
int y = x++ + ++x;  // Very confusing! Avoid this.
Console.WriteLine(y);  // 12 (but hard to understand)

// ✅ Clear
int a = 5;
a++;      // First operation
int b = a;
a++;      // Second operation
int c = b + a;  // Clear and readable

```

### 4. Precedence Without Parentheses

```csharp
// ❌ Unclear
bool result = age >= 18 && age <= 65 || hasPermit;

// ✅ Clear with parentheses
bool result = ((age >= 18) && (age <= 65)) || hasPermit;

```

### 5. Comparing Floating-Point with ==

```csharp
// ❌ Unreliable
double a = 0.1 + 0.2;
if (a == 0.3)  // May fail due to precision!
{
    Console.WriteLine("Equal");
}

// ✅ Use tolerance
double epsilon = 0.0001;
if (Math.Abs(a - 0.3) < epsilon)
{
    Console.WriteLine("Equal (within tolerance)");
}

```

### 6. Null Reference with Logical Operators

```csharp
// ❌ May throw NullReferenceException
string name = null;
if (name.Length > 0 && name.Contains("a"))  // Error!
{
    // ...
}

// ✅ Check null first (short-circuit)
if (name != null && name.Length > 0 && name.Contains("a"))
{
    // Safe!
}

```

---

## 💡 Pro Tips

### 1. Use Parentheses for Clarity

```csharp
// Even if you know precedence, use parentheses for readability
// Others reading your code will thank you!

// Less clear
int result = a + b * c - d / e;

// More clear
int result = a + (b * c) - (d / e);

```

### 2. Prefer Compound Operators

```csharp
// Old way
score = score + 10;

// Modern way (shorter and clearer)
score += 10;

```

### 3. Use Ternary for Simple If-Else

```csharp
// For simple cases, ternary is cleaner
string status = (age >= 18) ? "Adult" : "Minor";

// But use if-else for complex logic
if (age >= 18 && hasLicense && !isSuspended)
{
    status = "Can Drive";
}
else
{
    status = "Cannot Drive";
}

```

### 4. Chain Comparisons Carefully

```csharp
// ❌ Wrong (doesn't work as expected)
if (18 <= age <= 65)  // Syntax error!

// ✅ Correct
if (age >= 18 && age <= 65)

```

### 5. Use Short-Circuit Evaluation

```csharp
// ✅ Good: Prevents null reference error
if (name != null && name.Length > 0)
{
    // Safe to access name
}

// ✅ Good: Prevents division by zero
if (x != 0 && 10 / x > 2)
{
    // Safe division
}

```

---

## 📖 Key Takeaways

✅ **Arithmetic operators** perform mathematical calculations: +, -, *, /, %

✅ **Modulus (%)** returns the remainder of division, useful for checking divisibility

✅ **Relational operators** compare values and return bool: ==, !=, >, <, >=, <=

✅ **Logical operators** combine boolean expressions: && (AND), || (OR), ! (NOT)

✅ **Short-circuit evaluation** stops evaluation when result is determined (efficient and safe)

✅ **Compound assignment operators** combine operation with assignment: +=, -=, *=, /=, %=

✅ **Increment (++)** and **Decrement (--)** have post and pre forms with different behaviors

✅ **Ternary operator (?:)** is a shorthand for simple if-else statements

✅ **Operator precedence** determines evaluation order: use parentheses for clarity

✅ **Integer division truncates** the decimal part - cast to double for accurate results

---

## 📚 Complete Working Examples

### Example 1: Complete Calculator

```csharp
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("=== Advanced Calculator ===\n");

        // Get first number
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        // Get operator
        Console.Write("Enter operator (+, -, *, /, %, ^): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Get second number
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;
        bool validOperation = true;

        // Perform operation
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    validOperation = false;
                }
                break;
            case '%':
                if (num2 != 0)
                    result = num1 % num2;
                else
                {
                    Console.WriteLine("Error: Modulus by zero!");
                    validOperation = false;
                }
                break;
            case '^':
                result = Math.Pow(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operator!");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine($"\nResult: {num1} {op} {num2} = {result:F2}");
        }

        Console.ReadKey();
    }
}

```

### Example 2: Student Eligibility Checker

```csharp
using System;

class EligibilityChecker
{
    static void Main()
    {
        Console.WriteLine("=== College Admission Eligibility ===\n");

        // Get student details
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter percentage in 12th: ");
        double percentage = double.Parse(Console.ReadLine());

        Console.Write("Are you a sports player? (y/n): ");
        bool isSports = Console.ReadKey().KeyChar == 'y';
        Console.WriteLine();

        Console.Write("Do you belong to minority? (y/n): ");
        bool isMinority = Console.ReadKey().KeyChar == 'y';
        Console.WriteLine();

        // Check eligibility
        // Regular: age 17-25 AND percentage >= 60
        // Sports: age 17-25 AND percentage >= 50
        // Minority: age 17-25 AND percentage >= 55

        bool ageEligible = (age >= 17) && (age <= 25);
        bool regularEligible = ageEligible && (percentage >= 60);
        bool sportsEligible = ageEligible && isSports && (percentage >= 50);
        bool minorityEligible = ageEligible && isMinority && (percentage >= 55);

        bool eligible = regularEligible || sportsEligible || minorityEligible;

        // Display result
        Console.WriteLine($"\n=== Eligibility Result for {name} ===");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Percentage: {percentage}%");
        Console.WriteLine($"Sports Quota: {(isSports ? "Yes" : "No")}");
        Console.WriteLine($"Minority Quota: {(isMinority ? "Yes" : "No")}");
        Console.WriteLine($"\nEligibility: {(eligible ? "ELIGIBLE ✓" : "NOT ELIGIBLE ✗")}");

        if (eligible)
        {
            string category = regularEligible ? "Regular" :
                            sportsEligible ? "Sports Quota" :
                            "Minority Quota";
            Console.WriteLine($"Category: {category}");
        }

        Console.ReadKey();
    }
}

```

### Example 3: Shopping Cart with Discounts

```csharp
using System;

class ShoppingCart
{
    static void Main()
    {
        Console.WriteLine("=== Shopping Cart Calculator ===\n");

        // Get cart details
        Console.Write("Enter total cart value: ₹");
        double cartValue = double.Parse(Console.ReadLine());

        Console.Write("Are you a member? (y/n): ");
        bool isMember = Console.ReadKey().KeyChar == 'y';
        Console.WriteLine();

        Console.Write("Do you have a coupon? (y/n): ");
        bool hasCoupon = Console.ReadKey().KeyChar == 'y';
        Console.WriteLine();

        // Calculate discount
        // Member: 10% discount
        // Coupon: 5% additional
        // Cart > 1000: 5% additional
        // Maximum discount: 20%

        double discountPercent = 0;

        if (isMember)
            discountPercent += 10;

        if (hasCoupon)
            discountPercent += 5;

        if (cartValue > 1000)
            discountPercent += 5;

        // Cap at 20%
        discountPercent = (discountPercent > 20) ? 20 : discountPercent;

        double discountAmount = cartValue * (discountPercent / 100);
        double afterDiscount = cartValue - discountAmount;

        // Add 18% GST
        double gstAmount = afterDiscount * 0.18;
        double finalAmount = afterDiscount + gstAmount;

        // Display breakdown
        Console.WriteLine("\n=== Bill Summary ===");
        Console.WriteLine($"Cart Value:        ₹{cartValue:F2}");
        Console.WriteLine($"Discount ({discountPercent}%):     -₹{discountAmount:F2}");
        Console.WriteLine($"After Discount:    ₹{afterDiscount:F2}");
        Console.WriteLine($"GST (18%):         +₹{gstAmount:F2}");
        Console.WriteLine($"{"".PadLeft(30, '-')}");
        Console.WriteLine($"Final Amount:      ₹{finalAmount:F2}");

        // Savings message
        if (discountAmount > 0)
        {
            Console.WriteLine($"\n🎉 You saved ₹{discountAmount:F2}!");
        }

        Console.ReadKey();
    }
}

```

---

## 🔗 Additional Resources

- [C# Operators Documentation](https://docs.microsoft.com/dotnet/csharp/language-reference/operators/)
- [Operator Precedence Guide](https://docs.microsoft.com/dotnet/csharp/language-reference/operators/operator-precedence)
- [Logical Operators](https://docs.microsoft.com/dotnet/csharp/language-reference/operators/boolean-logical-operators)

---
