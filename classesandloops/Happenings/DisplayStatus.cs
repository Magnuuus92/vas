using Characters;

namespace Happenings
{
    public static class DisplayStatus
    {
        public static void Show(Player player, Enemy enemy)
        {
            Console.Clear();

            Console.WriteLine("===PLAYER===");
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"HP {player.HP}/{player.MaxHp}.");
            Console.WriteLine();

            Console.WriteLine("===ENEMY===");
            Console.WriteLine($"Name {enemy.Name}");
            Console.WriteLine($"HP {enemy.HP}.");
            Console.WriteLine();

        }
    }
}

