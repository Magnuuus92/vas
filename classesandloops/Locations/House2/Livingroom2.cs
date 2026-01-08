using Characters;
using Happenings;
public class Livingroom2 : Room
{
    public Livingroom2() : base("Livingroom", "A foul stench is eminating from this place...")
    {
        Encounter = new CombatEncounter(
            new List<Enemy>
            {
                new Enemy("goblin", 20, 5),
                new Enemy("big goblin", 28, 6)
            }
        );
    }
}