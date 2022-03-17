using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.constructor
{
    internal class SmallBox
    {
        public int length;
        public int width;

        // defining a constructor
        /// <summary>
        /// SmallBox constructor
        /// </summary>
        public SmallBox()
        {
            length = 8;
            width = 8;
            Console.WriteLine("Constructor Fired");
        }

        /// <summary>
        /// SmallBox constructor which receives parameters
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public SmallBox(int length, int width)
        {
            this.length = length;
            this.width = width;
            Console.WriteLine("Constructor with parameters Fired");
        }


        /// <summary>
        /// Method CalculateArea() public, returns no values.
        /// </summary>
        public void CalculateArea()
        {
            Console.WriteLine("Area = " + (length * width));
        }
    }
}
