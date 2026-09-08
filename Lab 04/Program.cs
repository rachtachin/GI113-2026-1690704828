/*
* Student ID : 1690704828
* Name       : Rachta Chingthonkom
* Section    : 129D
* No.        :
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|        NEW ADVENTURE         |");
            Console.WriteLine("+------------------------------+");

            Console.WriteLine("Name your hero: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {playerName}.  Your journey begins now!");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|        DIFFICULTY SELECT      |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("choose difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\"Difficulty {difficulty} selected. Good luck out there...");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|        ITEM SHOP              |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("How many potions?");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|        CHARACTER CREATION     |");
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("Name your character: ");
            string characterName = Console.ReadLine();
            Console.WriteLine("Choose your class (1-3): ");
            bool classok = int.TryParse(Console.ReadLine(), out int classNum);
            Console.WriteLine("Starting luck (0.0-10.0): ");
            bool luckok = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{characterName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

        }
    }
}
