using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagment
{
    internal class Student
    {
        private static int _id;
        public int Id;
        public string Fullname;
        public int Point;
        public Student(string fullName,int point)
        {
            _id++;
            Id = _id;
            Fullname = fullName;
            Point = point;  
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id :{Id} , Fullname :{Fullname} , Point :{Point}");
        }
        
    }
}
