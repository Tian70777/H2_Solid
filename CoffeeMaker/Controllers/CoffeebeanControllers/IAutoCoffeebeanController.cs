using CoffeeMaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.CoffeebeanController
{
    public interface IAutoCoffeebeanController 
    {
        int RemainingCoffeeBean { get; set; }

        void RefillCoffeeBean();

    }
}
