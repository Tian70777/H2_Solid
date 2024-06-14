using CoffeeMaker.Controllers.WaterControllers;
using CoffeeMaker.Models.Heater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.WaterControllerHeater
{
    public interface IWaterControllerHeater : IWaterController, IHeater
    {
    }
}
