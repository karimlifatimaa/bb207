﻿using System.Text.RegularExpressions;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
           
            string no;
            int limit;
            int studentCount = 0;
            string str;
            do
            {
                Console.WriteLine("No daxil et 2 boyuk herfle baslamalı ve sonrasında 3 reqem olmalıdır (AB204 kimi)");
                no = Console.ReadLine();

            } while (!(no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4])));
            do
            {
                Console.WriteLine("Student sayini daxil et");
                str= Console.ReadLine();

            } while (!int.TryParse(str, out limit) || limit > 20 || limit < 0);
            Console.WriteLine("Group yaradildi ");

            Group group = new Group(no, limit);            
            do
            {
                
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Menyu");
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Butun telebelere bax");
                Console.WriteLine("3.Telebeler uzre axtaris et");
                Console.WriteLine("0.Proqram bitti");
                Console.WriteLine("Secimi et");
                Console.WriteLine("-------------------------------");

                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":

                        if (studentCount < limit) { 

                        Console.WriteLine("FullNami daxil et :");                        
                        string fullName = Console.ReadLine();

                        Console.WriteLine("GroupNo daxil et : ");
                        string groupNo = Console.ReadLine();

                        string pointStr = "";
                        double point;
                        do
                        {
                            Console.WriteLine("AvgPoint daxil et : ");
                            pointStr = Console.ReadLine();

                        } while (!double.TryParse(pointStr, out point));
                        Student student = new Student(fullName,groupNo,point);
                        group.AddStudent(student);
                            studentCount++;
                        }
                        else
                        {
                            Console.WriteLine("Limit doldu");
                        }
                        break;
                    case "2":
                        group.ShowAllStudents();
                        break; 
                    case "3":
                        Console.WriteLine("Axtaris deyerini daxil edin:");
                        string searchValue = Console.ReadLine();
                        group.FilteredStudent(searchValue);
                        break;
                    case "0":
                        Console.WriteLine("Proqram bitti");
                        break;
                    default: Console.WriteLine("Duzgun secim et");
                        break ;
                }

            } while (answer!="0" || studentCount < limit);

        }
    }
}
