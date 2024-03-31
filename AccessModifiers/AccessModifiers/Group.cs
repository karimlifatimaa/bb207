using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Group
    {
        public string No { get; set; }
        public Student[] Students = new Student[] { };
        private int _studentLimit; 
        public int StudentLimit 
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("StudentLimit 0-dan kicik ve ya 20-den boyuk ola bilmez.");
                }
            }
        }

        public Group(string no,int studentLimit)
        {
            
            if(no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4]))
            {
                No = no;

            }
            else
            {
                Console.WriteLine("No deyeri 2 boyuk herfle baslamalı ve sonrasında 3 reqem olmalıdır (AB204 kimi)");
            }
            if (studentLimit <= 20)
            {
                StudentLimit = studentLimit;
            }
            else
            {
                Console.WriteLine("20den boyukdur");

            }


        }
        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                Console.WriteLine("Student elave edildi ");
            }
            else
            {
                Console.WriteLine("Student elave etmek olmadi ");
            }
        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Fullname is {Students[i].FullName} ");
            }
        }
        public void FilteredStudent(string searchValue)
        {
            bool found = false;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].FullName.ToLower().Contains(searchValue.ToLower()))
                {
                    Console.WriteLine($"Tapılan telebe: {Students[i].FullName}, Qrup No: {Students[i].GroupNo}, Ortalama : {Students[i].AvgPoint}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Tapılmadı");
            }
        }
    }
}
