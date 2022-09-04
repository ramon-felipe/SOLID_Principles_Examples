namespace SOLID.DIP.BadExample
{
    public class CarEngineAssembler
    {
        public CarEngineAssembler()
        {
        }

        public Car AssembleEngine(Car car, string engineType)
        {
            car.EngineType = engineType;

            return car;
        }
    }
}