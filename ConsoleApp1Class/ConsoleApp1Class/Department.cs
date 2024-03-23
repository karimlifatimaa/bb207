using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Class
{
    internal class Department
    {
        public Employee[] Employees = new Employee[] { };//0
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees,Employees.Length+1);//1
            Employees[Employees.Length - 1]=employee;

        }
        public void ShowEmployeeInfo()
        {
            for(int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"{Employees[i].Name} {Employees[i].Surname} {Employees[i].Age} {Employees[i].DepartmentName} {Employees[i].Salary}");
            }
        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }
        public Employee[] GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            Employee[] filteredEmployees = new Employee[] { };
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= minSalary && Employees[i].Salary <= maxSalary)
                {
                    Array.Resize(ref filteredEmployees, filteredEmployees.Length + 1);
                    filteredEmployees[filteredEmployees.Length - 1] = Employees[i];
                }
            }
            return filteredEmployees;
        }


    }
}
