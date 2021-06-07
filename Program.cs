using System;

namespace Garys_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Black"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Blue"
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Red"
            };
            Ram challenger = new Ram()
            {
                MainColor = "Yellow"
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();

            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();

            Console.WriteLine();

            challenger.Drive();
            challenger.Turn("right");
            challenger.Stop();


        }
    }
}
