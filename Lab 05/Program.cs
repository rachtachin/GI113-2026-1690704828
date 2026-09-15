namespace Lab_05
/*
* Student ID : 1690704828
* Name       : Rachta Chingthonkom
* Section    : 129D
* No.        :30
* Course     : GI113 Computer Programming (GI)
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title sub-title
            Console.WriteLine("Welcome to the Battle Arena!");
            Console.WriteLine("Prepare for an epic showdown between heroes and monsters!");


            // Hero stats input
            Console.Write("Hero Health: ");
            bool HeroHpok = int.TryParse(Console.ReadLine(), out int HeroHp);
            Console.Write("Hero Attack: ");
            bool HeroAtkok = int.TryParse(Console.ReadLine(), out int HeroAtk);
            Console.Write("Hero Defense: ");
            bool HeroDefok = int.TryParse(Console.ReadLine(), out int HeroDef);
                
            // Monster stats input
            Console.Write("Monster Health: ");
            bool MonsterHpok = int.TryParse(Console.ReadLine(), out int MonHp);
            Console.Write("Monster Attack: ");
            bool MonsterAtkok = int.TryParse(Console.ReadLine(), out int MonAtk);
            Console.Write("Monster Defense: ");
            bool MonsterDefok = int.TryParse(Console.ReadLine(), out int MonDef);

            // Input validation
            bool herosStatsValid = HeroHpok && HeroAtkok && HeroDefok;
            bool monstersStatsValid = MonsterHpok && MonsterAtkok && MonsterDefok;
            Console.Write($"\nHero stat: {herosStatsValid}" );
            Console.Write($"Monster stat: {monstersStatsValid}" );

            Console.Write($"[HERO]      HP: {HeroHp}    ATK:{HeroAtk}    DEF:{HeroDef}" );
            Console.Write($"[MONSTER]   HP: {MonHp}    ATK:{MonAtk}    DEF:{MonDef}" );
            // Compound Assign - Arithmetic (+)
            int potionHeal = 5;

            HeroHp += potionHeal;
            //herohp = herohp + potionheal;
            Console.WriteLine($"\nHero drink a potion and healed {potionHeal} HP! New HP: {HeroHp}");
            //normal attack RPGStyle combat ATK > DEF 
            int normalDMG = Math.Max(0, herosStatsValid ? HeroAtk - MonDef : 0);
            Console.WriteLine($"Hero deals {normalDMG} damage with a normal attack!");

            //power attack
            int powerDMG = Math.Max(0, herosStatsValid ? HeroAtk * 2 - MonDef : 0);
            Console.WriteLine($"Hero deals {powerDMG} damage with a power attack!");
            //Random Critical Attack
            Random rng = new Random();
            int critRoll = rng.Next (1, 101); 
            bool isCrit = critRoll <= 25; // 25% chance for critical hit

            int critDamage = normalDMG + Convert.ToInt32(isCrit) * normalDMG; // Critical hit deals 50% more damage
            Console.WriteLine($"critRoll {critRoll}. Critial Hit: {isCrit}");
            Console.WriteLine($"Hero deals {critDamage} damage with a critical attack!");
            

        }
    }
}
