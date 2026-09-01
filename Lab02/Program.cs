/*
 * Student ID :1690704828
 * Name       :Lab02
 * Section    :129D
 * No.        :0
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
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMGE =====");
            Console.WriteLine($"Hp:{currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP percent: {hpPercent}%");
            // Lab02 Part B
            // unit 1 - Speed Type
            string playerName = "Ashe";
            int playerLevel = 6;
            int playerMaxHp = 180;
            int playerCurrentHp = 120;
            float playerSpeed = 12.5f;
            double playerDefense = 25.75;

            Console.WriteLine("===== PLAYER 1: ASHE =====");
            Console.WriteLine($"Name: {playerName}");
            Console.WriteLine($"Level: {playerLevel}");
            Console.WriteLine($"HP: {playerCurrentHp} / {playerMaxHp}");
            Console.WriteLine($"Speed: {playerSpeed}");
            Console.WriteLine($"Defense: {playerDefense}");
            // unit 2 - Critical Type
            string playerName2 = "Yaimak";
            char playerRank2 = 'S';
            int playerLevel2 = 999;
            float playerAttackPower2 = 99.9f;
            double playerCritMultiplier2 = 3.55;

            Console.WriteLine("===== PLAYER 2: YAIMAK =====");
            Console.WriteLine($"Name: {playerName2}");
            Console.WriteLine($"Rank: {playerRank2}");
            Console.WriteLine($"Level: {playerLevel2}");
            Console.WriteLine($"Attack Power: {playerAttackPower2}");
            Console.WriteLine($"Crit Multiplier: {playerCritMultiplier2}");
            // unit 3 - Tank Type
            string playerName3 = "Rawhand";
            int playerLevel3 = 7;
            int playerMaxHp3 = 300;
            float playerSpeed3 = 6.5f;
            double playerDefense3 = 80.5;

            Console.WriteLine("===== PLAYER 3: RAWHAND =====");
            Console.WriteLine($"Name: {playerName3}");
            Console.WriteLine($"Level: {playerLevel3}");
            Console.WriteLine($"HP: {playerMaxHp3}");
            Console.WriteLine($"Speed: {playerSpeed3}");
            Console.WriteLine($"Defense: {playerDefense3}");
            // unit 4 - Boss Type
            string playerName4 = "Zedzeed";
            char playerRank4 = 'S';
            int playerBossPower4 = 500;
            float playerAttackSpeed4 = 15.5f;
            bool playerIsBoss4 = true;

            Console.WriteLine("===== PLAYER 4: ZEDZEED =====");
            Console.WriteLine($"Name: {playerName4}");
            Console.WriteLine($"Rank: {playerRank4}");
            Console.WriteLine($"Boss Power: {playerBossPower4}");
            Console.WriteLine($"Attack Speed: {playerAttackSpeed4}");
            Console.WriteLine($"Is Boss: {playerIsBoss4}");
        }
    }
}
