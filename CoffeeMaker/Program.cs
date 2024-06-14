using CoffeeMaker;
using CoffeeMaker.Controllers.WaterControllerHeater;
using CoffeeMaker.Controllers.WaterControllers;
using CoffeeMaker.Models;
using CoffeeMaker.Models.WaterContainer;

// Set the max and min water level for water container
Factory.ConfigureWaterContainer(1000, 150);
IWaterContainer waterContainer = Factory.CreateWaterContainer();



//IWaterController waterController = new WaterController(waterContainer);
IWaterControllerHeater waterControllerHeater = Factory.CreateWaterControllerHeater();

AutoKaffeMachine autoKaffeMachine = new AutoKaffeMachine(waterControllerHeater);

string waterStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.Americano);
Console.WriteLine(waterStatus);

waterStatus =autoKaffeMachine.MakeCoffee(CoffeeProgram.Cappuccino);
Console.WriteLine(waterStatus);

waterStatus =  autoKaffeMachine.MakeCoffee(CoffeeProgram.Espresso);
Console.WriteLine(waterStatus);

waterStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.HotWater);
Console.WriteLine(waterStatus);

waterStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.Americano);
Console.WriteLine(waterStatus);

waterStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.DoubleEspresso);
Console.WriteLine(waterStatus);

waterStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.Americano);
Console.WriteLine(waterStatus);