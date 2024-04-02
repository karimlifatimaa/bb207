using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Car : Vehicle
    {
        public string Brand {  get; set; }
        public string Model {  get; set; }
        private int _maxSpeed;

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
                else
                {
                    Console.WriteLine("MaxSpeed menfi ola bilmez.");
                }
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year : {Year}, Max Speed: {MaxSpeed}");
        }
        public Car(string brand,string model,int year):base(year)
        {
            Brand = brand;
            Model = model;                
        }
    }
  
}
