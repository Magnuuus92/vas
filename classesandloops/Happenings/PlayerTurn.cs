
void PlayerTurn(Player player, List<Enemy> enemies) //displayer hp
{
    Console.WriteLine($"\n{player.Name}`s turn");
    Console.WriteLine("(A)ttack  (U)se item  (S)kip");

    var input = Console.ReadLine()?.ToLower();

    if (input == "a")
    {
        var target = ChooseEnemy(enemies);
        int damage = player.AttackDamage();
        target.TakeDamage(damage);
        Console.WriteLine($"{player.Name} deals {damage} to {target.Name}");

    }
    else if (input == "u")
    {
        UseItemMenu(player);
    }

}