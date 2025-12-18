public class CombatEncounter
{
    public List<Enemy> Enemies { get; }
    public bool IsCompleted { get; private set; }
    public CombatEncounter(List<Enemy> enemies)
    {
        Enemies = enemies;
    }
    public void Start(List<Player> party)
    {
        if (IsCompleted)
            return;

        Combat.StartCombat(party, Enemies);
        IsCompleted = true;
    }//stuck!!!
}