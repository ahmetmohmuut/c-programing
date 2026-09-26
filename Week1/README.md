# Introduction to Visual C#

## Description

This chapter introduces the basic concepts of **Visual C# Windows Forms Application Development** using Visual Studio.

The chapter demonstrates how to:

* Understand objects, properties, and methods.
* Use Visual Studio as an Integrated Development Environment (IDE).
* Create Windows Forms applications.
* Add and configure controls such as Buttons, Labels, TextBoxes, and PictureBoxes.
* Understand basic C# code structure.
* Work with events and event handlers.
* Display messages using `MessageBox.Show()`.
* Use IntelliSense while writing C# code.
* Add comments, blank lines, and indentation.
* Close a Windows Form using `this.Close()`.
* Identify and handle syntax errors.

## Topics Covered

### 1. Objects

An object is a program component that contains data and performs operations.

Objects have:

* **Properties** – Data stored in an object.
* **Methods** – Operations an object can perform.

### 2. Controls

Controls are objects that are visible in a program's GUI.

Common controls include:

* Label
* Button
* TextBox
* PictureBox

### 3. .NET Framework

.NET is a collection of classes and other code that can be used to create Windows applications.

Controls are defined by specialized classes provided by .NET.

### 4. Visual Studio

Visual Studio is a professional **Integrated Development Environment (IDE)**.

Important parts include:

* Designer Window
* Solution Explorer
* Properties Window
* Toolbox
* Code Editor

### 5. Projects and Solutions

A **Solution** is a container that can hold one or more projects.

A **Project** represents an application and contains files such as:

* `Program.cs`
* `Form1.cs`

### 6. Windows Forms

When creating a new Windows Forms application, an empty form named `Form1` is automatically created.

The form can be customized using the **Properties Window**.

### 7. Properties

Properties control how an object looks and behaves.

Examples include:

* `Text`
* `Name`
* `Font`
* `Size`
* `Visible`
* `TextAlign`

### 8. Naming Controls

Control names are identifiers used to reference controls in code.

Examples:

```text
showDayButton
DisplayTotal
_ScoreLabel
```

The chapter introduces the **camelCase** naming convention for controls.

### 9. Events and Event Handlers

GUI applications are **event-driven**.

An event can occur when the user:

* Clicks a button.
* Presses a key.
* Moves the mouse.

An **event handler** is a method that executes when a specific event occurs.

Example:

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}
```

### 10. MessageBox

`MessageBox.Show()` displays a message in a dialog box.

Example:

```csharp
MessageBox.Show("Hello World");
```

### 11. Label Control

A Label control displays text on a form.

Common properties include:

* `Text`
* `Name`
* `Font`
* `BorderStyle`
* `AutoSize`
* `TextAlign`

Example:

```csharp
answerLabel.Text = "Hello World";
```

### 12. IntelliSense

IntelliSense provides automatic code completion while writing C# statements.

It can suggest:

* Keywords
* Variables
* Methods
* Classes
* Properties

### 13. PictureBox Control

A PictureBox control is used to display images on a form.

Important properties include:

* `Image`
* `SizeMode`
* `Visible`

### 14. Comments

Comments are notes placed inside source code to explain how parts of the program work.

Single-line comment:

```csharp
// Make image of the card back visible.
```

Block comment:

```csharp
/*
   Line one
   Line two
*/
```

### 15. Closing a Form

To close the current form:

```csharp
this.Close();
```

To close the whole application:

```csharp
Application.Exit();
```

## Example: Hello World

A simple Windows Forms application can display a message when a button is clicked:

```csharp
private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}
```

## Syntax Errors

Visual Studio checks C# code while it is being written.

If a syntax error is detected, Visual Studio displays a **red jagged underline** under the incorrect code.

Syntax errors should be corrected before compiling and running the application.

## Learning Objectives

After completing this chapter, you should be able to:

* Understand the basic concept of objects.
* Navigate Visual Studio.
* Create a Windows Forms application.
* Add and modify controls.
* Change control properties.
* Write basic C# event-handling code.
* Display messages using `MessageBox.Show()`.
* Use Labels and PictureBoxes.
* Use IntelliSense.
* Write readable code using comments and indentation.
* Close forms and applications using C# code.
* Recognize basic syntax errors.

## Source

**Starting Out with Visual C#, Sixth Edition**
**Chapter 1 – Introduction to Visual C#**

Pearson Education, Inc.
