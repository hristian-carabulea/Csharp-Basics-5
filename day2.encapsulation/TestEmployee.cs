using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.encapsulation
{
    /// <summary>
    /// Data hiding helps with data entry accuracy
    /// </summary>
    internal class TestEmployee
    {
        static void Main()
        {
            Employee Alex = new Employee();
            Employee Lynda = new Employee();

            Alex.SetSalary(90000);
            //Alex.bonus = 20000;
            //Console.WriteLine("Alex's bonus is : " + Alex.GetBonus());
            Console.WriteLine("Alex's bonus is : " + Alex.Bonus);
            Alex.CalculateTotalPay();

            Lynda.SetSalary(160000);
            //Lynda.bonus = 20000;
            Console.WriteLine("Lynda's bonus is : " + Lynda.Bonus);
            Lynda.CalculateTotalPay();
        }
    }
}
