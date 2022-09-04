using SOLID.SRP.GoodExample;

namespace SOLID.common
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
