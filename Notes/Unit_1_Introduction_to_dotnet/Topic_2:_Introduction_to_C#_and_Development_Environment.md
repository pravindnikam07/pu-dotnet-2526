## **Topic 2: Introduction to C# and Development Environment**.

## 📚 Topic 2.1: Setting up the Environment

### What You Need to Start

To develop .NET applications, you need two main things:

1. **.NET SDK** (Software Development Kit) - Contains tools to build and run .NET apps
2. **Code Editor/IDE** - Where you write your code

### Option 1: Visual Studio (Recommended for Windows)

**Visual Studio** is a full-featured Integrated Development Environment (IDE) from Microsoft.

### **Editions:**

- **Community** - Free for students, open-source, and individual developers
- **Professional** - Paid, for small teams
- **Enterprise** - Paid, for large organizations

**For Students: Use Community Edition (It's FREE!)**

### **Features:**

- IntelliSense (smart code completion)
- Built-in debugger
- Visual designers for UI
- Built-in Git support
- Database tools
- Testing tools
- Project templates

### **Installation Steps:**

```
Step 1: Download Visual Studio
→ Visit: https://visualstudio.microsoft.com/downloads/
→ Choose: Visual Studio Community

Step 2: Run the Installer
→ Select Workloads (what you want to develop)

Step 3: Choose Workloads
For this course, select:
✓ .NET desktop development (for Windows Forms)
✓ ASP.NET and web development (for web apps)
✓ .NET Core cross-platform development

Step 4: Install
→ Click Install (may take 30-60 minutes)
→ Requires 20-50 GB disk space

Step 5: Launch and Sign In
→ Open Visual Studio
→ Sign in with Microsoft account (optional but recommended)

```

### Option 2: Visual Studio Code (Cross-Platform)

**VS Code** is a lightweight, cross-platform code editor.

### **Advantages:**

- Fast and lightweight
- Works on Windows, macOS, Linux
- Highly customizable with extensions
- Free and open-source

### **Installation Steps:**

```
Step 1: Install .NET SDK
→ Visit: https://dotnet.microsoft.com/download
→ Download .NET 8 SDK (or latest LTS version)
→ Run installer
→ Verify: Open terminal and run "dotnet --version"

Step 2: Install VS Code
→ Visit: https://code.visualstudio.com/
→ Download for your OS
→ Install

Step 3: Install C# Extension
→ Open VS Code
→ Click Extensions icon (or Ctrl+Shift+X)
→ Search "C# Dev Kit"
→ Install "C# Dev Kit" by Microsoft

```

### Verifying Your Installation

Open a terminal/command prompt and run these commands:

```bash
# Check .NET SDK version
dotnet --version
# Output: 8.0.100 (or similar)

# Check installed SDKs
dotnet --list-sdks
# Output: 8.0.100 [C:\Program Files\dotnet\sdk]

# Check installed runtimes
dotnet --list-runtimes
# Output: Microsoft.NETCore.App 8.0.0 [C:\Program Files\dotnet\shared\...]

```

### Comparison: Visual Studio vs VS Code

| Feature | Visual Studio | VS Code |
| --- | --- | --- |
| **Size** | Large (20-50 GB) | Small (~200 MB) |
| **Platform** | Windows, macOS | Windows, macOS, Linux |
| **Learning Curve** | Steeper | Easier |
| **Features** | Comprehensive | Extensible |
| **UI Designer** | Built-in | Limited |
| **Debugging** | Advanced | Good |
| **Best For** | Large projects | Quick editing, cross-platform |

**Recommendation for Students:**

- **Windows users**: Start with Visual Studio Community
- **macOS/Linux users**: Use VS Code
- **Learning**: Both are excellent, choose based on your OS and preference

---

## 📚 Topic 2.2: Creating a "Hello, World!" Console Application

Let's create your first C# application!

### Method 1: Using Visual Studio

### **Step-by-Step:**

```
Step 1: Create New Project
→ Open Visual Studio
→ Click "Create a new project"

Step 2: Choose Template
→ Search for "Console App"
→ Select "Console App" (NOT Console App (.NET Framework))
→ Click Next

Step 3: Configure Project
→ Project name: HelloWorld
→ Location: Choose where to save
→ Solution name: HelloWorld
→ Click Next

Step 4: Additional Information
→ Framework: .NET 8.0 (or latest)
→ Click Create

Step 5: Your Project Opens!
→ You'll see Program.cs file with code

```

### **The Default Code You See:**

```csharp
// Program.cs
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

```

**Wait, where's the rest of the code?**

This is the **new simplified template** (top-level statements). The complete traditional code is:

```csharp
// Traditional way (still valid)
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

```

Both are **exactly the same**! The compiler generates the traditional structure automatically.

### Method 2: Using VS Code (Command Line)

### **Step-by-Step:**

```bash
# Step 1: Create a new directory
mkdir HelloWorld
cd HelloWorld

# Step 2: Create a new console application
dotnet new console

# Step 3: Open in VS Code
code .

```

### Understanding the Code

Let's break down the traditional Hello World program:

```csharp
using System;                    // 1. Import namespace

namespace HelloWorld             // 2. Define namespace
{
    class Program                // 3. Define class
    {
        static void Main(string[] args)  // 4. Main method (entry point)
        {
            Console.WriteLine("Hello, World!");  // 5. Print to console
        }
    }
}

```

**Line-by-Line Explanation:**

1. **`using System;`**
    - Imports the System namespace
    - Gives access to Console, String, DateTime, etc.
    - Like `#include` in C/C++ or `import` in Java
2. **`namespace HelloWorld`**
    - Organizes code into logical groups
    - Prevents naming conflicts
    - Like packages in Java
3. **`class Program`**
    - Defines a class named Program
    - C# is object-oriented, everything is in a class
    - Class name should match file name (convention)
4. **`static void Main(string[] args)`**
    - **Entry point** of the application
    - Program starts execution here
    - `static` - can be called without creating an object
    - `void` - doesn't return any value
    - `string[] args` - command-line arguments
5. **`Console.WriteLine("Hello, World!");`**
    - Prints text to console
    - `Console` is a class in System namespace
    - `WriteLine` is a method (adds newline at end)
    - Semicolon (`;`) ends the statement

### Modern Simplified Syntax (Top-Level Statements)

```csharp
// Modern way (.NET 6+)
Console.WriteLine("Hello, World!");

// That's it! Much simpler.
// The compiler generates the class and Main method automatically

```

**You can still use everything:**

```csharp
// Variables
string name = "Student";
int age = 20;

// Output
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"You are {age} years old.");

// Input
Console.Write("Enter your name: ");
string userName = Console.ReadLine();
Console.WriteLine($"Welcome, {userName}!");

```

### Running Your Application

### **In Visual Studio:**

- Press **F5** (Debug mode)
- Or press **Ctrl+F5** (Run without debugging)
- Or click the green ▶ button

### **In VS Code / Command Line:**

```bash
# Run the application
dotnet run

# Output:
# Hello, World!

```

### Complete Example with Input/Output

```csharp
// Program.cs
Console.WriteLine("=== Welcome to C# ===");
Console.WriteLine();

// Get user input
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// Process and output
Console.WriteLine();
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"You are {age} years old.");

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

```

**Sample Output:**

```
=== Welcome to C# ===

Enter your name: Raj
Enter your age: 21

Hello, Raj!
You are 21 years old.
You are an adult.

Press any key to exit...

```

---

## 📚 Topic 2.3: Understanding the Project Structure

When you create a project, several files and folders are generated. Let's understand each:

### File Structure

```
HelloWorld/                          ← Solution folder
│
├── HelloWorld.sln                   ← Solution file
│
├── HelloWorld/                      ← Project folder
│   │
│   ├── Program.cs                   ← Your main code file
│   ├── HelloWorld.csproj            ← Project configuration file
│   │
│   ├── bin/                         ← Binary output folder
│   │   ├── Debug/                   ← Debug build output
│   │   │   └── net8.0/
│   │   │       ├── HelloWorld.exe
│   │   │       ├── HelloWorld.dll
│   │   │       └── ...
│   │   └── Release/                 ← Release build output
│   │
│   └── obj/                         ← Intermediate files
│       └── Debug/
│           └── net8.0/
│               └── ... (temp files)

```

### Important Files Explained

### 1. **Program.cs**

- Your main source code file
- Contains the entry point (Main method)
- You write your C# code here

```csharp
// Program.cs
Console.WriteLine("Hello, World!");

```

### 2. **HelloWorld.csproj** (Project File)

This is an XML file that defines your project configuration.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

```

**Key Elements:**

- **`Sdk="Microsoft.NET.Sdk"`** - Type of project (console, web, library)
- **`OutputType`** - Exe (executable) or Library (DLL)
- **`TargetFramework`** - Which .NET version to use
- **`ImplicitUsings`** - Automatically imports common namespaces
- **`Nullable`** - Enable nullable reference types (C# 8+)

**Common TargetFramework Values:**

- `net8.0` - .NET 8
- `net6.0` - .NET 6 (LTS)
- `net48` - .NET Framework 4.8
- `netstandard2.0` - .NET Standard (for libraries)

### 3. **HelloWorld.sln** (Solution File)

A solution can contain multiple projects. It's a container.

```
Solution: SchoolManagement
├── Project 1: SchoolManagement.Web
├── Project 2: SchoolManagement.Data
└── Project 3: SchoolManagement.Core

```

**You can have:**

- One solution with one project (simple apps)
- One solution with multiple projects (complex apps)

### 4. **bin/ folder** (Binary Output)

Contains the compiled output (executables and DLLs).

**Two configurations:**

- **Debug** - For development (includes debugging symbols, larger size)
- **Release** - For production (optimized, smaller size)

```
bin/
├── Debug/
│   └── net8.0/
│       ├── HelloWorld.exe       ← Executable
│       ├── HelloWorld.dll       ← Compiled code
│       ├── HelloWorld.pdb       ← Debug symbols
│       └── HelloWorld.deps.json ← Dependencies

```

### 5. **obj/ folder** (Intermediate Files)

Contains temporary files created during compilation.

- **Can be safely deleted** (will be recreated on build)
- Stores intermediate compilation results
- Project metadata and cache

### Implicit Usings (New Feature)

When `ImplicitUsings` is enabled, these namespaces are automatically imported:

```csharp
// You don't need to write:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// They're automatically available!
Console.WriteLine("Works without 'using System;'");

```

### Adding More Files to Your Project

### **In Visual Studio:**

```
Right-click on project → Add → New Item → Choose template
or
Right-click on project → Add → Class

```

### **In Command Line:**

```bash
# Add a new class
dotnet new class -n Student

# This creates Student.cs

```

### Project Structure Example - Multi-file

```
HelloWorld/
├── Program.cs              ← Entry point
├── Student.cs              ← Student class
├── Calculator.cs           ← Calculator class
└── Utils/                  ← Folder for utilities
    ├── Helper.cs
    └── Logger.cs

```

**Program.cs:**

```csharp
// Program.cs
var student = new Student("Raj", 20);
student.Display();

var calc = new Calculator();
int result = calc.Add(5, 3);
Console.WriteLine($"5 + 3 = {result}");

```

**Student.cs:**

```csharp
// Student.cs
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

```

**Calculator.cs:**

```csharp
// Calculator.cs
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

```

---

## 📚 Topic 2.4: Compiling and Running the Application

### Understanding the Build Process

```
Source Code (.cs)
      ↓
   [Compile]
      ↓
Intermediate Language (.dll)
      ↓
   [Run/Execute]
      ↓
    JIT Compiler
      ↓
Native Machine Code
      ↓
   Execution

```

### Compilation Commands

### **Using Command Line:**

```bash
# Build the project
dotnet build

# Output:
# Microsoft (R) Build Engine version...
# Build succeeded.

# Build for Release (optimized)
dotnet build -c Release

# Clean the build
dotnet clean

```

### **Build Output Example:**

```bash
$ dotnet build
MSBuild version 17.8.0+...
  Determining projects to restore...
  All projects are up-to-date for restore.
  HelloWorld -> C:\Projects\HelloWorld\bin\Debug\net8.0\HelloWorld.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.23

```

### Running the Application

### **Method 1: dotnet run (Recommended for Development)**

```bash
dotnet run

# Automatically builds and runs
# Great for development

```

### **Method 2: Direct Execution**

```bash
# Navigate to output folder
cd bin/Debug/net8.0/

# Windows
HelloWorld.exe

# macOS/Linux
./HelloWorld

```

### **Method 3: Visual Studio**

- **F5** - Start Debugging (can set breakpoints, step through code)
- **Ctrl+F5** - Start Without Debugging (faster)

### Debug vs Release Builds

### **Debug Build:**

```bash
dotnet build -c Debug
# or simply
dotnet build

```

**Characteristics:**

- Includes debug symbols (.pdb files)
- No optimizations
- Larger file size
- Easier to debug
- Slower execution

### **Release Build:**

```bash
dotnet build -c Release

```

**Characteristics:**

- No debug symbols
- Optimized code
- Smaller file size
- Harder to debug
- Faster execution
- **Use for production deployment**

### Publishing Your Application

When you want to distribute your app:

```bash
# Publish as framework-dependent
dotnet publish -c Release

# Publish as self-contained (includes .NET runtime)
dotnet publish -c Release -r win-x64 --self-contained

# Publish as single file
dotnet publish -c Release -r win-x64 --self-contained -p:PublishSingleFile=true

```

**Runtime Identifiers (RID):**

- `win-x64` - Windows 64-bit
- `win-x86` - Windows 32-bit
- `linux-x64` - Linux 64-bit
- `osx-x64` - macOS 64-bit

### Compilation Errors and Warnings

### **Common Compilation Errors:**

```csharp
// Error CS1002: ; expected
Console.WriteLine("Hello")  // Missing semicolon

// Error CS0103: The name 'console' does not exist
console.WriteLine("Hello");  // Wrong case (should be Console)

// Error CS0029: Cannot implicitly convert type 'string' to 'int'
int number = "123";  // Wrong type

```

### **Fixing Errors:**

1. **Read the error message carefully**

    ```
    Program.cs(5,28): error CS1002: ; expected [C:\HelloWorld\HelloWorld.csproj]

    ```

    - File: Program.cs
    - Line: 5
    - Column: 28
    - Error code: CS1002
    - Message: ; expected
2. **Double-click the error in Visual Studio** - Takes you to the line
3. **Use IntelliSense** - Red squiggly lines show errors before compilation

### Command Line Arguments

Your application can accept command-line arguments:

```csharp
// Program.cs
if (args.Length > 0)
{
    Console.WriteLine($"Hello, {args[0]}!");
}
else
{
    Console.WriteLine("Hello, World!");
}

```

**Running with arguments:**

```bash
dotnet run -- Raj
# Output: Hello, Raj!

# Or directly:
HelloWorld.exe Raj
# Output: Hello, Raj!

```

### Environment Variables

```csharp
// Read environment variable
string userName = Environment.UserName;
string machineName = Environment.MachineName;

Console.WriteLine($"User: {userName}");
Console.WriteLine($"Machine: {machineName}");

// Set environment variable
Environment.SetEnvironmentVariable("MY_VAR", "MyValue");
string myVar = Environment.GetEnvironmentVariable("MY_VAR");
Console.WriteLine($"MY_VAR: {myVar}");

```

---

## 🎯 Student Tasks & Practice

### Task 1: Environment Setup

1. Install Visual Studio Community or VS Code with .NET SDK
2. Verify installation by running `dotnet --version`
3. Take a screenshot of your installed version

### Task 2: Hello World Variations

Create these programs:

**a) Basic Hello World**

```csharp
Console.WriteLine("Hello, World!");

```

**b) With User Input**

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");

```

**c) With Multiple Inputs**

```csharp
Console.Write("Enter your first name: ");
string firstName = Console.ReadLine();

Console.Write("Enter your last name: ");
string lastName = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"\nHello, {firstName} {lastName}!");
Console.WriteLine($"You are {age} years old.");

```

### Task 3: Project Structure Exploration

1. Create a new console application
2. Locate and open the .csproj file
3. Find the bin and obj folders
4. Identify where the compiled .exe file is located
5. Document your findings

### Task 4: Build and Run

1. Build your project using `dotnet build`
2. Run it using `dotnet run`
3. Navigate to the bin folder and run the .exe directly
4. Compare the three methods

### Task 5: Command-Line Arguments

Create a program that:

1. Accepts name and age as command-line arguments
2. Displays a greeting message
3. Handles cases when arguments are not provided

**Example:**

```bash
dotnet run -- Raj 21
# Output: Hello Raj, you are 21 years old!

dotnet run
# Output: Please provide name and age as arguments

```

### Task 6: Multi-File Project

Create a project with:

1. Program.cs (main file)
2. Student.cs (Student class with properties and methods)
3. Calculator.cs (Calculator class with Add, Subtract methods)
4. Use these classes in Program.cs

### Task 7: Debug vs Release

1. Build your project in Debug mode
2. Build your project in Release mode
3. Compare file sizes in bin/Debug and bin/Release
4. Note the differences

---

## 📖 Key Takeaways

✅ **Two main options for development**: Visual Studio (full IDE) and VS Code (lightweight editor)

✅ **.NET SDK is required** for building and running .NET applications

✅ **Console.WriteLine()** is used to output text to the console

✅ **Main method is the entry point** where program execution begins

✅ **.csproj file contains project configuration** including target framework and dependencies

✅ **bin folder contains compiled output**, obj folder contains intermediate files

✅ **Top-level statements** in modern C# simplify code by removing boilerplate

✅ **dotnet CLI commands**: `dotnet new`, `dotnet build`, `dotnet run`, `dotnet publish`

✅ **Debug builds for development**, Release builds for production

✅ **IntelliSense helps catch errors** before compilation

---

## 🔗 Additional Resources

- [Visual Studio Download](https://visualstudio.microsoft.com/downloads/)
- [VS Code Download](https://code.visualstudio.com/)
- [.NET SDK Download](https://dotnet.microsoft.com/download)
- [C# Language Reference](https://docs.microsoft.com/dotnet/csharp/)
- [.NET CLI Reference](https://docs.microsoft.com/dotnet/core/tools/)

---
