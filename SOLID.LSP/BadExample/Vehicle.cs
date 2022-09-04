using SOLID.Common;

namespace SOLID.LSP.BadExample
{
    public abstract class Vehicle
    {
        public abstract void TurnEngineOn();
    }

    public class VehicleHandler
    {
        public void TurnVehicleEngineOn(Vehicle vehicle)
        {
            vehicle.TurnEngineOn();
        }
    }
}
