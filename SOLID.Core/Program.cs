// See https://aka.ms/new-console-template for more information

using SOLID.Common;

#region SRP
#region badExample

using badExample_SRP = SOLID.SRP.BadExample;

Console.WriteLine("..::SRP example::..");

var myRedCar = new badExample_SRP.Car("blue");
myRedCar.SaveCar(myRedCar);

#endregion

#region goodExample
/*using goodExample_SRP = SOLID.SRP.GoodExample;

Console.WriteLine("..::SRP example::..");

var myRedCar_SRP = new goodExample_SRP.Car("blue");
myRedCar_SRP.VerifyColor();*/
#endregion
#endregion

#region OCP
#region badExample

/*using badExample_OCP = SOLID.OCP.BadExample;

Console.WriteLine("..::OCP bad example::..");

var car = new badExample_OCP.Car("blue", CarType.HATCHBACK, true);
var fuelConsumption = car.GetFuelConsumption();

Console.WriteLine(fuelConsumption);*/

#endregion

#region goodExample
#endregion

/*using goodExample_OCP = SOLID.OCP.GoodExample;

Console.WriteLine("..::OCP good example::..");

var car = new goodExample_OCP.Car("blue", CarType.HATCHBACK, true);
var fuelConsumption = car.GetFuelConsumption();

Console.WriteLine(fuelConsumption);*/

#endregion

#region LSP
#region badExample

/*using badExample_LSP = SOLID.LSP.BadExample;

Console.WriteLine("..::LSP bad example::..");

var vehicleHandler = new badExample_LSP.VehicleHandler();
var mustang = new badExample_LSP.Car();
var bicycle = new badExample_LSP.Bicycle();
var vehicles = new List<badExample_LSP.Vehicle> { mustang, bicycle };

foreach (var vehicle in vehicles)
{
    vehicleHandler.TurnVehicleEngineOn(vehicle);
    // vehicle.TurnEngineOn();
}*/

#endregion
#region goodExample

/*using goodExample_LSP = SOLID.LSP.GoodExample;

Console.WriteLine("..::LSP good example::..");
var vehicleHandler = new goodExample_LSP.VehicleHandler();

var mustang = new goodExample_LSP.Car(220);
var eletricBicycle = new goodExample_LSP.EletricBicycle(100);
var commonBicycle = new goodExample_LSP.Bicycle(60);

// It's not possible to use a object of type different from MotorizedVehicle (compile error)
var motorizedVehicles = new List<goodExample_LSP.MotorizedVehicle> { mustang, eletricBicycle*//*, commonBicycle*//* };

foreach (var motorizedVehicle in motorizedVehicles)
{
    vehicleHandler.TurnVehicleEngineOn(motorizedVehicle);
}*/

#endregion
#endregion

#region ISP
#region badExample

/*using badExample_ISP = SOLID.ISP.BadExample;

Console.WriteLine("..::ISP bad example::..");

// Airplane id doing things it do not need to do just because we are using a generic interface
var airplane = new badExample_ISP.Airplane();
airplane.Fly();
airplane.GoToNextStation(); //Not implemented exception
airplane.OpenRoof(); //Not implemented exception*/

#endregion
#region goodExample

/*using goodExample_ISP = SOLID.ISP.GoodExample;

Console.WriteLine("..::ISP good example::..");

var airplane = new goodExample_ISP.Airplane();
var convertibleCar = new goodExample_ISP.ConvertibleCar();

// objects do only what they need to do. Here we're using many interfaces
airplane.Run();
airplane.Fly();

convertibleCar.OpenDoor();
convertibleCar.OpenRoof();
convertibleCar.Run();*/

#endregion
#endregion

#region DIP
#region BadExample

/*using badExample_DIP = SOLID.DIP.BadExample;

Console.WriteLine("..::DIP bad example::..");

// The carBuilder in this example has too many coupling.
// We'are not passing services as dependencies instead we're instanciating them into the CarBuilder class.
var carBuilder = new badExample_DIP.CarBuilder("V8", "green");
var car = carBuilder.Build();

Console.WriteLine("Car color is: {0}", car.Color);
Console.WriteLine("Car engine is: {0}", car.EngineType);*/

#endregion
#region GoodExample

/*using goodExample_DIP = SOLID.DIP.GoodExample;

Console.WriteLine("..::DIP good example::..");

// Here we're passing the services/objects via dependency injection
// We don't worry about the implementaion in this case. We just delegate to other objects we are receiving

var newCar = new goodExample_DIP.Car();
var carPainter = new goodExample_DIP.CarPainter();
var carEngineAssembler = new goodExample_DIP.CarEngineAssembler();
var carBuilder = new goodExample_DIP.CarBuilder(newCar, carPainter, carEngineAssembler);

var finishedCar = carBuilder.Build("V8", "green");

Console.WriteLine("Car color is: {0}", finishedCar.Color);
Console.WriteLine("Car engine is: {0}", finishedCar.EngineType);*/

#endregion
#endregion

Console.ReadKey();