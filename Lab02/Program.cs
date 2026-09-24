/*
 * Student ID :1690704828
 * Name       :Lab02
 * Section    :129D
 * No.        :30
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // LAb02 pA
            Console.WriteLine("===== BOSS STATUS: INITIAL ===== ");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"level: {level}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMGE =====");
            Console.WriteLine($"Hp:{currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP percent: {hpPercent}%");
            // Lab02 Part B Abyss Hunter

            // Charcter 1 /tor
            string HunterName1 = "Tor";
            int hunterlevel1 = 25;
            float hunterAttackPower1 = 35.5f;
            char hunterRank1 = 'A'; 
            bool hunterAlive1 = true;

            Console.WriteLine("===== hunter 1: TOR =====");
            Console.WriteLine($"Name : {HunterName1}");
            Console.WriteLine($"Level: {hunterlevel1}");
            Console.WriteLine($"Attack Power: {hunterAttackPower1}");
            Console.WriteLine($"Rank: {hunterRank1}");
            Console.WriteLine($"Alive: {hunterAlive1}");


            // Charcter 2 - Mira
            string HunterName2 = "Mira";
            int hunterlevel2 = 23;
            float hunterAttackPower2 = 32.0f;
            char hunterRank2 = 'B';
            bool hunterAlive2 = true;

            Console.WriteLine("===== hunter 2: MIRA =====");
            Console.WriteLine($"Name : {HunterName2}");
            Console.WriteLine($"Level: {hunterlevel2}");
            Console.WriteLine($"Attack Power: {hunterAttackPower2}");
            Console.WriteLine($"Rank: {hunterRank2}");
            Console.WriteLine($"Alive: {hunterAlive2}");


            // Charcter 3 - Brakk
            string HunterName3 = "Brakk";
            int hunterlevel3 = 28;
            float hunterAttackPower3 = 38.0f;
            char hunterRank3 = 'S';
            bool hunterAlive3 = true;

            Console.WriteLine("===== hunter 3: BRAKK =====");
            Console.WriteLine($"Name : {HunterName3}");
            Console.WriteLine($"Level: {hunterlevel3}");
            Console.WriteLine($"Attack Power: {hunterAttackPower3}");
            Console.WriteLine($"Rank: {hunterRank3}");
            Console.WriteLine($"Alive: {hunterAlive3}");
            


            // Charcter 4 - Mear
            string HunterName4 = "Mear";
            int hunterlevel4 = 27;
            float hunterAttackPower4 = 36.0f;
            char hunterRank4 = 'A';
            bool hunterAlive4 = true;

            Console.WriteLine("===== hunter 4: MEAR =====");
            Console.WriteLine($"Name : {HunterName4}");
            Console.WriteLine($"Level: {hunterlevel4}");
            Console.WriteLine($"Attack Power: {hunterAttackPower4}");
            Console.WriteLine($"Rank: {hunterRank4}");
            Console.WriteLine($"Alive: {hunterAlive4}");




        }
    }
}
