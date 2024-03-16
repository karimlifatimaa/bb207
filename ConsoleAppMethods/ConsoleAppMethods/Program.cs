namespace ConsoleAppMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.
            string[] array1 = { "birinci", "salam" };
            string[] array2 = { "ikinci", "salam" };
            OrtaqElement(array1, array2);

            //2. 
            //Hasil(2, 2, 2, 2);

            //3.
            //BasHerfA("Anar", "Eli", "Yusif", "Arif");

            //4.
            //Console.Write("Element sayini daxil et ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] fibonacciSeriyasi = FibonacciSeriyasi(n);

            //Console.WriteLine("Fibonacci Seriyası:");
            //foreach (int num in fibonacciSeriyasi)
            //{
            //    Console.Write(num + " ");
            //}

        }

        // 1. 2 string array-i içerisindeki ortaq elementleri tapib ekrana yazdiran metod;
        public static void OrtaqElement(string[] arr1, string[] arr2)
        {
            string deyer1 = "";
            string deyer2 = "";
            bool yoxlama = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                deyer1 = arr1[i];
                for (int j = 0; j < arr2.Length; j++)
                {
                    deyer2 = arr2[j];
                    if (deyer1 == deyer2)
                    {
                        yoxlama = true;
                        break;
                    }

                }
            }
            if (yoxlama)
            {
                Console.WriteLine("ortaq element var : " + deyer1);
            }
            else
            {
                Console.WriteLine("eyni element yoxdur");
            }


        }

        //2. array içerisindeki elementlerin hasilini tapib ekrana yazdiran metod;
        public static void Hasil(params int[] arr)
        {
            int hasil = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                hasil *= arr[i];
            }
            Console.WriteLine("arrayin elementleri hasili : " + hasil);
        }

        //3. Array-in içerisinde verilmiş A herfi ile başlayan elementleri ekrana yazdıran method
        // (example : {"Anar" , "Eli" , "Yusif" , "Arif" } ==> Anar , Arif)
        public static void BasHerfA(params string[] arr)
        {
            bool yoxlama = false;
            string element = "";
            for (int i = 0; i < arr.Length; i++)
            {
                element = arr[i];
                if (element[0] == 'a' || element[0] == 'A')
                {
                    yoxlama = true;
                    Console.WriteLine("bas herfi A olan soz var : " + arr[i]);

                }
            }
            if (!yoxlama)
            {
                Console.WriteLine("bas herfi A olan soz yoxdur");
            }
        }
        //4.Bir ədədi parametr kimi qəbul edib, o ədədə qədər Fibonacci seriyasını bir siyahı kimi qaytaran bir metod yazın.

        public static int[] FibonacciSeriyasi(int n)
        {
            int[] fibSeries = new int[n];
            fibSeries[0] = 0;
            fibSeries[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibSeries[i] = fibSeries[i - 1] + fibSeries[i - 2];
            }

            return fibSeries;
        }
    }
}
