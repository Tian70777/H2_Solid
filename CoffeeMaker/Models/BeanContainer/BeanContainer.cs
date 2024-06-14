using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Models.BeanContainer
{
    public class BeanContainer
    {
        public int Capacity { get; set; }
        public int CurrentBean { get; set; } = 0;
        //public bool IsWaterValveOpen { get; set; } = false;

        public BeanContainer(int capacity)
        {
            Capacity = capacity;
        }
    }
}
