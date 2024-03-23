using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Class
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;
        
        public Employee(string name,string surname,byte age,string departmentName,int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentName;
            Salary = salary;
        }

    }
}
