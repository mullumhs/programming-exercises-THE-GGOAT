using System;

/*
===============================================================================
PROJECT 03: DATA TYPES
===============================================================================
Objective:
- Understand and practice using different data types in C#.

Main Tasks:
1. Create an 'integer' variable and assign it a whole number.
2. Create a 'double' variable and assign it a decimal number.
3. Create a 'boolean' variable and assign it either true or false.
4. Output a single message that includes all three of your variables.
   (e.g., "There are 27 days until Christmas", "Avatar scored 7.8 on IMDb", "Door locked: false").
5. Make the program wait for input at the end using 'Console.ReadLine();'.

Questions:
1. What is the best data type for a whole number?
2. What are some data types you could use for decimal numbers?

Extension Tasks:
1. Use Google to find out what other data types are in C#, then have a go at using them.
2. Find out how to join variables to strings using "String Interpolation".

Example:
- Below is an example of creating a double precision floating point number and outputting it to the console:

    double preciseNumber = 2.997;
    Console.WriteLine("My precise number is: " + preciseNumber);
    Console.ReadLine();

Additional Resources:
- Variables: https://www.tutorialspoint.com/csharp/csharp_variables.htm
- Data Types: https://www.tutorialspoint.com/csharp/csharp_data_types.htm
- String Interpolation: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_03_DataTypes
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            int name = 983657;
            double name2 = 1.5;
            bool name3 = false;
            Console.WriteLine(name + name2);
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Feedback on your Project 03: Data Types

Code

Good job on creating the variables with the correct data types. However, it is recommended to use more descriptive variable names. For example, instead of name, name2, and name3, you could use wholeNumber, decimalNumber, and booleanValue. This would make your code more readable.
You've correctly used the Console.WriteLine function to output the values of your variables. However, the task asked you to output a single message that includes all three of your variables. You've only included two (name and name2) and the output is not in a sentence format.
Code Commenting

There are no comments in your code. Adding comments to your code can help others understand what each part of your code does. It's a good practice to start doing this early.
Answers to Questions

You didn't provide answers to the questions in your submission. Remember to answer them next time. They're designed to help you understand the concepts better.
Extension Tasks

You didn't complete the extension tasks. I encourage you to attempt these in the future as they are designed to challenge you and enhance your learning.
Please consider these points for your next assignment. Keep practicing and you will get better!


===============================================================================
*/
