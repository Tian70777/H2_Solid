
namespace CoffeeMaker.Models.Heater
{
    public interface IHeater
    {
        bool IsHeaterOff { get; set; }
        bool IsHeaterOn { get; set; }
        int WaterNeeded { get; set; }

        string HeatWater(CoffeeProgram coffeeProgram);

        
    }
}