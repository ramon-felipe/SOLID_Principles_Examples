using SOLID.common;

namespace SOLID.OCP.BadExample
{
    public class CarSaver
    {
        public void SaveCar(Car car)
        {
            Logger.Log("Saving car...");

            // Saving logic...

            Logger.Log("Car saved!");
        }
    }
}
