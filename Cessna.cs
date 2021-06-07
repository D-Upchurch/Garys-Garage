using System;

namespace Garys_Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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