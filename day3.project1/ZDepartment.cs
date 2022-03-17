using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day3.project1
{
    class ZDepartment
    {
        /// <summary>
        /// data
        /// </summary>
        private string deptName;
        private double deptBudget;
        private int counter = 0;
        Employee[] employees = new Employee[5];

        /// <summary>
        /// Method AddEmployee
        /// </summary>
        /// <param name="obj"></param>
        public void AddEmployee(Employee obj)
        {
            employees[counter] = obj;
            counter++;
            if (obj.employeeGrade >= 5)
                this.deptBudget += 150000;
            else 
                this.deptBudget += 100000;
        }

        public void describeDept()
        {
            string deptDescription = "\nFor department " + this.deptName +
                "\n The total budget is " + this.deptBudget +
                "\n Employees are : ";

            foreach (Employee t in employees)
            {
                if (t != null)
                {
                    deptDescription += t.ReturnNameAndGrade() + ", ";
                }
            }

            Console.WriteLine(deptDescription);

        }

        /// <summary>
        /// Constructor Department
        /// </summary>
        /// <param name="deptName"></param>
        public ZDepartment(string deptName)
        {
            this.deptName = deptName;
            this.deptBudget = 50000;
        }
    }
}
