using SOLID.Common;

namespace SOLID.OCP.GoodExample
{
    public abstract class CarFuelConsumptionCalculator
    {
        public abstract double Calculate(bool hasSpeedKit);
    }

    public class HatchbackFuelConsumptionCalculator : CarFuelConsumptionCalculator
    {
        public override double Calculate(bool hasSpeedKit)
        {
            if (hasSpeedKit)
                return 20 + 8;

            return 20;
        }
    }

    public class SedanFuelConsumptionCalculator : CarFuelConsumptionCalculator
    {
        public override double Calculate(bool hasSpeedKit)
        {
            if (hasSpeedKit)
                return 22 + 0;

            return 22;
        }
    }

    public class SportFuelConsumptionCalculator : CarFuelConsumptionCalculator
    {
        public override double Calculate(bool hasSpeedKit)
        {
            if (hasSpeedKit)
                return 50 + 15;
            
            return 50;
        }
    }

    public class SuvFuelConsumptionCalculator : CarFuelConsumptionCalculator
    {
        public override double Calculate(bool hasSpeedKit)
        {
            if (hasSpeedKit)
                return 36 + 12;

            return 36;
        }
    }

}
