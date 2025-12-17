void DisplayStatus(List<Player> players, List<Enemy> enemies)
{
    Console.WriteLine("\n--- Party ---");
    foreach (var p in players)
        Console.WriteLine($"{p.Name}: {p.HP} HP");

    Console.WriteLine("\n--- Enemies ---");
    foreach (var e in enemies)
        Console.WriteLine($"{e.Name}: {e.HP} HP");
}