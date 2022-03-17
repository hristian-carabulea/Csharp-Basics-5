using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day1.examples
{
    class Exercise2
    {
        /// <summary>
        /// Exercise 2 array of strings
        /// </summary>
        static void Main()
        {
            //double salary;

            string[] strs = {"3.45", "3.87", "87.98", "56.7"};
            double sum = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                sum += Convert.ToDouble(strs[i]);
            }
            Console.WriteLine("The sum is " + sum);
        }
    }
}
