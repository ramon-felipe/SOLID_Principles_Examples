namespace SOLID.DIP.GoodExample
{
    public class CarBuilder
    {
        public Car NewCar { get; private set; }
        public ICarPainter CarPainter { get; set; }
        public ICarEngineAssembler CarEngineAssembler { get; set; }

        public CarBuilder(Car car, ICarPainter carPainter, ICarEngineAssembler carEngineAssembler)
        {
            NewCar = car;
            CarPainter = carPainter;
            CarEngineAssembler = carEngineAssembler;
        }

        public Car Build(string engineType, string color)
        {
            var CarWithEngine = InstallEngine(NewCar, engineType);
            var CarWithEngineAndPainted = Paint(CarWithEngine, color);

            return CarWithEngineAndPainted;
        }

        private Car Paint(Car car, string color)
        {
            var coloredCar = CarPainter.Paint(car, color);
            
            return coloredCar;
        }

        private Car InstallEngine(Car car, string engineType)
        {
            var carWithEngine = CarEngineAssembler.AssembleEngine(car, engineType);

            return carWithEngine;
        }
    }
}