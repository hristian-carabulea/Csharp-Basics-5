 using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.overloading
{
    internal class TestBox
    {
        static void Main()
        {
            Box obj1 = new Box();
            obj1.CalculateArea(4.56);

            Box obj2 = new Box();
            obj2.CalculateArea(19);

            Box obj3 = new Box();
            obj3.CalculateArea(4, 9);

        }
    }
}
