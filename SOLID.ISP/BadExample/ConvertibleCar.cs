using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.BadExample
{
    public class ConvertibleCar : Car
    {
        public override void OpenRoof()
            => Console.WriteLine("Opening roof of the convertible car!");
    }
}
