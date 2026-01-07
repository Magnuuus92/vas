using Characters;

namespace Happenings
{
    public static class TargetSelection
    {
        public static Enemy SelectEnemy(List<Enemy> enemies)
        {
            if (enemies.Count == 1)
                return enemies[0];

            Console.WriteLine("Choose a target.");
            for (int i = 0; i < enemies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {enemies[i].Name} ({enemies[i].HP} HP)");
            }
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) ||
            choice < 1 || choice > enemies.Count)
            {
                Console.WriteLine("Invalid choice");
            }
            return enemies[choice - 1];


        }
    }
}

