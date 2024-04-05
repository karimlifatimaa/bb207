using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Person
    {
        private static int _id;
        public int Id;
        public string FullName;
        private byte _age;
        public byte Age
        {
            get 
            { 
                return _age; 
            }
            set {
                if(value<0 || value > 125)
                {
                    Console.WriteLine("menfi ve ya 125 dan yuxari ola bilmez!");
                }
                else
                {
                    _age = value;
                }
                
            }
        }
        public int Cash;
        public override string ToString()
        {
            return $"Id : {Id} , FullName : {FullName} , Age : {Age} , Cash : {Cash}";
        }
        public Person()
        {
            _id++;
            Id = _id;
        }

    }
}
