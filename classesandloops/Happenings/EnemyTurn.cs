

void EnemyTurn(Enemy enemy, List<Player> players)
{
    var target = players
    .Where(p => p.IsAlive)
    .OrderBy(_ => Guid.NewGuid())
    .First();

    target.TakeDamage(enemy.Damage);
    Console.WriteLine($"{enemy.Name} deals {enemy.Damage} to {target.Name}");
}