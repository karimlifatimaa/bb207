using System.Linq.Expressions;

namespace ClassManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FullName daxil et");
            string fullname=Console.ReadLine();

            string pointStr = "";
            int point;
            do
            {
                Console.WriteLine("Point daxil et");
                pointStr=Console.ReadLine();

            } while (!int.TryParse(pointStr,out point));
            Student student = new Student(fullname,point);
           

            bool exit=false;
            string answer = "";
            string answer1 = "";
            do
            {
                Console.WriteLine("1.Show info");
                Console.WriteLine("2.Create new group");
                Console.WriteLine("0.cix");

                Console.WriteLine("secim et");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        student.StudentInfo();
                        break;
                    case "2":
                        
                        string groupno="";
                        do
                        {
                            Console.WriteLine("GroupNo daxil et");
                            groupno=Console.ReadLine();
                        } while (!Group.CheckGroupNo(groupno));

                        string limitStr = "";
                        int limit;
                        do
                        {
                            Console.WriteLine("Limit daxil et");
                            limitStr = Console.ReadLine();

                        } while (!int.TryParse(limitStr, out limit) || (limit<5 || limit>18));

                        Group group = new Group(groupno,limit);

                        do

                        {
                            Console.WriteLine("1. Show all students");
                            Console.WriteLine("2. Get student by id");
                            Console.WriteLine("3. Add student");
                            Console.WriteLine("0. Quit");

                            Console.WriteLine("secim et");
                            answer1 = Console.ReadLine();
                            switch (answer1)
                            {
                                case "1":
                                    Student[] newarr = group.GetAllStudents();
                                    for (int i = 0; i < newarr.Length; i++)
                                    {
                                        newarr[i].StudentInfo();
                                    }
                                    break;
                                case "2":
                                    string idStr = "";
                                    int id;
                                    do
                                    {
                                        Console.WriteLine("id daxil et");
                                        idStr = Console.ReadLine();

                                    } while (!int.TryParse(idStr, out id));
                                    group.GetStudent(id).StudentInfo();
                                    break;
                                case "3":
                                    Console.WriteLine("FullName daxil et");
                                    string fullname1 = Console.ReadLine();

                                    string pointStr1 = "";
                                    int point1;
                                    do
                                    {
                                        Console.WriteLine("Point daxil et");
                                        pointStr1 = Console.ReadLine();

                                    } while (!int.TryParse(pointStr1, out point1));
                                    Student student1 = new Student(fullname1, point1);
                                    group.AddStudent(student1);
                                    break;
                                case "0":
                                    Console.WriteLine("cixis");
                                    break;
                                default:
                                    Console.WriteLine("duzgun secim et");
                                    break;
                            }

                        } while (answer1!="0");

                       

                       
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("cix");
                        break;
                    default :
                        Console.WriteLine( "duz sec");
                        break ;
                }


            } while (!exit);
        }
    }
}