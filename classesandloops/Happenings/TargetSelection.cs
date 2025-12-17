
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