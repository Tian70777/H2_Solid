namespace CoffeeMaker.Models.WaterContainer
{
    public interface IWaterContainer
    {
        int CurrentWaterlevel { get; set; }
        bool IsWaterValveOpen { get; set; }
        int MaxWaterlevel { get; set; }
        int MinWaterlevel { get; set; }
    }
}