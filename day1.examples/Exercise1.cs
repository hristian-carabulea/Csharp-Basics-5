using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class Exercise1
    {
        /// <summary>
        /// Exercise1. If then else.
        /// </summary>
        static void Main()
        {
            //double salary;
            double tax;
            double taxRateLimit1 = 8350;
            double taxRateLimit2 = 33950;
            double taxRate1 = 0.1;
            double taxRate2 = 0.15;
            double taxRate3 = 0.25;

            Console.WriteLine("Please enter your salary: ");
            string input = Console.ReadLine();

            double salary = Convert.ToDouble(input);
            if (salary <= taxRateLimit1)
            {
                tax = salary * taxRate1;
            }
            else if (salary > 8350 && salary <= taxRateLimit2)
            {
                tax = salary * taxRate2;
            }
            else
                tax = salary * taxRate3;

            Console.WriteLine("The tax on a salary of " + salary + " is " + tax);
        }
    }
}
