using System.Xml.XPath;

namespace Characters
{
    public class Enemy
    {
        public string Name { get; }
        //STATS
        public Stats Stats { get; } = new();
        public int HP { get; private set; }
        public int Damage { get; }
        public int Defence { get; }
        //EXP Reward
        public int ExperienceReward { get; }
        //Alive?
        public bool IsAlive => HP > 0;
        public Enemy(string name, int vitality, int strength, int resilience, int xp = 50)
        {
            Name = name;
            Stats.Vitality = vitality;
            Stats.Strength = strength;
            Stats.Resilience = resilience;

            HP = 30 + vitality * 10;
            ExperienceReward = xp;

        }
        public int PhysicalDamage()
        {
            return Stats.Strength;
        }
        public void TakeDamage(int rawDamage)
        {
            int reduced = Math.Max(1, rawDamage - Stats.Resilience);
            HP -= reduced;
            Console.WriteLine($"{Name} takes {reduced} damage.");
        }
    }
}