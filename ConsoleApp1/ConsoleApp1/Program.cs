using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Array'dəki ən kiçik elementi tapıb ekrana yazdırın.

            //int[] numbers = { 2, 3,-4, 5 };
            //int min = numbers[0];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine(min);





            // 2.String array'imiz var, console'dan(Console.ReadLine()) aldığımız 
            //   index dəyərinə uyğun gələn elementi tərsinə yazdırın. 

            //string[] names = {"yusif","resul","enver" };
            //Console.WriteLine("deyer daxil et: 0,1,2");
            //int index = Convert.ToInt16(Console.ReadLine());
            //string cevrilecek = names[index]; /*Console.WriteLine(cevrilecek);*/
            //for (int i =cevrilecek.Length-1 ; i >=0 ; i--)
            //{
            //    Console.Write(cevrilecek[i]);
            //}





            //3.Verilmiş integer array-in  bütün elementlərini müsbətə çevirib yeni bir array'ə tərsinə yığın və ekrana çap edin. 

            //int[] array = { -2, 3, 4, -5 };
            //int length = array.Length;
            //int[] newArray = new int[length];
            //for(int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //    {
            //         newArray[array.Length - 1 - i]= -array[i];
            //    }
            //    else
            //    {
            //         newArray[array.Length - 1 - i]=array[i] ;
            //    }
            //}
            //Console.Write("[");
            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.Write(newArray[i] + ",");
            //}
            //Console.Write("]");





            //4.Verilmiş integer array-in  bütün elementlərini stringə çevirib ekrana çap edin.
            //Məsələn, {-2,3,4,-5} verilibsə, "-2 3 4 -5" çapa verilməlidir. (optional)

            int[] array = { -2, 3, 4, -5 };
            string element = "";
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                element = array[i].ToString();
                result += element;

            }
            Console.WriteLine(result);
           
        }
    }
}
