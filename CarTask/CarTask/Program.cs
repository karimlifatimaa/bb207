using CarLibrary;

namespace CarTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new Gallery();
            string answer = "";
            do
            {
                Console.WriteLine("1.AddCar() - Car objecti qebul edib array'e add edir,");
                Console.WriteLine("2.ShowAllCars() - Arraydeki butun Carlari gosterir,");
                Console.WriteLine("3.GetAllCars() - Arraydeki butun Carlari qaytarir,");
                Console.WriteLine("4.FindCarById() - verilmis id-e uygun olan car'i tapib qaytarir,");
                Console.WriteLine("5.FindCarByCarCode() - CarCode uygun olan car'i tapib qaytarir,");
                Console.WriteLine("6.FindCarsBySpeedInterval() - max ve min speed qebul edib bu suret araligindaki car'lari geri qaytarir");
                Console.WriteLine("0.Proqram bitti");
                Console.WriteLine("Secim et");
                answer = Console.ReadLine();
                
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Name daxil et");
                         string name=Console.ReadLine();

                        string speedStr = "";
                        int speed;
                        do
                        {
                            Console.WriteLine("Speed daxil et");
                            speedStr = Console.ReadLine();

                        } while (!int.TryParse(speedStr,out speed));

                        Car car = new Car(name,speed);
                        gallery.AddCar(car);                        
                        break;  
                    case "2":
                        gallery.ShowAllCars();
                        break; 
                    case "3":
                        Car[] neww=gallery.GetAllCars();
                        for(int i = 0; i < neww.Length; i++) {
                            Console.WriteLine(neww[i].Name);
                        }
                        break;
                    case "4":

                        string idStr = "";
                        int id;
                        do
                        {
                            Console.WriteLine("axtardiginiz id ni daxil edin");
                            idStr = Console.ReadLine();

                        } while (!int.TryParse(idStr, out id));

                        Car filteredById = gallery.FindCarById(id);

                        if (filteredById != null)
                        {
                            Console.WriteLine(filteredById.Name);
                        }
                        else
                        {
                            Console.WriteLine("Id tapilmadi");
                        }

                        break;
                    case "5":
                                               
                        Console.WriteLine("CarCode deyeri daxil et");
                        string carCode = Console.ReadLine();
                        Car findCar = gallery.FindCarByCarCode(carCode);
                        if (findCar != null)
                        {
                            Console.WriteLine(findCar.Name);
                        }
                        else
                        {
                            Console.WriteLine("CarCode tapilmadi");
                        }

                        break;
                    case "6":
                        Console.WriteLine("minspeed daxil et");
                        int minSpeed = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("maxspeed daxil et");
                        int maxSpeed = Convert.ToInt32(Console.ReadLine());
                        Car[] speedInterval = gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed);
                        for(int i = 0; i < speedInterval.Length; i++)
                        {
                            Console.WriteLine(speedInterval[i].Name);
                        }

                        break;
                    case "0":
                        Console.WriteLine("proqram bitti");
                        break;
                    default: Console.WriteLine("duzgun secim et");
                        break;
                }

            } while (answer!="0");
        }
    }
}
