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
        public AutoKaffeMachine(IWaterControllerHeater waterControllerHeater) 
        {
            _waterControllerHeater = waterControllerHeater;
        }

        public string MakeCoffee(CoffeeProgram coffeeProgram)
        {
            _waterControllerHeater.WaterNeeded = _waterControllerHeater.WaterConsumptionForCoffeePrograms(coffeeProgram);
            var waterStatus =  _waterControllerHeater.HeatWater(coffeeProgram);
            return waterStatus;
        }
    }
}
