using System.Collections.Generic;
using Characters;
using Skills;
namespace Happenings
{
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


            Combat combat = new Combat();
            combat.StartCombat(party, Enemies);
            IsCompleted = true;
        }
    }
}