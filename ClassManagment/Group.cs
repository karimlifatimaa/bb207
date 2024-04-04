using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagment
{
    internal class Group
    {
        public string GroupNo;
        private int _studentLimit;
        public int StudentLimit {
            get { return _studentLimit; }
            set
            {
                if (value <= 5 || value >= 18)
                {
                    Console.WriteLine("Minumum 5 maximum 18 ola bilər.");
                }
                else
                {
                    _studentLimit = value;
                }
            }
        }
        private Student[] Students=new Student[] {};
        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5)
            {
                if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                {
                    return true;
                }
            }

            return false;
        }
        public void AddStudent(Student student )
        {
            if (StudentLimit > Students.Length) {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length-1] = student;
            }
            else
            {
                Console.WriteLine("Limit kecib");
            }

        }
        public Student GetStudent(int id)
        {
            for(int i=0; i<Students.Length; i++)
            {
                if(Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            return null;
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
    }
}
