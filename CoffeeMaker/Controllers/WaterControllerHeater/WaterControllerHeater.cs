using CoffeeMaker.Models.WaterContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Controllers.WaterControllerHeater
{
    public class WaterControllerHeater : IWaterControllerHeater
    {
        // Field to hold the IWaterContainer instance
        private IWaterContainer _waterContainer;
        private Thread _waterMonitorThread;

        private CoffeeProgram _currentCoffeeProgram;

        private readonly object _waterLock = new object();

        public bool IsHeaterOn { get; set; } = false;
        public bool IsHeaterOff { get; set; } = true;
        public int WaterNeeded { get; set; } = 0;
        public bool EnoughtWater { get; set; } = false;

        /// <summary>
        /// Create and start the thread to monitor the water level in the water container
        /// </summary>
        /// <param name="waterContainer"></param>
        public WaterControllerHeater(IWaterContainer waterContainer)
        {
            _waterContainer = waterContainer;
            _waterMonitorThread = new Thread(WaterMonitor) { IsBackground = true };
            _waterMonitorThread.Start();
        }
        /// <summary>
        /// A seperate thread, keeps monitoring the water level in the water container
        /// Add water when EnoughtWater is false
        /// </summary>
        /// <returns></returns>
        public void WaterMonitor()
        {
            // Keep monitoring the water level in the water container   
            while (true)
            {
                // checkevery 2 seconds
                CheckAndAddWaterIfNeeded();
                Thread.Sleep(2000);
            }
        }

        private void CheckAndAddWaterIfNeeded()
        {
            WaterNeeded = WaterConsumptionForCoffeePrograms(_currentCoffeeProgram);

            if (_waterContainer.CurrentWaterlevel <= _waterContainer.MinWaterlevel || _waterContainer.CurrentWaterlevel < WaterNeeded)
            {
                EnoughtWater = false;
                AddWater();
            }
        }
        public string AddWater()
        {
            lock (_waterLock)
            {
                _waterContainer.IsWaterValveOpen = true;
                // Set current water lever to full, close water valve and return message
                _waterContainer.CurrentWaterlevel = _waterContainer.MaxWaterlevel;

                // Simulates the time taken to fill the water container
                Console.WriteLine("Adding water to the container...\n");
                Thread.Sleep(3000);

                _waterContainer.IsWaterValveOpen = false;
                
                EnoughtWater = true;

                return $"Water container is full! Current water level: {_waterContainer.CurrentWaterlevel}\n";
            }
        }

        // Logic to heat water and cosumewater based on the coffee program
        public string HeatWater(CoffeeProgram coffeeProgram)
        {
            //WaterNeeded = WaterConsumptionForCoffeePrograms(_currentCoffeeProgram);
            lock (_waterLock)
            {
                // check if there is enough water in the container
                // if is false, return message to avoid thread blocking by _waterLock
                // can heatwater when AddWater() is called and finished
                if(EnoughtWater == false)
                {
                    return "Not enough water in the container";
                }


                _waterContainer.CurrentWaterlevel -= WaterNeeded;

                // Simulates the time taken to heat the water
                Console.WriteLine("Heating water...\n");
                Thread.Sleep(1000);
                return $"Water for {coffeeProgram} is heated! Remaining water level: {_waterContainer.CurrentWaterlevel}\n";
            }   
        }

        public int WaterConsumptionForCoffeePrograms(CoffeeProgram coffeeProgram)
        {
            // Logic for consuming water based on the coffee program
            switch (coffeeProgram)
            {
                case CoffeeProgram.Espresso:
                    return 50;
                case CoffeeProgram.DoubleEspresso:
                    return 100;
                case CoffeeProgram.Americano:
                    return 150;
                case CoffeeProgram.Cappuccino:
                    return 200;
                case CoffeeProgram.HotWater:
                    return 250;
                //case CoffeeProgram.Cleaning:
                //    return 200;
                default:
                    return 0;
            }
        }
    }
}
