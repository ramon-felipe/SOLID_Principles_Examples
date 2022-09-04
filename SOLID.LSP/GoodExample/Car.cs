using SOLID.common;
using SOLID.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.GoodExample
{
    public class Car : MotorizedVehicle
    {
        public Car(int maxSpeed) { this.MaxSpeed = maxSpeed; }

        public override void TurnEngineOn()
        {
            Console.WriteLine("Mustang engine is on now!");
        }

        public override void ShowMaxSpeed()
            => Console.WriteLine($"I'm a car and my max speed is {MaxSpeed}");
        
    }
    
    public class EletricBicycle : MotorizedVehicle
    {
        public EletricBicycle(int maxSpeed) { this.MaxSpeed = maxSpeed; }

        public override void TurnEngineOn()
        {
            Console.WriteLine("EletricBicycle engine is on now!");
        }

        public override void ShowMaxSpeed()
            => Console.WriteLine($"I'm an eletric bike and my max speed is {MaxSpeed}");
    }

    public class Bicycle : Vehicle
    {
        public Bicycle(int maxSpeed) { this.MaxSpeed = maxSpeed; }

        public override void ShowMaxSpeed()
            => Console.WriteLine($"I'm a bicycle and my max speed is {MaxSpeed}");
        
    }
}
