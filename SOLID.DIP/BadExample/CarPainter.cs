namespace SOLID.DIP.BadExample
{
    public class CarPainter
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
}