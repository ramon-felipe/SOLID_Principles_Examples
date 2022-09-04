using SOLID.common;
using SOLID.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.BadExample
{
    public class Car : Vehicle
    {
        public bool IsEngineOn { get; private set; }

        public override void TurnEngineOn()
        {
            Console.WriteLine("Mustang engine is on now!");
            this.IsEngineOn = true;
        }
    }
    
    public class Bicycle : Vehicle
    {

        public override void TurnEngineOn()
        {
            throw new NotImplementedException("This bike has no engine!");
        }
    }
}
