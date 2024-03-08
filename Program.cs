using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Verilmis ededin reqemlerinin hasili.
            //int eded = 53211;
            //int hasil = 1;
            //while (eded != 0)
            //{
            //    int qaliq = eded % 10;
            //    hasil *= qaliq;
            //    eded = eded - qaliq;
            //    eded = eded / 10;
            //}
            //Console.WriteLine(hasil);




            //2.Verilmis ededin sade ve ya murekkeb oldugunu tapan alqoritm.
            //int eded = 12;
            //int say = 0;
            //for(int i = 1; i <= eded; i++)
            //{
            //    if (eded % i == 0)
            //    {
            //        say += 1;
            //    }
            //}
            //Console.WriteLine("Bolenlerinin sayi:");
            //Console.WriteLine(say);
            //if (say > 2)
            //{
            //    Console.WriteLine("Murekkeb ededdir");
            //}
            //else
            //{
            //    Console.WriteLine("Sade ededdir");
            //}





            //3.Verilmis ededin faktorialini tapin.
            //int eded = 9;
            //long faktorial = 1;
            //for (int i = 1; i <= eded; i++)
            //{
            //    faktorial *= i;
            //}
            //Console.WriteLine(faktorial);





            //4.Verilmiş ədədin polindrom olub olmadığını tapan alqoritm.
            int ilkinVerilen = 1221;
            int eded = ilkinVerilen;
            int qaliq = 0;
            int tersi = 0;
            while (ilkinVerilen != 0)
            {
                qaliq = ilkinVerilen % 10;
                tersi = tersi * 10 + qaliq;
                ilkinVerilen = ilkinVerilen - qaliq;
                ilkinVerilen = ilkinVerilen / 10;

            }
            if (eded == tersi)
            {
                Console.WriteLine("Polindromdur");
            }
            else
            {
                Console.WriteLine("Polindrom deyil");
            }
        }
    }
}