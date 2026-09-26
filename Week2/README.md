# Processing Data in Visual C#

## Description

This chapter introduces how to process data in a **C# Windows Forms Application**.

The chapter demonstrates how to:

* Read user input using TextBox controls.
* Declare and use variables.
* Work with string and numeric data types.
* Perform mathematical calculations.
* Convert string input into numeric values.
* Format numbers using the `ToString()` method.
* Handle runtime errors using `try-catch`.
* Use named constants.
* Declare variables as fields.
* Use the C# `Math` class.
* Configure GUI features such as tab order, colors, and access keys.
* Use the Visual Studio debugger to find logic errors.

## Topics Covered

### 1. Reading Input with TextBox Controls

A TextBox control allows the user to enter data using the keyboard.

The user's input is stored in the TextBox's `Text` property.

Example:

```csharp
textBox1.Text = "Hello";
```

To clear a TextBox:

```csharp
textBox1.Text = string.Empty;
```

or:

```csharp
textBox1.Clear();
```

### 2. Variables

A variable is a storage location in memory.

Variables must be declared before they are used.

Basic syntax:

```csharp
DataType VariableName;
```
Example:
```csharp
string productDescription;
```
### 3. Data Types

A variable must have a data type that specifies what kind of data it can store.

Common data types include:

* `string` – stores text.
* `int` – stores whole numbers.
* `double` – stores real numbers, including fractional values.
* `decimal` – stores numbers with greater precision and is commonly used for financial applications.

### 4. Variable Naming Rules

Variable names should be meaningful.

Basic rules:

* The first character must be a letter or underscore `_`.
* Spaces are not allowed.
* Keywords and reserved words should not be used.
* Use meaningful names whenever possible.

Example:

```csharp
string firstName;
string lastName;
```

### 5. String Variables

A string is a combination of characters.

Example:

```csharp
string productDescription = "Jamhuuriya University";
```

A string can be displayed using a MessageBox:

```csharp
MessageBox.Show(productDescription);
```

### 6. String Concatenation

Concatenation means joining one string to another.

The `+` operator is used for concatenation.

Example:

```csharp
string fullName = firstName + " " + lastName;
```

You can also combine strings with numbers:

```csharp
string output = "Total is " + 25.75;
```

### 7. Local Variables and Scope

A local variable belongs to the method where it is declared.

Only statements inside that method can access it.

**Scope** describes the part of the program where a variable can be accessed.

### 8. Initializing Variables

A variable must be assigned a value before it can be used.

Example:

```csharp
string productDescription = "Computer";
```

Using an unassigned local variable causes a compilation error.

### 9. Numeric Data Types

Common numeric data types include:

```text
int
double
decimal
```

Examples:

```csharp
int hoursWorked = 40;

double temperature = 87.6;

decimal payRate = 28.75m;
```

### 10. Type Casting

Type casting allows you to explicitly convert a value from one data type to another.

Example:

```csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;
```

Another example:

```csharp
decimal moneyNumber = 625.70m;
double realNumber = (double)moneyNumber;
```

### 11. The `var` Keyword

The `var` keyword allows the compiler to determine the variable's data type automatically.

Example:

```csharp
var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;
```

A variable declared with `var` must be initialized when it is declared.

### 12. Performing Calculations

C# provides arithmetic operators for calculations.

| Operator | Operation      |
| -------- | -------------- |
| `+`      | Addition       |
| `-`      | Subtraction    |
| `*`      | Multiplication |
| `/`      | Division       |
| `%`      | Modulus        |

Example:

```csharp
int x = 5;
int y = 4;

int result = x + y;
```

### 13. Integer Division

When two integers are divided, the result is an integer.

Example:

```csharp
int x = 7;
int y = 3;

MessageBox.Show((x / y).ToString());
```

The result is:

```text
2
```

To get a decimal result:

```csharp
MessageBox.Show(((double)x / y).ToString());
```

### 14. Converting TextBox Input to Numbers

TextBox input is treated as a string, even when the user enters a number.

To convert the input into a numeric value, use `Parse()` methods.

Examples:

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
```

```csharp
double temperature = double.Parse(temperatureTextBox.Text);
```

```csharp
decimal price = decimal.Parse(priceTextBox.Text);
```

### 15. Converting Numbers to Strings

The `ToString()` method converts a numeric value into a string.

Example:

```csharp
decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();
```

Another example:

```csharp
int myNumber = 123;

MessageBox.Show(myNumber.ToString());
```

### 16. Formatting Numbers

The `ToString()` method can format numbers.

Common format strings include:

| Format | Description        |
| ------ | ------------------ |
| `N`    | Number format      |
| `F`    | Fixed-point format |
| `E`    | Exponential format |
| `C`    | Currency format    |
| `P`    | Percentage format  |

Examples:

```csharp
number.ToString("N3");
```

```csharp
price.ToString("C");
```

```csharp
rate.ToString("P");
```

### 17. Exception Handling

An exception is an unexpected error that happens while a program is running.

Examples include:

* Dividing by zero.
* Invalid user input.
* Trying to open a file that does not exist.

Exception handling allows the program to respond to errors instead of suddenly stopping.

### 18. `try-catch`

The `try` block contains code that may cause an exception.

The `catch` block contains code that handles the exception.

Example:

```csharp
try
{
    double number = double.Parse(numberTextBox.Text);
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

### 19. Exception Message

An exception object has a `Message` property containing information about the error.

Example:

```csharp
try
{
    // Code that may cause an error
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

### 20. Named Constants

A named constant represents a value that cannot be changed while the program is running.

The `const` keyword is used to declare a constant.

Example:

```csharp
const double INTEREST_RATE = 0.129;
```

### 21. Fields

A field is a variable declared at the class level.

A field is declared inside the class but outside any method.

Example:

```csharp
private string name = "Charles";
```

A field's scope is the entire class.

### 22. Math Class

The .NET `Math` class provides methods for mathematical calculations.

Common methods include:

```csharp
Math.Sqrt(x);
Math.Pow(x, y);
Math.Max(x, y);
Math.Min(x, y);
Math.Round(x);
```

Useful constants:

```csharp
Math.PI
Math.E
```

### 23. Tab Order and Focus

**Focus** means that a control receives keyboard input.

The **Tab Order** determines the order in which controls receive focus when the user presses the Tab key.

The `TabIndex` property specifies a control's position in the tab order.

Example:

```csharp
nameTextBox.Focus();
```

### 24. Keyboard Access Keys

An access key allows the user to quickly access a control by pressing **Alt + a key**.

An ampersand `&` can be placed before a letter in a button's Text property.

Example:

```text
&Exit
```

The user can then use:

```text
Alt + X
```

### 25. Setting Colors

Forms and most controls have a `BackColor` property.

Controls that display text also have a `ForeColor` property.

Example:

```csharp
messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
```

### 26. Background Images

A Form has a `BackgroundImage` property for displaying an image.

The `BackgroundImageLayout` property controls how the image is displayed.

Common layouts include:

* None
* Tile
* Center
* Stretch
* Zoom

### 27. GroupBox and Panel

A **GroupBox** and **Panel** are both containers that can hold other controls.

Main difference:

* GroupBox can display a title using its `Text` property.
* Panel cannot display a title.
* Panel uses `BorderStyle` to specify its border.

### 28. Logic Errors

A logic error is a mistake that does not stop the application from running but causes incorrect results.

Examples include:

* Mathematical errors.
* Assigning a value to the wrong variable.
* Assigning the wrong value to a variable.

### 29. Debugging

Visual Studio provides debugging tools to help locate and fix logic errors.

Important debugging tools include:

* Breakpoints
* Break Mode
* Locals Window
* Watch Window
* Single-Stepping

### 30. Breakpoints

A breakpoint is a line selected in the source code.

When the application reaches a breakpoint, execution pauses and enters **Break Mode**.

This allows you to examine:

* Variable values.
* Control properties.
* Program execution.

### 31. Locals and Watch Windows

The **Locals Window** displays variables in the current procedure, including their values and data types.

The **Watch Window** allows you to monitor selected variables.

### 32. Single-Stepping

Single-stepping allows you to execute the program one statement at a time.

You can use:

```text
F11
```

or select **Step Into** from the Debug menu.

This helps identify the exact line of code causing a logic error.

## Learning Objectives

After completing this chapter, you should be able to:

* Read input using TextBox controls.
* Declare and initialize variables.
* Understand variable scope.
* Work with string and numeric data types.
* Perform arithmetic calculations.
* Convert strings into numeric values.
* Convert numbers into strings.
* Format numeric output.
* Handle exceptions using `try-catch`.
* Create named constants.
* Use class-level fields.
* Perform mathematical operations using the `Math` class.
* Configure tab order and keyboard access keys.
* Change colors and background images.
* Understand GroupBox and Panel controls.
* Identify logic errors.
* Use Visual Studio debugging tools.