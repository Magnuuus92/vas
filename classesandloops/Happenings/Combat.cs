using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Characters;
using Skills;

namespace Happenings
{
    public class Combat
    {
        public void StartCombat(List<Player> players, List<Enemy> enemies)
        {
            Console.WriteLine("Combat begins");

            while (players.Any(p => p.IsAlive) && enemies.Any(e => e.IsAlive))
            {
                DisplayStatus(players, enemies);
                //PLAYER COMBAT TURN
                foreach (var player in players.Where(p => p.IsAlive))
                {

                    PlayerTurn.Execute(player, enemies);
                    if (!enemies.Any(e => e.IsAlive))
                        break;
                }

                foreach (var enemy in enemies.Where(e => e.IsAlive))
                {
                    HandleEnemyTurn(enemy, players);
                    if (!players.Any(e => e.IsAlive))
                        break;
                }
            }
            /*Console.WriteLine(players.Any(p => p.IsAlive)
            ? "Victory"
            : "Defeat");*/
            if (players.Any(p => p.IsAlive))
            {
                Console.WriteLine("Victory");
                int totalXP = enemies.Sum(e => e.ExperienceReward);
                foreach (var player in players.Where(p => p.IsAlive))
                {
                    player.GainExperience(totalXP / players.Count);
                }
            }
            else
            {
                Console.WriteLine("Defeat.");
            }
        }
        void DisplayStatus(List<Player> players, List<Enemy> enemies)
        {
            Console.WriteLine("\n--- Party ---");
            foreach (var p in players)
            {
                Console.WriteLine($"{p.Name}: {p.HP} HP : {p.Energy} Energy");
                Console.WriteLine($" {p.Name}:   ")// fortsett.
            }

            Console.WriteLine("\n--- Enemies ---");
            foreach (var e in enemies)
                Console.WriteLine($"{e.Name}: {e.HP} HP");
        }
        void HandleEnemyTurn(Enemy enemy, List<Player> players)
        {
            var target = players
            .Where(p => p.IsAlive)
            .OrderBy(_ => Guid.NewGuid())
            .First();

            int damage = enemy.PhysicalDamage();
            target.TakeDamage(damage);
            Console.WriteLine($"{enemy.Name} deals {damage} to {target.Name}");
        }



        //player choose enemy target
        Enemy ChooseEnemy(List<Enemy> enemies)
        {
            var alive = enemies.Where(e => e.IsAlive).ToList();

            for (int i = 0; i < alive.Count; i++)
                Console.WriteLine($"{i + 1}. {alive[i].Name} ({alive[i].HP} HP)");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice)
            || choice < 1
            || choice > alive.Count)
            {
                Console.WriteLine("Choose a valid target: ");

            }
            return alive[choice - 1];
        }
    }
}