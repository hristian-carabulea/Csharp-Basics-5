using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.day3.project1
{
    internal class ZCompany
    {
        static void Main()
        {
            // use a constructor to set employee name and grade
            Employee Joe = new Employee("Joe Detroit", 6);
            Employee Vlad = new Employee("Vlad The Impaler", 9);
            Employee John = new Employee("John Wayne", 3);
            Employee Sara = new Employee("Sarah Bigboobies", 8);
            Employee Hari = new Employee("Hari Belafonte", 5);

            ZDepartment sales = new ZDepartment("Z Sales");
            sales.AddEmployee(Joe);
            sales.AddEmployee(Vlad);
            sales.AddEmployee(John);
            
            ZDepartment it = new ZDepartment("Z IT");
            it.AddEmployee(Sara);
            it.AddEmployee(Hari);
            
            sales.describeDept();
            it.describeDept();
            // Company company = new Company();

        }
    }
}
