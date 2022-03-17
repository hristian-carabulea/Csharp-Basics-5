using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day2.encapsulation
{
    // Encapsulation :  Concept of writing programs with
    //                  Data, and Methods which act on the Data.
    // Data hiding
    /// <summary>
    /// Encapsulation Employee Pay
    /// </summary>

    class Employee
    {
        private double salary;
        private double bonus;

        public void SetSalary(double salary)
        {
            if (salary < 40000 || salary > 150000)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please check salary");
                this.salary = 0;
                this.bonus = 0;
            }
            else
            {
                this.salary = salary;
                this.bonus = this.salary * 0.20;
            }
        }
        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            //Console.WriteLine(" ");
            Console.WriteLine("Total Pay = " + totalPay);
        }
    }

}
