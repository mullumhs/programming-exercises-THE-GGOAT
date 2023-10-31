
using System;


/*
===============================================================================
PROJECT 06: NUMBER OPERATIONS
===============================================================================
Objective:
- Practice obtaining numerical input from the user and performing basic arithmetic operations.

Main Tasks:
1. Store user input as a floating point number for the variable 'y' as shown for 'x'.
2. Perform and output the result of multiplication using '*' with 'x' and 'y'.
3. Perform and output the result of subtraction using '-' with 'x' and 'y'.
4. Perform and output the result of division using '/' with 'x' and 'y'.
5. Wait for input before ending the program.

Questions:
1. What does "Convert.ToDouble" do?
2. What is a parameter? Give an example of where you have used one.
3. Why is the 'Console.ReadLine()' a parameter to Convert.ToDouble()?

Extension Tasks:
1. Modify the program to work with the 'double' type.
2. Research how to get the remainder of a division using the 'modulus operator'.

Example:
- Below is what the final program output might look like:

    Please enter a number for X:
    7
    Please enter a number for Y:
    3
    X plus Y = 10
    X times Y = 21
    X minus Y = 4
    X divided by Y = 2.333333

Additional Resources:
- Convert.ToDouble: https://www.tutorialspoint.com/convert-tosingle-method-in-chash
- Parameters: https://www.w3schools.com/cs/cs_method_parameters.php
- Arithmetic Operators: https://www.w3schools.com/cs/cs_operators_arithmetic.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_06_NumberOperations
    {
        static void Main(string[] args)
        {
            // How to input a number from the user and store it in a variable 'x'
            Console.WriteLine("Please enter a number for X:");
            double x = Convert.ToDouble(Console.ReadLine());

            // Your code goes below here
            Console.WriteLine("Please enter a number for Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            //Add
            Console.WriteLine($"{x} plus {y} = {x + y}");

            //Minus
            Console.WriteLine($"{x} minus {y} = {x - y}");

            //Times
            Console.WriteLine($"{x} times {y} = {x * y}");

            //Divided
            Console.WriteLine($"{x} divided {y} = {x / y}");

            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Great job on completing the task. Here are some points to consider:

Code Structure & Logic: Your code is well-structured, and the logic is sound. You have successfully implemented the arithmetic operations as required.

User Input: You've correctly used Console.ReadLine() and Convert.ToDouble() to obtain and convert user input.

Variable Naming: Your variable names 'x' and 'y' are simple and appropriate for this task. However, for more complex programs, consider using more descriptive variable names that reflect their purpose in the program.

Code Commenting: You've made appropriate use of comments to explain what each section of the code does. This is good practice and increases code readability and maintainability.

Output Formatting: The use of string interpolation to format and output the results of the operations is excellent.

Extension Tasks: It appears you've completed the first extension task by modifying the program to work with the 'double' type. However, there's no evidence of the second extension task, which was to research and implement the modulus operator.

Keep up the good work and continue to explore more features of C#. Remember to attempt all extension tasks as they are designed to challenge you and enhance your learning.


===============================================================================
*/
