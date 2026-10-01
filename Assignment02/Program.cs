/*
 * Student ID : 1690704828
 * Name       : Rachta Chingthonkom
 * Section    : 129D
 * No.        : 30
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;

            Console.WriteLine("------------------------------");
            Console.WriteLine($"--     TOR'S IRON FORGE    --");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore->Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            //menu

            Console.WriteLine("=> Choose Menu:");
            bool menuOk = char.TryParse(Console.ReadLine(), out char menu);


            //amount

            Console.WriteLine("=> How much would you like: ");
            bool amountOk = double.TryParse(Console.ReadLine(), out double amount);

            {
                //chec input
                if (amountOk && amount > 0 && amount <= MaxBatch)
                {
                    if (menuOk && (menu == 'S' || menu == 's'))
                    {
                        double ingot = amount * SmeltRate;


                        Console.WriteLine($"=> {amount:F2} {MaterialName}   Ore = {ingot:F2} {MaterialName} Ingot");
                    }
                    else if (menuOk && (menu == 'B' || menu == 'b'))
                    {
                        double ore = amount / SalvageRate;



                        Console.WriteLine($"=> {amount:F2} {MaterialName}   Ingot = {ore:F2} {MaterialName} Ore");

                    }

                    else
                    {
                        Console.WriteLine("Invalid menu.");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid amount.");
                }
            }
        }
    }
}   







































