using SOLID.Common;

namespace SOLID.LSP.GoodExample
{
    public abstract class Vehicle
    {
        public int MaxSpeed { get; set; }

        public abstract void ShowMaxSpeed();
    }

    public abstract class MotorizedVehicle : Vehicle
    {
        public abstract void TurnEngineOn();
    }

    public class VehicleHandler
    {
        public void TurnVehicleEngineOn(MotorizedVehicle vehicle)
            => vehicle.TurnEngineOn();
        
        public void ShowMaxSpeed(Vehicle vehicle)
            => vehicle.ShowMaxSpeed();     
    }
}
