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
        //private double salary;
        double salary; // by default it is assumed that the variable is private
        // Can display the bonus. But cannot change it, only set it.
        public double Bonus { get; private set; }

        /// <summary>
        /// giving access to private bonus
        /// </summary>
        /// <returns></returns>
        //public double GetBonus()
        //{
        //    return Bonus;
        //}
        public void SetSalary(double salary)
        {
            if (salary < 40000 || salary > 150000)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please check salary");
                this.salary = 0;
                this.Bonus = 0;
            }
            else
            {
                this.salary = salary;
                this.Bonus = this.salary * 0.20;
            }
        }
        public void CalculateTotalPay()
        {
            double totalPay = salary + Bonus;
            //Console.WriteLine(" ");
            Console.WriteLine("Total Pay = " + totalPay);
        }
    }

}
