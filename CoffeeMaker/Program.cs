using CoffeeMaker;
using CoffeeMaker.Controllers;
using CoffeeMaker.Controllers.WaterControllerHeater;
using CoffeeMaker.Controllers.WaterControllers;
using CoffeeMaker.Models;
using CoffeeMaker.Models.WaterContainer;

// Set the max and min water level for water container
Factory.ConfigureWaterContainer(1000, 150);
IWaterContainer waterContainer = Factory.CreateWaterContainer();

// Set the capacity for bean container
Factory.ConfigureBeanContainer(50);
IAutoCoffeebeanControllerWithGrinder autoCoffeebeanControllerWithGrinder = Factory.CreateAutoCoffeebeanControllerWithGrinder();

//IWaterController waterController = new WaterController(waterContainer);
IWaterControllerHeater waterControllerHeater = Factory.CreateWaterControllerHeater();



AutoKaffeMachine autoKaffeMachine = new AutoKaffeMachine(waterControllerHeater, autoCoffeebeanControllerWithGrinder);

string coffeeMakingStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.Americano);
Console.WriteLine(coffeeMakingStatus);

coffeeMakingStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.Cappuccino);
Console.WriteLine(coffeeMakingStatus);

coffeeMakingStatus =  autoKaffeMachine.MakeCoffee(CoffeeProgram.Espresso);
Console.WriteLine(coffeeMakingStatus);

coffeeMakingStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.HotWater);
Console.WriteLine(coffeeMakingStatus);

coffeeMakingStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.Americano);
Console.WriteLine(coffeeMakingStatus);

coffeeMakingStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.DoubleEspresso);
Console.WriteLine(coffeeMakingStatus);

coffeeMakingStatus = autoKaffeMachine.MakeCoffee(CoffeeProgram.Americano);
Console.WriteLine(coffeeMakingStatus);

Console.ReadLine();
