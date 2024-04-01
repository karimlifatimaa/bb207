using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Gallery
    {
        public static int id;
        public string Name;
        public Car[] cars = new Car[] { };
        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length+1);
            cars[cars.Length-1] = car;
        }
        public void ShowAllCars()
        {
            for (int i=0;i<cars.Length;i++)
            {
                Console.WriteLine($"Name : {cars[i].Name} , Speed : {cars[i].Speed} , CarCode :{cars[i].CarCode}");
            }
        }
        public Car[] GetAllCars()
        {
            return cars;
        }
        public Car FindCarById(int id)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Id == id)
                {
                    return cars[i];
                }
            }
            return null;
        }
        public Car FindCarByCarCode(string carCode)
        {
            for(int i = 0; i < cars.Length; i++)
            {
                if (cars[i].CarCode == carCode)
                {
                    return cars[i];
                }
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed,int maxSpeed)
        {
            Car[] carsBySpeedInterval = new Car[] { };
            for(int i = 0;i < cars.Length;i++) {
                if (cars[i].Speed>=minSpeed && cars[i].Speed <= maxSpeed)
                {
                    Array.Resize(ref carsBySpeedInterval, carsBySpeedInterval.Length + 1);
                    carsBySpeedInterval[carsBySpeedInterval.Length - 1] = cars[i];
                    
                }

            }
           return carsBySpeedInterval;
        }
      
    }
}
