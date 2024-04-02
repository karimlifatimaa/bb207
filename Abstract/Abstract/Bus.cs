using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Bus : Vehicle
    {
        private int _passengerCount;
        public int PassengerCount {
            get {  
                return _passengerCount;
            }
            set {
                if (value >= 0)
                {
                    _passengerCount = value;
                }
                else
                {
                    Console.WriteLine("PassengerCount menfi eded ola bilmez");
                }
                
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Year : {Year} , PassengerCount : {PassengerCount}");
        }
        public Bus(int passengerCount,int year):base(year)
        {
            PassengerCount = passengerCount;
        }
    }
}
