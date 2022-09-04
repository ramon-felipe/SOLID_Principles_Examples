namespace SOLID.DIP.BadExample
{
    public class CarBuilder
    {
        public string EngineType { get; }
        public string Color { get; }
        public Car NewCar { get; private set; }

        public CarBuilder(string engineType, string color)
        {
            EngineType = engineType;
            Color = color;
            NewCar = new Car();
        }

        public Car Build()
        {
            var CarWithEngine = InstallEngine(NewCar, EngineType);
            var CarWithEngineAndPainted = Paint(CarWithEngine, Color);

            return CarWithEngineAndPainted;
        }

        private Car Paint(Car car, string color)
        {
            var carPainter = new CarPainter();
            var coloredCar = carPainter.Paint(car, color);
            
            return coloredCar;
        }

        private Car InstallEngine(Car car, string engineType)
        {
            var carEngineAssembler = new CarEngineAssembler();
            var carWithEngine = carEngineAssembler.AssembleEngine(car, engineType);

            return carWithEngine;
        }
    }
}