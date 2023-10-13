using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?
Input goes in Output goes out

Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("Hello World");
            Console.ReadLine();
            Console.WriteLine("Goodbye World");
            Console.Beep(32767, 9);
            Console.ReadLine();

        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Feedback on your C# Programming Task

Code:

The code is well-structured and follows the basic structure of a C# console application.
Good job on implementing the Console.WriteLine() and Console.ReadLine() methods correctly. They are essential for console input/output operations.
The extension tasks have been completed successfully. The Console.Beep() method is used correctly to make the console beep.
Code Commenting:

The comments in the code are clear and informative. They explain what the code is supposed to do, which is good practice. However, you might want to include more comments in the body of your code to explain what each part does, especially as your programs get more complex.
Answers to Questions:

Your answer to the question about the difference between input and output is technically correct, but it could be more detailed. For example, you could explain that input is data provided to the program by the user or another program, while output is data that the program sends out to be used by the user or another program.
Extension Tasks:

You successfully completed the extension tasks by adding another message after the ReadLine() method and making the console beep using the Console.Beep() method. Well done!
Overall, you did a great job on this assignment. Keep up the good work, and continue to explore more features of the C# programming language.


===============================================================================
*/