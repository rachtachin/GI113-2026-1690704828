/*
* Student ID : 1690704828
* Name       : Rachta Chingthonkom
* Section    : 129D
* No.        :30
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Wuthering Waves";

            var resonatorName = "Rover";
            var resonatorRank = 'S';

            int resonatorLevel = 80;
            float criticalRate = 68.5f;
            double resonanceEnergy = 150.75;
            bool isPlayable = true;


            Console.WriteLine("==================================");
            Console.WriteLine($"        {GameTitle}");
            Console.WriteLine("        RESONATOR PROFILE");
            Console.WriteLine("==================================");
            Console.WriteLine($" Resonator : {resonatorName}");
            Console.WriteLine($" Rank      : {resonatorRank}");
            Console.WriteLine($" Level     : {resonatorLevel}");
            Console.WriteLine("------------- COMBAT -------------");
            Console.WriteLine($" Crit Rate : {criticalRate}");
            Console.WriteLine($" Energy    : {resonanceEnergy}");
            Console.WriteLine($" Playable  : {isPlayable}");
            Console.WriteLine("==================================");
            Console.WriteLine();

            // Implicit Conversion
            double levelAsDouble = resonatorLevel;

            Console.WriteLine("----- DATA CONVERSION -----");
            Console.WriteLine($"Level as double : {levelAsDouble}");
            Console.WriteLine();


            // Explicit Cast vs Convert
            int energyCast = (int)resonanceEnergy;
            int energyConvert = Convert.ToInt32(resonanceEnergy);

            Console.WriteLine("----- ENERGY DISPLAY -----");
            Console.WriteLine($"Original Energy : {resonanceEnergy}");
            Console.WriteLine($"Cast to int     : {energyCast}");
            Console.WriteLine($"Convert to int  : {energyConvert}");

          

        }
    }
}
