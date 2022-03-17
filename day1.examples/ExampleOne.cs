using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExampleOne
    {
        /// <summary>
        /// 
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Hello. This is my own program.");

            int x = 10;
            int y = 3;

            int result1 = x + y;
            Console.WriteLine(x + " + " + y + " = " + result1);

            int result2 = x % y;
            Console.WriteLine("{0} % {1} = {2}", x, y, result2); 

        }
    }
}
