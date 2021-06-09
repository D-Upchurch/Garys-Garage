using System;

namespace Garys_Garage
{
    public class Zero : Vehicle, IElectric  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeeoooooowwwwwwwwwww!");
        }
    }
}
