using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExampleIf
    {
        static void Main()
        {
            int x = 10;
            int y = 20;

            if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            else if (x > y) {
                Console.WriteLine("x is greater to y");
            }
            else
            {
                Console.WriteLine("x is less to y");
            }
        }
    }
}
