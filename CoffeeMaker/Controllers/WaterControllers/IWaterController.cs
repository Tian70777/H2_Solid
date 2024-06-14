using CoffeeMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.WaterControllers
{
    public interface IWaterController 
    {
        string AddWater();
        int WaterConsumptionForCoffeePrograms(CoffeeProgram coffeeProgram);
    }
}
