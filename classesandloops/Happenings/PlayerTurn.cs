using System.Reflection.Metadata;
using Characters;
using Items;
using Happenings;
using Microsoft.Diagnostics.Tracing.Parsers;

namespace Happenings
{
    public static class PlayerTurn
    {
        public static void Execute(Player player, List<Enemy> enemies)
        {

            Console.WriteLine("Your turn!");
            Console.WriteLine("1.Attack");
            Console.WriteLine("2.Use item");
            Console.WriteLine("3.Use skill");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Attack(player, enemies);
                    break;

                case "2":
                    UseItem(player);
                    break;
                case "3":
                    UseSkill(player, enemies);
                    break;
                default:
                    Console.WriteLine("Invalid choice. You lose your turn.");
                    break;

            }
        }
        private static void Attack(Player player, List<Enemy> enemies)
        {
            Enemy target = TargetSelection.SelectEnemy(enemies);

            int damage = player.PhysicalDamage();
            target.TakeDamage(damage);

            Console.WriteLine($"{player.Name} attacks {target.Name} and deals {damage} damage!");
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
        private static void UseSkill(Player player, List<Enemy> enemies)
        {
            if (player.Skills.Count == 0)
            {
                Console.WriteLine("you have no skills.");
                return;
            }
            Console.WriteLine("Choose a Skill to use.");
            for (int i = 0; i < player.Skills.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {player.Skills[i].Name}");
            }
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) ||
            choice < 1 || choice > player.Skills.Count)
            {
                Console.WriteLine("Invalid choice");
            }

            var skill = player.Skills[choice - 1];
            var target = TargetSelection.SelectEnemy(enemies);

            skill.Use(player, target);

        }

    }
}

