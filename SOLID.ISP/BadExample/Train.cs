using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.BadExample
{
    public class Train : IVehicle
    {
        public void Fly()
            => throw new NotImplementedException();

        public void GoToNextStation()
            => Console.WriteLine("The train is going to the next station!");

        public void OpenDoor()
            => Console.WriteLine("Opening the train's door");

        public void OpenRoof()
            => throw new NotImplementedException();

        public void Run()
            => Console.WriteLine("The train is running!");
    }
}
