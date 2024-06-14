using CoffeeMaker.Models.BeanContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.CoffeebeanController
{
    public class AutoCoffeebeanControllerWithGrinder : IAutoCoffeebeanControllerWithGrinder
    {
        private IBeanContainer _beanContainer;
        private CoffeeProgram _currentCoffeeProgram;


        public AutoCoffeebeanControllerWithGrinder(IBeanContainer beanContainer)
        {
            _beanContainer = beanContainer;
        }
        public string GrindBeans()
        {
            

            Console.WriteLine("Grind your coffee beans...\n");
            Thread.Sleep(1500);

            return $"\n{ (int)_currentCoffeeProgram } grams beans are ground. { _beanContainer.CurrentBean } grams beans in the Bean Container.\n";
        }
        public void ConsumeCoffeebean(CoffeeProgram coffeeProgram)
        {
            _currentCoffeeProgram = coffeeProgram;

            // Get amount of coffeebean needed
            int beanNeeded = (int)_currentCoffeeProgram;

            // check if current coffeebean is enough
            // if not enough, show reminder to refill the bean container
            // then call method to refill the bean container
            if(_beanContainer.CurrentBean < beanNeeded)
            {
                Console.WriteLine(RefillBeanReminder()); 

                Console.WriteLine(RefillBean()); 
            }

            _beanContainer.CurrentBean -= beanNeeded;

        }

        public string RefillBean()
        {
            _beanContainer.CurrentBean = _beanContainer.Capacity;
            _beanContainer.IsContainerRefilled = true;
            return $"Bean container is refilled.\n";
        }
        public string RefillBeanReminder()
        {
            _beanContainer.IsContainerRefilled = false;
            return $"Not enough beans. Please refill the bean container.\n";
        }




    }
}
