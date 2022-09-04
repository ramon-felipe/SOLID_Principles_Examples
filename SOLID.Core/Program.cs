// See https://aka.ms/new-console-template for more information

using SOLID.Common;
using SOLID.DIP.GoodExample;
/*using SOLID.DIP.BadExample;
using SOLID.ISP.GoodExample;*/

/*using badExample_SRP = SOLID.SRP.BadExample;
using goodExample_SRP = SOLID.SRP.GoodExample;

using goodExample_OCP = SOLID.OCP.GoodExample;

using badExample_LSP = SOLID.LSP.BadExample;
using SOLID.LSP.GoodExample;*/
// using SOLID.LSP.BadExample;

#region SRP
/*Console.WriteLine("..::SRP example::..");

var myRedCar_OCP = new goodExample_OCP.Car("blue", CarType.HATCHBACK, true);
var fuelConsumption = myRedCar_OCP.GetFuelConsumption();

Console.WriteLine(fuelConsumption);*/
#endregion
#region LSP
#region badExample
/*Console.WriteLine("..::LSP example::..");

var vehicleHandler = new VehicleHandler();
var mustang = new Car();
var bicycle = new Bicycle();
var vehicles = new List<Vehicle> { mustang, bicycle };

foreach (var vehicle in vehicles)
{
    vehicleHandler.TurnVehicleEngineOn(vehicle);
    // vehicle.TurnEngineOn();
}*/
#endregion
#region goodExample
/*Console.WriteLine("..::LSP example::..");
var vehicleHandler = new VehicleHandler();

var mustang = new Car(220);
var eletricBicycle = new EletricBicycle(100);
var commonBicycle = new Bicycle(60);
var vehicles = new List<Vehicle> { mustang, eletricBicycle, commonBicycle };

foreach (var vehicle in vehicles)
{
    vehicleHandler.TurnVehicleEngineOn(vehicle);
}

var motorizedVehicles = new List<MotorizedVehicle> { mustang, eletricBicycle, commonBicycle };

foreach (var motorizedVehicle in motorizedVehicles)
{
    vehicleHandler.TurnVehicleEngineOn(motorizedVehicle);
}*/
#endregion
#endregion
#region ISP

/*var airplane = new Airplane();
airplane.;*/

#endregion
#region DIP
#region BadExample
/*var carBuilder = new CarBuilder("V8", "green");
var car = carBuilder.Build();

Console.WriteLine("Car color is: {0}", car.Color);
Console.WriteLine("Car engine is: {0}", car.EngineType);*/
#endregion
#region GoodExample
var newCar = new Car();
var carPainter = new CarPainter();
var carEngineAssembler = new CarEngineAssembler();
var carBuilder = new CarBuilder(newCar, carPainter, carEngineAssembler);

var finishedCar = carBuilder.Build("V8", "green");

Console.WriteLine("Car color is: {0}", finishedCar.Color);
Console.WriteLine("Car engine is: {0}", finishedCar.EngineType);
#endregion
#endregion

Console.ReadKey();