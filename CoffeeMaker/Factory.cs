using CoffeeMaker.Controllers.CoffeebeanController;
using CoffeeMaker.Controllers.WaterControllerHeater;
using CoffeeMaker.Controllers.WaterControllers;
using CoffeeMaker.Models;
using CoffeeMaker.Models.WaterContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    static class Factory
    {
        // set default value for _maxWaterlevel and _minWaterlevel
        private static int _maxWaterlevel = 1000;
        private static int _minWaterlevel = 100;
        public static IWaterContainer CreateWaterContainer()
        {
            return new WaterContainer(_maxWaterlevel, _minWaterlevel);
        }

        public static IWaterControllerHeater CreateWaterControllerHeater()
        {
            return new WaterControllerHeater(CreateWaterContainer());
        }
        
        public static void ConfigureWaterContainer(int maxWaterLever, int minWaterLevel)
        {
            _maxWaterlevel = maxWaterLever;
            _minWaterlevel = minWaterLevel;
        }

    }
}
