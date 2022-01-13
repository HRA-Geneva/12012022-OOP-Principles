using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingPrinciples
{
    internal class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        protected int Count;


        public virtual string GetNameOfVehicle() //override
        {
            return "Bu menim ana klasimin funksionalligidir";
        }
    }
}
