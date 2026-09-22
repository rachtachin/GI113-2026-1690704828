/*
* Student ID : 1690704828
* Name       : Rachta Chingthonkom
* Section    : 129D
* No.        :30
* Course     : GI113 Computer Programming (GI)
*/
namespace Lad_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game name The Demon Hunter VS Chicken
            int playerhp = 100;
            int enemyhp = 100;
            int knife = 10;
            int pistol = 20;
            int chicken = 100;
            int chickenfireHP = 50;


            Console.WriteLine("GAME TITLE :Welcome to The Demon Hunter VS Chicken!");
            Console.WriteLine("ACTION 1: Attack A Demon with a Knife");
            Console.WriteLine("ACTION 2: Attack A Demon with a Pistol");
            Console.WriteLine("ACTION 3: Attack A Chicken with a Chicken");
            Console.WriteLine("ACTION 4: Eat a Chickenfire to regain health");

            Console.WriteLine("Choose your action (1-4):");
            bool inputValid = int.TryParse(Console.ReadLine(), out int action);

            if (!inputValid || action < 1 || action > 4)
            {
                Console.WriteLine("Invalid input, please action between 1-4 only!");
            }
            else if (action == 1)
            {
                enemyhp -= knife;
                Console.WriteLine($"You attacked the Demon with a Knife! Enemy HP: {enemyhp}");
            }
            else if (action == 2)
            {
                enemyhp -= pistol;
                Console.WriteLine($"You attacked the Demon with a Pistol! Enemy HP: {enemyhp}");
            }
            else if (action == 3)
            {
                chicken -= 10;
                Console.WriteLine($"You attacked the Chicken! Chicken HP: {chicken}");
            }
            else if (action == 4)
            {
                playerhp += chickenfireHP;
                Console.WriteLine($"You ate a Chickenfire to regain health! Player HP: {playerhp}");






            }
        }
    }

}
