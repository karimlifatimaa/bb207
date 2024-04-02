using System.Security.Cryptography.X509Certificates;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[] { };          
            string answer = "";
            do
            {

                Console.WriteLine("Elave etmek istediyini sec (bus,car) : ");
                answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "car":
                        Console.WriteLine("Brendi daxil et:");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Modeli daxil et:");
                        string model = Console.ReadLine();

                        string str = "";
                        int year;
                        do
                        {
                            Console.WriteLine("Ili daxil et :");
                            str = Console.ReadLine();
                        } while (!int.TryParse(str, out year) || year < 0);

                        string speedStr = "";
                        int maxSpeed;
                        do
                        {
                            Console.WriteLine("MaxSpeedi daxil et :");
                            speedStr = Console.ReadLine();
                        } while (!int.TryParse(speedStr, out maxSpeed) || maxSpeed < 0);

                        Car car = new Car(brand, model, year)
                        {
                            MaxSpeed = maxSpeed,
                        };
                        AddVehicle(ref vehicles, car);
                        Console.WriteLine("Car elave edildi ");
                        break;
                    case "bus":
                        string str1 = "";
                        int year1;
                        do
                        {
                            Console.WriteLine("Ili daxil et :");
                            str1 = Console.ReadLine();
                        } while (!int.TryParse(str1, out year1) || year1 < 0);
                        string countStr = "";
                        int count;
                        do
                        {
                            Console.WriteLine("Passengercount daxil et :");
                            countStr = Console.ReadLine();
                        } while (!int.TryParse(countStr, out count) || count<0);
                        Bus bus = new Bus(count, year1);
                        AddVehicle(ref vehicles, bus);
                        Console.WriteLine("Bus elave edildi ");
                        break;
                    default:
                        Console.WriteLine("Duzgun secim et !!");
                        break ;
                }
                Console.WriteLine("Daha bir cihaz elave etmek isteyirsenmi? (yes,no)");
            } while (Console.ReadLine().ToLower() == "yes");
            Console.WriteLine("--------------------------------------------------------");
            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }

        }
        public static void AddVehicle(ref Vehicle[] vehicles, Vehicle vehicle)
        {
            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = vehicle;
        }
        
        
    }
}
