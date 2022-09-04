using SOLID.common;
using SOLID.Common;
using System;

namespace SOLID.OCR.BadExample
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

        public double GetFuelConsumption()
        {
            var fuelConsumption = 0;

            if (Type == CarType.SPORT)
            {
                fuelConsumption += 50;

                if (IsSpeedKitInstalled)
                    fuelConsumption += 15;
            }
            
            if (Type == CarType.HATCHBACK) 
            { 
                fuelConsumption += 20;
                
                if (IsSpeedKitInstalled)
                    fuelConsumption += 8;
            }

            if (Type == CarType.SUV)
            {
                fuelConsumption += 36;

                if (IsSpeedKitInstalled)
                    fuelConsumption += 12;
            }

            return fuelConsumption;
        }
    }
}
