using SOLID.ISP.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.GoodExample
{
    public class Car : Vehicle, ICar
    {
        public void OpenDoor()
            => Console.WriteLine("Opening the car's door!");
    }
}
