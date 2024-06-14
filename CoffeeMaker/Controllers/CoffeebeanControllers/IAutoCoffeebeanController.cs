namespace CoffeeMaker.Controllers.CoffeebeanController
{
    public interface IAutoCoffeebeanController
    {
        string RefillBeanReminder();
        string RefillBean();

        void ConsumeCoffeebean(CoffeeProgram coffeeProgram);
        
    }
}