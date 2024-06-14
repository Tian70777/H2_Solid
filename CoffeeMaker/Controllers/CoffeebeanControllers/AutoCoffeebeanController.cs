using CoffeeMaker.Models.BeanContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.CoffeebeanController
{
    public class AutoCoffeebeanController
    {
        private IBeanContainer _beanContainer;
        private CoffeeProgram _currentCoffeeProgram;

        public AutoCoffeebeanController(IBeanContainer beanContainer)
        {
            _beanContainer = beanContainer;
        }
        public string RefillBeanReminder()
        {
            if (_beanContainer.CurrentBean < (int)_currentCoffeeProgram)
                return $"Not enough beans. Please refill the bean container.";

            else return null;
        }


    }
}
