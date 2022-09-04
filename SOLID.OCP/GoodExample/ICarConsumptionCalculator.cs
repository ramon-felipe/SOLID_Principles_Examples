using SOLID.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.GoodExample
{
    public interface ICarFuelConsumptionCalculatorFactory
    {
        CarFuelConsumptionCalculator Create(string carType);
    }

    public class CarFuelConsumptionCalculatorFactory : ICarFuelConsumptionCalculatorFactory
    {
        public CarFuelConsumptionCalculator Create(string carType)
        {
            return carType switch
            {
                nameof(CarType.HATCHBACK) => new HatchbackFuelConsumptionCalculator(),
                nameof(CarType.SEDAN) => new SedanFuelConsumptionCalculator(),
                nameof(CarType.SPORT) => new SportFuelConsumptionCalculator(),
                nameof(CarType.SUV) => new SuvFuelConsumptionCalculator(),
                _ => throw new NotImplementedException("Calculator not implemented."),
            };
        }
    }
}
