# Assignment 03 - Understanding Arrays, Classes, Methods, and Namespaces in C#

## Overview

This project is part of Assignment 03 where we explore the fundamentals of arrays, classes, methods, and namespaces using C#. The assignment demonstrates how to work with a two-dimensional array within a custom class, and how to use namespaces to organize code effectively.

## Materials

- A personal computer with a pre-installed Windows Operating System.
- Visual Studio IDE 2015 or higher.

## Task Description

**Assignment Instructions:**

- **Namespace:** Create a namespace called `PreFiAssignment`.
- **Class:** Inside the namespace, create a class named `MyNameinArray`.
- **Array Requirements:**  
  - Create a two-dimensional array with **5 columns**.
  - The number of rows should be **not less than 3**.
- **Array Initialization:**  
  - Initialize the array with the first 5 letters of your first name for the first set of elements.
  - Use the remaining letters of your full name to fill the rest of the array.
  - The full name is hard-coded in the program (the program does not ask the user for input).
- **Display Output:**  
  - Create a separate `Program` class containing the `Main` method.
  - The `Main` method should instantiate the `MyNameinArray` class and print the values of the multidimensional array in a formatted grid.

## Implementation Details

- **Namespace:**  
  All classes are encapsulated within the `PreFiAssignment` namespace.

- **MyNameinArray Class:**  
  - **Functionality:** Processes a full name by removing spaces, converting it to lowercase, and populating a two-dimensional array.
  - **Array Handling:**  
    - The array is designed to have 5 columns.
    - The number of rows is computed using the ceiling of the full name's length divided by 5, ensuring that all characters fit.
  - **Display:** Uses nested loops to print each character of the full name from the array in a grid format.

- **Program Class:**  
  - Contains the `Main` method.
  - Creates an instance of `MyNameinArray`, automatically triggering the logic to display the formatted name grid.

## How to Run the Application

1. **Open the Project in Visual Studio:**
   - Launch Visual Studio (2015 or higher) on your Windows machine.
   - Open the solution file (`.sln`) for the project.

2. **Build the Project:**
   - Navigate to **Build > Build Solution** or press `Ctrl+Shift+B` to compile the project.

3. **Run the Program:**
   - Start debugging with `F5` or select **Debug > Start Debugging**.
   - A console window will open, displaying the multidimensional array output formatted according to the assignment requirements.

## Expected Output

When the application runs, it prints a grid of characters representing your full name. The grid uses the first 5 letters of your first name for the first row and fills in the rest with the subsequent letters. For example:

