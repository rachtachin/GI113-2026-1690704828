/*
* Student ID : 1690704828
* Name       : Rachta Chingthonkom
* Section    : 129D
* No.        :30
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game name The Demon Hunter VS Chicken KFC
            int playerHp = 100;
            int enemyHp = 100;
            int knifeDamage = 25;
            int pistolDamage = 40;
            int chickenDamage = 15;
            int friedChickenHeal = 30;


            Console.WriteLine("====================================");
            Console.WriteLine("       DEMON HUNTER VS CHICKEN KFC");
            Console.WriteLine("====================================");
            Console.WriteLine($"Player HP : {playerHp}");
            Console.WriteLine($"Demon HP  : {enemyHp}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("ACTION 1 : Attack Demon with Knife");
            Console.WriteLine("ACTION 2 : Attack Demon with Pistol");
            Console.WriteLine("ACTION 3 : Attack Chicken");
            Console.WriteLine("ACTION 4 : Eat Fried  Chicken and Heal");
            Console.WriteLine("------------------------------------");
            Console.Write("Choose your action (1-4): ");

            bool inputValid = int.TryParse(Console.ReadLine(), out int action);

            Console.WriteLine();

            if (!inputValid || action < 1 || action > 4)
            {
                Console.WriteLine("Invalid action. Please choose 1-4.");
            }
            else if (action == 1)
            {
                enemyHp -= knifeDamage;

                Console.WriteLine("You attack the Demon with a Knife!");
                Console.WriteLine($"Demon HP : {enemyHp}");
            }
            else if (action == 2)
            {
                enemyHp -= pistolDamage;

                Console.WriteLine("You shoot the Demon with a Pistol!");
                Console.WriteLine($"Demon HP : {enemyHp}");
            }
            else if (action == 3)
            {
                playerHp -= chickenDamage;

                Console.WriteLine("You attack the Chicken!");
                Console.WriteLine("The Chicken fights back!");
                Console.WriteLine($"Player HP : {playerHp}");
            }
            else
            {
                playerHp += friedChickenHeal;

                Console.WriteLine("You eat Fried Chicken and recover health!");
                Console.WriteLine($"Player HP : {playerHp}");
            }

            Console.WriteLine("====================================");
            Console.WriteLine("             TURN END");
            Console.WriteLine("====================================");


        
        }
    }

}
