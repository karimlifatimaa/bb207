using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            StringTrim(" salam,      Dunya");
            Console.WriteLine("--------------------------------");

            //2
            string str = " Dun77ya";
            Method(str);
            Console.WriteLine("---------------------------------");

            //3
            Console.WriteLine(FindWord("   baki dovlet uni"));
            Console.WriteLine("---------------------------------");

            //StartUpper("   Baki Dovlet");

            //5
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("evvelki:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            AddToArray(ref numbers, 6);
            Console.WriteLine();
            Console.WriteLine("elave olunandan sonraki array");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }



        }
        public static void StringTrim(string a)
        {
            string newStr = "";
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] == ' ')
                {
                    continue;
                }
                newStr += a[i];
            }
            Console.WriteLine(newStr);
        }
       
        public static bool Method(string a)
        {
            bool boyukHerf = false;
            bool kicikHerf = false;
            bool reqem = false;
            for (int i = 0;i<a.Length;i++)
            {
                if (a[i] >='A' && a[i] <= 'Z')
                {
                    Console.WriteLine( "stringde en az 1 boyuk herf var ");
                    boyukHerf = true;
                   

                }
                else if (a[i] >='a' && a[i] <= 'z')
                {
                    Console.WriteLine("stringde en az 1 kicik herf var ");
                    kicikHerf = true;
                   
                }
                else if (a[i] >=48 && a[i] <= 57)
                {
                    Console.WriteLine("stringde en az 1 eded var ");
                    reqem = true;                  

                }
            }
            return boyukHerf && kicikHerf && reqem; ;
        }


        public static string FindWord(string a)
        {
            string newStr = "";
            int temp=0;
            while( temp <a.Length && a[temp]==' ')
            {
                temp++;    
            }
            for (int i = temp; i < a.Length; i++)
            {
                if (a[i]!=' ')
                {
                    newStr+= a[i];
                }
                else
                {
                    break;
                }
            }

            return newStr;

        }


        public static void AddToArray(ref int[] arr,int value)
        {
            int[] newArray = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }            
            newArray[arr.Length] = value;            
            arr = newArray;
        }
        

    }
}
