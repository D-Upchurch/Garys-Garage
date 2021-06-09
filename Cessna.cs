using System;

namespace Garys_Garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zoooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}