using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.examples
{
    class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee hari = new Employee();

            Console.WriteLine("Data for alex: ");
            alex.salary = 90000;
            alex.bonus = 3000;
            alex.CalculateTotalPay();

            Console.WriteLine("Data for hari: ");
            hari.salary = 10000;
            hari.bonus = 2000;
            hari.CalculateTotalPay();
        }
    }
}
