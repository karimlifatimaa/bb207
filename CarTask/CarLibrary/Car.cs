using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        private static int _id=1000;
        public int Id;
        public string Name {  get; set; }
        public int Speed {  get; set; }
        public string CarCode {  get; set; }        
        public Car(string name,int speed)
        {
            _id++;
            Id = _id;
            Name = name;
            Speed = speed;
            MakeCarCode(name);
            Console.WriteLine();

        }
        public string MakeCarCode(string name)
        {
            CarCode = name.Substring(0, 2).ToUpper()+Id;
            return CarCode; 
        }
    }
}
