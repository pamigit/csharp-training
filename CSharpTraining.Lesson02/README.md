# Lesson 2

## Software Prerequisites

- Install Visual Studio Community Edition 2017 [Download](https://www.visualstudio.com/downloads/)

## Overview

This lesson will introduce *variables*.  We will see how to declare, initialize, and use variables in C# programs.

## Key Concepts

Keep an eye out for the following concepts:

- strings
- methods
- parameters
- types
- classes
- null

## Code Example

The *CSharpTraining.Lesson02* folder contains a file named *Program.cs* which has the following code:

````csharp

class Program
{
    static void Main()
    {
        var content = "The sky is blue";
        System.Console.WriteLine(content);
        System.Console.ReadLine();
    }
}

````

## Code Explanation

The word *var* is a C# keyword for *declaring* a variable.

````csharp

var content = "The sky is blue";
^^^

````

The word that follows the *var* keyword will be the variable name.  The word *content* a variable name in this program.

````csharp

var content = "The sky is blue";
    ^^^^^^^

````

The value of the *variable* named *content* is initialized to the string *"The sky is blue"*.  So the value of the *variable* named *content* will be a *string type*.  The value of a *variable* will always follow the equals sign.  

````csharp

var content = "The sky is blue";
              ^^^^^^^^^^^^^^^^^

````

The final part of the script will pass the *variable* named *content* as a *parameter* to the *WriteLine* method.

````csharp

var content = "The sky is blue";
System.Console.WriteLine(content);
                         ^^^^^^^

````

## Run the Code

The program can be ran by hitting the *F5* key.  

After running the program, you should see the following displayed:

````

The sky is blue.

````

## Exercise

There is a project named *CSharpTraining.Lesson02.Exercise* in the solution folder.  Open the *Program.cs* file in Visual Studio and declare a variable named *quote* and initialize this variable with a string that is your favorite quote.  Pass this variable as a parameter to the *System.Console.WriteLine* method.  Run the project by hitting the *F5* key.  Be sure to right click the project and *Set as Startup Project*.

## Questions

1. What C# keyword is used to declare a variable?
    - [ ] a) var
    - [ ] b) class
    - [ ] c) namespace
    - [ ] d) =
1. When we `_______` a variable, we give the variable a value.
    - [ ] a) declare
    - [ ] b) initialize
    - [ ] c) cast
    - [ ] d) nothing
1. The type of a variable can be a `_______`.
    - [ ] a) string
    - [ ] b) int
    - [ ] c) boolean
    - [ ] d) any of the above
1. A variable can be passed as a parameter to the *System.Console.WriteLine* method.
    - [ ] a) true
    - [ ] b) false
1. The C# *=* operator is used to initialize a variable.
    - [ ] a) true
    - [ ] b) false

## Answers

1. What C# keyword is used to declare a variable?
    - [x] a) var
    - [ ] b) class
    - [ ] c) namespace
    - [ ] d) =
1. When we `_______` a variable, we give the variable a value.
    - [x] a) declare
    - [ ] b) initialize
    - [ ] c) cast
    - [ ] d) nothing
1. The type of a variable can be a `_______`.
    - [ ] a) string
    - [ ] b) int
    - [ ] c) boolean
    - [x] d) any of the above
1. A variable can be passed as a parameter to the *System.Console.WriteLine* method.
    - [x] a) true
    - [ ] b) false
1. The C# *=* operator is used to initialize a variable.
    - [x] a) true
    - [ ] b) false

## Something to Think About

Is it possible to initialize a variable with a type that is not a string?  What other types could a variable contain.  What if a variable is declared, but it is never initialized with any value?  What happens if it is passed as a parameter to the *System.Console.WriteLine* method?  Experiment with initializing variables to different types.
