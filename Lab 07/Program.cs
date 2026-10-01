using System.Diagnostics;

namespace Lab_07
/*
* Student ID : 1690704828
* Name       : Rachta Chingthonkom
* Section    : 129D
* No.        : 30
* Course     : GI113 Computer Programming (GI)
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHp = 10;

            Console.WriteLine("MonsterHp Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP{MonsterHp}, DEF {monsterDefense}");
            Console.WriteLine();

            Console.WriteLine("=== Battle Command ===");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Skill");
            Console.WriteLine("3. Defend");
            Console.WriteLine("4. Run");
            Console.WriteLine("5. Use Health Potion");
            Console.WriteLine("Choose command; ");

            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("You attack the Slime!");
                    break;
                case 2:
                    Console.WriteLine("You use a powerful skill!");
                    break;
                case 3:
                    Console.WriteLine("You defend against the Slime!");
                    break;
                case 4:
                    Console.WriteLine("You run away from the battle!");
                    break;
                case 5:
                    Console.WriteLine("You use a Health Potion!");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }

            
        }

    }

}
