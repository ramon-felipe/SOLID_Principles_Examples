using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.BadExample
{
    public abstract class Car : IVehicle
    {
        public void Fly()
            => throw new NotImplementedException();

        public void GoToNextStation()
            => throw new NotImplementedException();

        public void OpenDoor()
            => Console.WriteLine("Opening car's door!");

        public abstract void OpenRoof();

        public void Run()
            => Console.WriteLine("The car is running!");
    }
}
