using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitFramework.model
{
    class Vehicle
    {
        public String color { get; set; } 

        public int wheels { get; set; }

        public Vehicle(String color, int wheels)
        {
            this.color = color;
            this.wheels = wheels; 
        }
    }
}
