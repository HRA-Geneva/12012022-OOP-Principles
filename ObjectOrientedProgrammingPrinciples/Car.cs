using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingPrinciples
{
    internal class Car:Vehicle
    {
        public int WheelCount { get; set; }
        public string Engine { get; set; }
        public string FuelType { get; set; }

        public Car(string name,int wheelCount,string engine,string fuelType)
        {
            Name = name;
            Engine = engine;
            WheelCount = wheelCount;
            FuelType = fuelType;
        }

        public override string GetNameOfVehicle()
        {
            return "Bu bala klasin funksionalligidir";
        }

        public string Test(int b, string s = "salam")
        {
            return "";
        }

        public string Test(int b)
        {
            return "";
        }

    }
}
