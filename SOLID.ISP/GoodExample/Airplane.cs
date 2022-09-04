using SOLID.ISP.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.GoodExample
{
    public class Airplane : Vehicle, IAirplane
    {
        public void Fly()
            => Console.WriteLine("The airplane is flying!");
    }
}
