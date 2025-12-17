using System.ComponentModel.DataAnnotations;

void Combat(List<Player> players, List<Enemy> enemies)
{
    Console.WriteLine("Combat begins");

    while (players.Any(p => p.IsAlive) && enemies.Any(e => e.IsAlive))
    {
        DisplayStatus(players, enemies);
        //PLAYER COMBAT TURN
        foreach (var player in players.Where(p => p.IsAlive))
        {
            PlayerTurn(player, enemies);
            if (!enemies.Any(e => e.IsAlive))
                break;
        }
        foreach (var enemy in enemies.Where(e => e.IsAlive))
        {
            EnemyTurn(enemy, players);
            if (!players.Any(e => e.IsAlive))
                break;
        }
    }
    Console.WriteLine(players.Any(p => p.IsAlive)
    ? "Victory"
    : "Defeat");
}