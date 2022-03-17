using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day3.project1
{
    /// <summary>
    /// Data:employeeName & employeeGrade,
    /// Constructor Employee
    /// </summary>
    internal class Employee
    {
        private string employeeName;
        public int employeeGrade { private set; get; }

        public Employee(string employeeName, int employeeGrade)
        {
            this.employeeName = employeeName;
            this.employeeGrade = employeeGrade;
        }

        /// <summary>
        /// Return the name and paygrade for each employee
        /// </summary>
        /// <returns></returns>
        public string ReturnNameAndGrade()
        {
            string temp = employeeName + "(" + employeeGrade + ")";
            return temp;
        }
    }
}
