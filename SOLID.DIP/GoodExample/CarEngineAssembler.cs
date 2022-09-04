namespace SOLID.DIP.GoodExample
{
    public class CarEngineAssembler : ICarEngineAssembler
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

    public interface ICarEngineAssembler
    {
        Car AssembleEngine(Car car, string engineType);
    }
}