using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.examples
{
    internal class TestBox
    {
        static void Main() 
        {
            double totalArea = 0;
            Box ups; ups = new Box(); // one way to instantiate a new Box object as ups
            ups.length = 10;
            ups.width = 5;
            Console.WriteLine("Area of a quadrant with width and length of " + ups.width + " and " + ups.length + " = " + ups.CalculateArea());
            totalArea += ups.CalculateArea();
            Console.WriteLine();

            Box fedEx = new Box();  
            fedEx = new Box(); // another way to instantiate a new Box object as fedEx
            Console.WriteLine("Enter length and width: ");
            fedEx.length = Convert.ToInt32(Console.ReadLine());
            fedEx.width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of a quadrant with width and length of " + fedEx.width + " and " + fedEx.length + " = " + fedEx.CalculateArea());
            totalArea += fedEx.CalculateArea();
            Console.WriteLine();

            Console.WriteLine("Total of both areas " + " = " + totalArea);
        }
    }
}
