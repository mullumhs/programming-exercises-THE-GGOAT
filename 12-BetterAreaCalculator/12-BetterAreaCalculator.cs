﻿using System;

/*
===============================================================================
PROJECT 12: BETTER AREA CALCULATOR
===============================================================================
Objective:
- Learn how to refactor code into more manageable chunks using methods, improving readability and reusability of the code.

Main Tasks:
1. Copy and paste your program from the previous lesson into this one.
2. Write methods for each of the main functions of the program. E.g. ShowMenu, CalculateRectangle, CalculateTriangle, etc.
3. Move the corresponding code into each method.
4. Call the methods from the Main method.

Questions:
1. What is the purpose of splitting the code into smaller chunks (methods)?
2. Why is it important to give a warning message to the user in the else statement?

Extension Tasks:
1. Add a trapezium option to the program. It should also be a separate method.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Methods: https://www.w3schools.com/cs/cs_methods.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_12_BetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Menushow();
            String choice = Console.ReadLine();

            if (choice == "1")
            {
                CircleArea();
            }
            else if (choice == "2")
            {
                RectangleArea();
            }
            else if (choice == "3")
            {
                TriangleArea();
            }
            WaitAndExit();
        }

        static void Menushow()
        {
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");

        }

        static void CircleArea()
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area}");
        }
        static void RectangleArea()
        {
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of the rectangle is {width * height}");
        }

        static void TriangleArea()
        {
            Console.Write("Enter base: ");
            double bas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height");
            double height1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of the triangle is {(height1 * bas) / 2}");
        }

        static void WaitAndExit()
        {
            Console.ReadLine();
        }
           
        
            // Your code goes below here

     
    


/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/