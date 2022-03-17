using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class ExampleSwitchCase
    {
        static void Main()
        {
            string caseNumber = "Three";

            switch (caseNumber)
            {
                case "Zero":
                    Console.WriteLine(" value is 0");
                    break;
                case "One":
                    Console.WriteLine(" value is 1");
                    break;
                case "Two":
                    Console.WriteLine(" value is 2");
                    break;
                case "Three":
                    Console.WriteLine(" value is 3");
                    break;
                default:
                    Console.WriteLine(" value not found");
                    break;
            }
        }
    }
}
