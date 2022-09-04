using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.BadExample
{
    public class Airplane : IVehicle
    {
        public void Fly()
            => Console.WriteLine("The airplane is flying!");

        public void GoToNextStation()
            => throw new NotImplementedException();

        public void OpenDoor()
            => Console.WriteLine("Opening door of the airplane");

        public void OpenRoof()
            => throw new NotImplementedException();

        public void Run()
            => Console.WriteLine("The airplane is running");
    }
}
