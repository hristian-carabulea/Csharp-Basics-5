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
            Alex.CalculateTotalPay();

            Lynda.SetSalary(160000);
            //Lynda.bonus = 20000;
            Lynda.CalculateTotalPay();
        }
    }
}
