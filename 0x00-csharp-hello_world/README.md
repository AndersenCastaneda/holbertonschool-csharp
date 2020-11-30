# 0x00. C# - Hello, World

## Resources:books:
Read or watch:
* [Get started with C# and Visual Studio Code](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code)
* [Getting Started with .NET Core using the CLI](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code)
* [C# Tutorial for Beginners ](https://www.youtube.com/watch?v=gfkTfcpWqAY&feature=youtu.be&t=1m20s)
* [Strings (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
* [C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/)
* [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
* [Console.WriteLine Method](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8)

---
## Learning Objectives:bulb:
- What is the meaning behind the name C#?
- Who is the lead architect of the development team of C#?
- What is .NET?
- What is the difference between C# and .NET?
- How to use VSCode and the integrated terminal to initialize, build, and run C# projects
- How to print text and variables using Console.Write

---
### [0-initialize_new_project](./0-initialize_new_project.sh)
* Write a Bash script that initializes a new C# project inside a folder titled 0-new_project.
    - Use the command dotnet

### [1-build_new_project](./1-build_new_project.sh)
* Write a Bash script that initializes and builds a new C# project inside a folder titled 1-new_project.
    - Use the command dotnet

### [2-run_new_project](./2-run_new_project.sh)
* Write a Bash script that initializes, builds, and runs a new C# project from a folder titled 2-new_project.
    - Use the command dotnet

### [3-writeline](./3-writeline)
* Write a C# script that prints exactly "Programming is like building a multilingual puzzle followed by a new line.
    - Use the method Console.WriteLine

### [4-print_integer](./4-print_integer)
* Complete this source code in order to print the integer stored in the variable number, followed by Mission Street followed by a new line.
    - You can find the source code here
    - Your code should be exactly 10 lines long
    - The output of the script should be:
        - the number, followed by Mission Street
        - followed by a new line

### [5-print_float](./5-print_float)
* Complete this source code in order to print the float stored in the variable number with a precision of 2 digits.
    - You can find the source code here
    - Your script should be exactly 10 lines long
    - The output of the script should be:
        - Float: followed by the number with only 2 digits
        - followed by a new line

### [6-print_string](./6-print_string)
* Complete this source code in order to print a string stored in the variable str 3 times, followed by its first 9 characters.
    - You can find the source code here
    - The output of the script should be:
        - the value of str 3 times
        - followed by a new line
        - followed by the first 9 characters of str
        - followed by a new line
    - You are not allowed to use any loops or conditional statement

### [7-concat](./7-concat)
* Complete this source code to print Welcome to Holberton School!
    - You can find the source code here
    - Your code should be exactly 12 lines long
    - You are not allowed to use any loops or conditional statement
    - You have to use the variables str1 and str2 in your new line of code

### [8-print_variables](./8-print_variables)
* Complete this source code in order to print the given variables as 972 Mission Street.
    - You can find the source code here
    - Your code should be exactly 12 lines long
    - You are not allowed to create new variables
    - You are not allowed to edit existing variables
    - The output of the script should be:
        - 972 Mission Street
        -followed by a new line

### [9-print_specifiers](./9-print_specifiers)
* Complete this source code in order to print the given variables as in the result shown.
    - You can find the source code here
    - Your code should be exactly 12 lines long
    - You are not allowed to create new variables
    - The output of the script should be:
        - Percent: 75.53% tip
        - followed by a new line
        - followed by Currency: $98,765.43
        - followed by a new line

### [10-copy_cut_paste](./10-copy_cut_paste)
* Complete this source code.
    - You can find the source code here
    - Your code should be exactly 15 lines long
    - You are not allowed to use any loops or conditional statements
    - word_first_3 should contain the first 3 letters of the variable word
    - word_last_2 should contain the last 2 letters of the variable word
    - middle_word should contain the value of the variable word without the first and last letters

### [11-concat_edges](./11-concat_edges)
* Complete this source code to print object-oriented programming in C# followed by a new line.
    - You can find the source code here
    - Your code should be exactly 11 lines long
    - You are not allowed to use any loops or conditional statements
    - You are not allowed to create new variables
    - You are not allowed to use string literals

### [100-hello_error](./100-hello_error)
* Write a C# script that prints exactly and that piece of art is useful - Dora Korpar, 2015-10-19 followed by a new line.
    - Your script should print to stderr
    - Your script should exit with the status code 1
