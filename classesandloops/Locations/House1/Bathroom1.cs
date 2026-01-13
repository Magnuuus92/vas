using Happenings;
using Characters;
using Skills;
public class Bathroom1 : Room
{
    public Bathroom1() : base("Bathroom", "Kristoffer has been in the bathroom for way too long. Time to teach him a lesson!")
    {
        Encounter = new CombatEncounter(
            new List<Enemy>
            {
                new Enemy("Kristoffer", 1, 5, 2, 50)

            }
        );
    }
}