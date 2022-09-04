using SOLID.ISP.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.GoodExample
{
    public class ConvertibleCar : Car, IConvertibleCar
    {
        public void OpenRoof()
            => Console.WriteLine("Opening the car's roof!");
    }
}
