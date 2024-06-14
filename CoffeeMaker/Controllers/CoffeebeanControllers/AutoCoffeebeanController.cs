using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.CoffeebeanController
{
    public class AutoCoffeebeanController : IAutoCoffeebeanController
    {
        public int RemainingCoffeeBean { get; set; } = 0;
        public int CoffeeBeanCapacity { get; set; }
        public int CoffeebeanInGram { get; set; }


        public void RefillCoffeeBean()
        {
            RemainingCoffeeBean = 100;
        }


    }
}
