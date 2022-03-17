using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.examples
{
    class Employee
    {
        public double salary;
        public double bonus;
        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total Pay = " + totalPay);
        }
    }
}
