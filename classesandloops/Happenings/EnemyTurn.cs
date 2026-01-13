using Characters;
using Skills;

namespace Happenings
{
    public static class EnemyTurn
    {
        public static void Execute(Enemy enemy, Player player)
        {
            Console.WriteLine($"{enemy.Name}'s turn.");

            int damage = enemy.PhysicalDamage();
            player.TakeDamage(damage);

            Console.WriteLine($"{enemy.Name} Attacks {player.Name} and deals {damage}");
        }
    }
}

