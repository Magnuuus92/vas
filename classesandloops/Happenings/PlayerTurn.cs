using System.Reflection.Metadata;
using Characters;
using Items;

namespace Happenings
{
    public static class PlayerTurn
    {
        public static void Execute(Player player, List<Enemy> enemies)
        {

            Console.WriteLine("Your turn!");
            Console.WriteLine("1.Attack");
            Console.WriteLine("2.Use item");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Attack(player, enemies);
                    break;

                case "2":
                    UseItem(player);
                    break;

                default:
                    Console.WriteLine("Invalid choice. You lose your turn.");
                    break;

            }
        }
        private static void Attack(Player player, Enemy enemy)
        {
            int damage = player.PhysicalDamage();
            enemy.TakeDamage(damage);

            Console.WriteLine($"{player.Name} attacks {enemy.Name} and deals {damage} damage!");
        }
        private static void UseItem(Player player)
        {
            if (player.Inventory.Count == 0)
            {
                Console.WriteLine("You have no items to use.");
                return;
            }


            Console.WriteLine("Choose an item to use:");
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {player.Inventory[i].Name}");
            }
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) ||
            choice < 1 || choice > player.Inventory.Count)
            {
                Console.WriteLine("Invalid item choice");
            }
            Item item = player.Inventory[choice - 1];
            item.Use(player);
            player.Inventory.Remove(item);
        }

    }
}

