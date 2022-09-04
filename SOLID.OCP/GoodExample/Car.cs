namespace SOLID.OCP.GoodExample
{
    public class Car
    {
        public string Color { get; }
        public string Type { get; }
        public bool IsSpeedKitInstalled { get; }

        public Car(string color, string carType, bool isSpeedKitInstalled)
        {
            Color = color;
            Type = carType;
            IsSpeedKitInstalled = isSpeedKitInstalled;
        }

        // Using Factory Design Pattern to get the appropriate calculator by car's type
        public double GetFuelConsumption()
        {
            // Instantiante the ca
            var carFuelConsumptionCalculatorFactory = new CarFuelConsumptionCalculatorFactory();
            var fuelCalculator = carFuelConsumptionCalculatorFactory.Create(Type);
            var fuelConsumption = fuelCalculator.Calculate(IsSpeedKitInstalled);

            return fuelConsumption;
        }
    }
}
