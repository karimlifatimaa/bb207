using System.Xml.Linq;

namespace ConsoleApp1Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            Department department = new Department();

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Butun iscilere bax");
                Console.WriteLine("0. Proqramı bitir");
                Console.WriteLine("3. Maas araligina gore axtaris et");
                Console.WriteLine("Seciminizi edin : (1,2,3,0)");
                Console.WriteLine("-----------------------------------");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Iscinin adini daxil et : ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Iscinin soyadini daxil et : ");
                            string surname = Console.ReadLine();

                            string ageStr = "";
                            byte age;
                            do
                            {
                                Console.WriteLine("Iscinin yasini daxil et : ");
                                ageStr = Console.ReadLine();

                            } while (!byte.TryParse(ageStr, out age));


                            Console.WriteLine("Iscinin departmentnameni daxil et : ");
                            string departmentName = Console.ReadLine();


                            string ageStr1 = "";
                            int salary;
                            do
                            {
                                Console.WriteLine("Iscinin maasini daxil et : ");
                                ageStr1 = Console.ReadLine();

                            } while (!int.TryParse(ageStr1, out salary));

                            Employee employee = new Employee(name, surname, age, departmentName, salary);
                            department.AddEmployee(employee);
                            Console.WriteLine($"{employee.Name} {employee.Surname}");

                        } while (answer != "1");
                        break;
                     case "2":
                        department.ShowEmployeeInfo();
                        break;
                    case "3":
                        Console.WriteLine( "minSalaryni daxil et :");
                        int minSalary=Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("maxSalaryni daxil et :");
                        int maxSalary = Convert.ToInt32(Console.ReadLine());
                        Employee[] filteredEmployees = department.GetAllEmployeesBySalary(minSalary, maxSalary);
                       
                        for(int i = 0; i < filteredEmployees.Length; i++)
                        {
                            Console.WriteLine($"{filteredEmployees[i].Name} {filteredEmployees[i].Surname} age is {filteredEmployees[i].Age} department name is {filteredEmployees[i].DepartmentName} salary is {filteredEmployees[i].Salary}");

                        }
                        break;

                    case "0":
                        Console.WriteLine("proqram bitti");
                        break;
                    default:
                        Console.WriteLine("duzgun secim et");
                        break;

                }
            } while (answer != "0");
        }
    }
}
