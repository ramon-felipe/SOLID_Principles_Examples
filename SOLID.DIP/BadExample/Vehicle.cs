using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.BadExample
{
    public class Car
    {
        public string Color { get; set; }
        public string EngineType { get; set; }


        public Car()
        {
            Color = "";
            EngineType = "";
        }

        public Car(string color, string engineType)
        {
            Color = color;
            EngineType = engineType;
        }
    }
}
