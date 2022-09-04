using SOLID.common;

namespace SOLID.SRP.GoodExample
{
    public class Car
    {
        public string Color { get; }
        private readonly CarColorVerifier _carColorVerifier;

        public Car(string color)
        {
            Color = color;
            _carColorVerifier = new CarColorVerifier(this); // passing this car instance to the CarColorVerifier
        }

        public void VerifyColor()
        {
            // Validations is now responsibility of CarColorVerifier class
            var verificationResult = _carColorVerifier.Verify();

            // Now logging is responsibility of another class (Logger)
            Logger.Log(verificationResult);
        }
    }
}
