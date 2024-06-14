namespace CoffeeMaker.Models.BeanContainer
{
    public interface IBeanContainer
    {
        int Capacity { get; set; }
        int CurrentBean { get; set; }
        bool IsContainerRefilled { get; set; }
    }
}