using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.examples
{
    class Box
    {
        public int length; // class level data
        public int width;  // class level data

        public int CalculateArea()
        {
            int area = this.width * this.length;
            //Console.WriteLine("Area of a quadrant with width and length of " + width + " and " + length + " = " + area);
            return area;
        }
    }
}
