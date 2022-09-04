using SOLID.ISP.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.GoodExample
{
    internal class Train : Vehicle, ITrain
    {
        public void GoToNextStation()
            => Console.WriteLine("The train is going to the next station!");
    }
}
