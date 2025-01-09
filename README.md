# Uninitialized Property Access in C# Constructor

This repository demonstrates a common error in C#: accessing a property before it's properly initialized within a class constructor.  The `bug.cs` file showcases the problematic code, while `bugSolution.cs` provides the corrected version.

## The Problem

In `bug.cs`, the `MyMethod` attempts to print the value of `MyProperty` before the constructor has finished initializing it.  While the constructor sets `MyProperty` to 0, there's a window between the start of `MyMethod` and the constructor's completion where the value might be unpredictable. In some scenarios, this might lead to unexpected values, or even exceptions if other code relies on `MyProperty` having a defined value.

## The Solution

`bugSolution.cs` illustrates how to correct this by ensuring `MyProperty` is explicitly initialized before its value is accessed in `MyMethod` or by altering the order of execution of MyMethod and Property initialization.