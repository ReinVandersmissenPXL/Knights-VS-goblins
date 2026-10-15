using System.Text;
namespace Knights_VS_goblins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int knightHealth;
            int goblinHealth;
            int goblinAttack;
            bool isHealthOk;
            string healOrAttack;
            int knightAttack = 10;

            Random random = new Random();
            goblinHealth = random.Next(101);

            Console.Write("enter the healthpoints of your knight: ");
            isHealthOk = int.TryParse(Console.ReadLine(), out knightHealth);
            while (isHealthOk == false || knightHealth > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("please enter a valid number between 0 and 100!");
                Console.ResetColor();
                Console.Write("enter the healthpoints of your knight: ");
                isHealthOk = int.TryParse(Console.ReadLine(), out knightHealth);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"knight health: {knightHealth}");
            Console.WriteLine($"goblin health: {goblinHealth}");
            Console.ResetColor();

                do
                {
                    goblinAttack = random.Next(5, 17);

                    Console.WriteLine("Choose your next move careful: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Attack");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2. Heal");
                    Console.ResetColor();
                    Console.Write("enter your choice: ");
                    healOrAttack = Console.ReadLine();
                    switch (healOrAttack)
                    {
                        case "1":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You attack the goblin for 10 damage!");
                            Console.ResetColor();
                        goblinHealth = goblinHealth - knightAttack;

                        if (goblinHealth <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Victory! You have killed the goblin!");
                            Console.ResetColor();
                        }
                        else
                        {
                            knightHealth = knightHealth - goblinAttack;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"You were attacked by the goblin for {goblinAttack}");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"knight health: {knightHealth}");
                            Console.WriteLine($"goblin health: {goblinHealth}");
                            Console.ResetColor();
                        }
                            break;

                        case "2":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("You heal yourself for 10 health points!");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"You were attacked by the goblin for {goblinAttack}");
                            Console.ResetColor();
                            knightHealth = (knightHealth + 10) - goblinAttack;
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"knight health: {knightHealth}");
                            Console.WriteLine($"goblin health: {goblinHealth}");
                            Console.ResetColor();
                            break;

                        default:
                            knightHealth = knightHealth - 5;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("This is no valid input, You lose 5 healthpoints");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            
                            Console.WriteLine($"knight health: {knightHealth}");
                            Console.WriteLine($"goblin health: {goblinHealth}");
                            Console.ResetColor();
                        break;
                    }
                }
                while (knightHealth >= 0 && goblinHealth >= 0);

            if (goblinHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"knight health: {knightHealth}");
                Console.WriteLine($"goblin health: {goblinHealth}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Defeat! you were killed by the goblin!");
                Console.ResetColor();
            }

           
        }
    }
}
