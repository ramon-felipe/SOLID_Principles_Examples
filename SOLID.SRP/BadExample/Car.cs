namespace SOLID.SRP.BadExample
{
    public class Car
    {
        public string Color { get; }

        public Car(string color)
        {
            Color = color;
        }

        public void VerifyColor()
        {
            // Many validations
            // Logging text which is not a Car responsibility

            if(Color == "blue")
                LogText("The sky is blue");

            if(Color == "red")
                LogText("Red is amazing!");

            if(Color == "green")
                LogText("Its a great color!");
        }

        public void LogText(string text)
        {
            Console.WriteLine($"log: {text}");
        }

        // Save car is not a Car responsibility
        public void SaveCar(Car car)
        {
            LogText("Saving car...");

            // saving car logic...

            LogText("Car saved!");
        }
    }
}
