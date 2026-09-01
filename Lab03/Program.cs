using System.Runtime.Intrinsics.Arm;
using System.Xml;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Boss Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCritical Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");


            // Implicit Conversion: currentHp (int) --> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // (double) currentHpdouble = (int)currentHp
            Console.WriteLine($"HP (double): {currentHpDouble}");


            // Calculate Percent -->> double
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation)-----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");


            // Explicit Conversion Cast attackPower (float) --> int
            Console.WriteLine("\n----- Explicit Conversion: Attack Power as int -----");
            Console.WriteLine($"Attack Power (float): {attackPower}");
            int attackPowerInt = (int)attackPower; // Explicit Conversion Cast
            Console.WriteLine($"Attack Power (int): {attackPowerInt}");



            //Cast vs. Convert critMultiplier (double) --> int
            Console.WriteLine("\n----- Cast vs. Convert: Critical Multiplier as int -----");
            Console.WriteLine($"Critical Multiplier (double): {critMultiplier}");
            int critMultiplierInt = (int)critMultiplier;
            Console.WriteLine($"Critical Multiplier (int - Cast): {critMultiplierInt}");
            int critMultiplierIntConverted = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int - Convert): {critMultiplierIntConverted}");


        }
    }
    }
}
