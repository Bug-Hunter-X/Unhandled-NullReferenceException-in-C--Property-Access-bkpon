# Unhandled NullReferenceException in C# Property Access

This repository demonstrates a common C# error: a `NullReferenceException` that occurs when accessing a class property that has not been initialized. The example shows how to reproduce the error and provides a solution to prevent it.

## Bug Description
The `ExampleClass` demonstrates this issue where the `MyMethod` attempts to use the `MyProperty` which could be null if not initialized leading to the `NullReferenceException`. 

## Solution
The provided solution handles the null case to avoid the `NullReferenceException`. We can initialize the property to a default value, or check for null before accessing it. This solution offers a robust approach to prevent the exception.