using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.BadExample
{
    public class Bicycle : IVehicle
    {
        public void Fly()
            => throw new NotImplementedException();
        
        public void GoToNextStation()
            => throw new NotImplementedException();

        public void OpenDoor()
            => throw new NotImplementedException();

        public void OpenRoof()
            => throw new NotImplementedException();

        public void Run()
            => Console.WriteLine("The bicycle is running!");
    }
}
