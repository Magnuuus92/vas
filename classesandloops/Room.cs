using Characters;
using Happenings;
//all rooms basic behaviour
public abstract class Room
{
    public string Name { get; } //hva rommet kalles
    public string Description { get; } // texten som skal komme når du er i rommet
    public Dictionary<string, Room> Exits { get; } = new(); // movement between rooms
    public CombatEncounter? Encounter { get; set; }
    protected Room(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public void Connect(string direction, Room room)
    {
        Exits[direction.ToLower()] = room;
    }
    public virtual void OnEnter(Player player)
    {
        Console.WriteLine($"\nYou enter the {Name}.");
        Console.WriteLine(Description);
        if (Encounter != null && !Encounter.IsCompleted)
        {
            Encounter.Start(new List<Player> { player });
        }
    }
    public virtual void Describe()
    {
        Console.WriteLine($"\nYou are in the {Name}.");
        Console.WriteLine(Description);
        Console.WriteLine("\nExits:");
        foreach (var nextRoom in Exits)
        {
            Console.WriteLine($"- {nextRoom.Key} {nextRoom.Value.Name}");
        }
    }


}