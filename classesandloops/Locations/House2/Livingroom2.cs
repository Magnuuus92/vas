using Characters;
using Happenings;
public class Livingroom2 : Room
{
    public Livingroom2() : base("Livingroom", "A foul stench is eminating from this place...")
    {
        Encounter = new CombatEncounter(
            new List<Enemy>
            {
                new Enemy("goblin", 1, 5, 2, 50),
                new Enemy("big goblin", 2, 6, 2, 55)
            }
        );
    }
}