using SOLID.SRP.GoodExample;

namespace SOLID.common
{
    public class CarColorVerifier
    {
        private readonly Car Car;

        public CarColorVerifier(Car car)
        {
            this.Car = car;
        }

        public string Verify()
        {
            if (Car.Color == "blue")
                return "The sky is blue";

            if (Car.Color == "red")
                return "Red is amazing!";

            if (Car.Color == "green")
                return "Its a great color!";

            return "No specific color detected";
        }
    }
}
