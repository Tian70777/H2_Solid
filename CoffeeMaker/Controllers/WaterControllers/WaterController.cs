using CoffeeMaker.Models.WaterContainer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.WaterControllers
{
    public class WaterController 
    {
        // Field to hold the IWaterContainer instance
        private IWaterContainer _waterContainer;


        public WaterController(IWaterContainer waterContainer)
        {
            _waterContainer = waterContainer;
        }

        public async Task<string> AddWaterAsync(int waterNeeded)
        {
            
            if (_waterContainer.CurrentWaterlevel <= _waterContainer.MinWaterlevel || _waterContainer.CurrentWaterlevel < waterNeeded)
            {
                _waterContainer.IsWaterValveOpen = true;

                // Simulates the time taken to fill the water container
                Console.WriteLine("Adding water to the container...\n");
                await Task.Delay(3000);

                // Set current water lever to full, close water valve and return message
                _waterContainer.CurrentWaterlevel = _waterContainer.MaxWaterlevel;
                _waterContainer.IsWaterValveOpen = false;

                return $"Water container is full! Current water level: {_waterContainer.CurrentWaterlevel}\n";
            }

            // Return a message indicating no action was needed/ taken
            return $"Water level is sufficient. Current water level: {_waterContainer.CurrentWaterlevel}\n";
        }

        //// Logic to heat water and cosumewater based on the coffee program
        //public async Task<string> HeatWaterAsync(CoffeeProgram coffeeProgram)
        //{
        //    int waterNeeded = WaterConsumptionForCoffeePrograms(coffeeProgram);

        //    if (_waterContainer.CurrentWaterlevel < _waterContainer.MinWaterlevel || _waterContainer.CurrentWaterlevel < waterNeeded)
        //    {
        //        string waterAdded = await AddWaterAsync(waterNeeded);

        //        _waterContainer.CurrentWaterlevel = _waterContainer.MaxWaterlevel - waterNeeded;

        //        return waterAdded + $"\nWater for {coffeeProgram} is heated! Remaining water level: {_waterContainer.CurrentWaterlevel}\n";

        //    }
        //    else
        //    {
        //        _waterContainer.CurrentWaterlevel -= waterNeeded;
        //        return $"Water for {coffeeProgram} is heated! Remaining water level: {_waterContainer.CurrentWaterlevel}\n";

        //    }
        //}

        public int WaterConsumptionForCoffeePrograms(CoffeeProgram coffeeProgram)
        {
            // Logic for consuming water based on the coffee program
            switch (coffeeProgram)
            {
                case CoffeeProgram.Espresso:
                    return 50;
                    break;
                case CoffeeProgram.DoubleEspresso:
                    return 100;
                    break;
                case CoffeeProgram.Americano:
                    return 150;
                    break;
                case CoffeeProgram.Cappuccino:
                    return 200;
                    break;
                case CoffeeProgram.HotWater:
                    return 250;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
