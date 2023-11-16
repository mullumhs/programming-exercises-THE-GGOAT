﻿using System;

/*
===============================================================================
PROJECT 11: AREA CALCULATOR
===============================================================================
Objective:
- Enhance understanding of selection, user input, and maths operations by calculating areas of different shapes based on user choices.

Main Tasks:
1. Create a menu that asks the user to choose between calculating the area of a rectangle or triangle.
2. Prompt the user for their choice and store it in a variable.
3. Using selection, complete the program to calculate the area of either rectangles or triangles
4. Handle invalid menu choices with a warning message.
5. Create a "Press any key to exit..." message at the end of the program.

Questions:
1. What is the difference between Console.Write() and Console.WriteLine()?
2. How is the area of each shape calculated? What mathematical operations are used?

Extension Tasks:
1. Extend the program to calculate the area of other shapes and add them to the menu. E.g. Circle, trapezium.

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
- Mathematical Functions in C#: https://www.ictdemy.com/csharp/basics/mathematical-functions-in-csharp-net-math-library
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_11_AreaCalculator
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
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/