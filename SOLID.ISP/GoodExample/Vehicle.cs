using SOLID.ISP.GoodExample.Interfaces;

namespace SOLID.ISP.GoodExample
{
    public abstract class Vehicle : IVehicle
    {
        public void Run()
            => Console.WriteLine("This vehicle is running!");
    }
}
