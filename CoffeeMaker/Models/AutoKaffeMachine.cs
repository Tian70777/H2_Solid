using CoffeeMaker.Controllers;
using CoffeeMaker.Controllers.CoffeebeanController;
using CoffeeMaker.Controllers.WaterControllerHeater;
using CoffeeMaker.Controllers.WaterControllers;
using CoffeeMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Models
{
    public class AutoKaffeMachine 
    {
        private IWaterControllerHeater _waterControllerHeater;
        private IAutoCoffeebeanControllerWithGrinder _autoCoffeebeanControllerWithGrinder;
        public AutoKaffeMachine(IWaterControllerHeater waterControllerHeater, IAutoCoffeebeanControllerWithGrinder autoCoffeebeanControllerWithGrinder) 
        {
            _waterControllerHeater = waterControllerHeater;
            _autoCoffeebeanControllerWithGrinder = autoCoffeebeanControllerWithGrinder;
        }

        public string MakeCoffee(CoffeeProgram coffeeProgram)
        {
            // Cherck water level, then heat water
            _waterControllerHeater.WaterNeeded = _waterControllerHeater.WaterConsumptionForCoffeePrograms(coffeeProgram);
            var coffeeMakingStatus =  _waterControllerHeater.HeatWater(coffeeProgram);

            // Check beans, then grind beans
            _autoCoffeebeanControllerWithGrinder.ConsumeCoffeebean(coffeeProgram);

            coffeeMakingStatus += _autoCoffeebeanControllerWithGrinder.GrindBeans();

            coffeeMakingStatus += $"\nYour { coffeeProgram } is ready!\n";

            return coffeeMakingStatus;
        }
    }
}
