using System;
using System.Collections.Generic;

namespace Garys_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                CurrentChargePercentage = 35
            };
            Zero fx = new Zero()
            {
                CurrentChargePercentage = 45
            };
            Tesla modelS = new Tesla()
            {
                CurrentChargePercentage = 33
            };

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"The current charge level is {ev.CurrentChargePercentage} percent");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
                Console.WriteLine("Charging the battery.");
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"The current charge level is {ev.CurrentChargePercentage} percent");
            }

            /***********************************************/

            Ram ram = new Ram()
            {
                CurrentTankPercentage = 67
            };

            Cessna cessna150 = new Cessna()
            {
                CurrentTankPercentage = 15
            };

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
                };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"The current tank level is {gv.CurrentTankPercentage} percent");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
                Console.WriteLine("Refilling the tank.");
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"The current tank level is {gv.CurrentTankPercentage} percent");
            }
        }
    }
}
