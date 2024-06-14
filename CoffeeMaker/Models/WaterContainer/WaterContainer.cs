using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Models.WaterContainer
{
    public class WaterContainer : IWaterContainer
    {
        public int MaxWaterlevel { get; set; }
        public int MinWaterlevel { get; set; }
        public int CurrentWaterlevel { get; set; } = 0;
        public bool IsWaterValveOpen { get; set; } = false;

        public WaterContainer(int maxWaterlevel, int minWaterlevel)
        {
            MaxWaterlevel = maxWaterlevel;
            MinWaterlevel = minWaterlevel;
        }


    }
}
