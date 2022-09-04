namespace SOLID.DIP.GoodExample
{
    public class CarPainter : ICarPainter
    {
        public CarPainter()
        {
        }

        public Car Paint(Car car, string color)
        {
            car.Color = color;

            return car;
        }
    }

    public interface ICarPainter
    {
        Car Paint(Car car, string color);
    }
}