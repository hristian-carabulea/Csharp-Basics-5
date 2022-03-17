using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.constructor
{
    internal class TestSmallBox
    {
        static void Main()
        {
            // will not use values from Constructor
            SmallBox fedEx1 = new SmallBox();
            fedEx1.length = 6;
            fedEx1.width = 5;
            fedEx1.CalculateArea();

            // will use default values from Constructor
            SmallBox fedEx2 = new SmallBox();
            //fedEx2.length = 7;
            //fedEx2.width = 6;
            fedEx2.CalculateArea();

            // will use default values from Constructor
            SmallBox fedEx3 = new SmallBox(7, 6);
            //fedEx3.length = 7;
            //fedEx3.width = 6;
            fedEx3.CalculateArea();


        }
    }
}
