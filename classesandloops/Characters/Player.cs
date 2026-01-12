using System.Diagnostics.Tracing;
using Items;
namespace Characters
{
    public class Player
    {
        public string Name { get; }
        //LVL
        public int Level { get; private set; } = 1;
        public int Experience { get; set; } = 0;
        public int XpToNextLevel => Level * 100;
        //STATS
        public Stats Stats { get; } = new();
        public int MaxHp { get; private set; } = 100;
        public int HP { get; private set; } = 100;
        public Weapon? EquippedWeapon { get; private set; }
        public List<Item> Inventory { get; } = new();
        //Alive?
        public bool IsAlive => HP > 0;
        public Player(string name)
        {
            Name = name;
            RecalculateDervivedStats();
            HP = MaxHp;
        }
        private void RecalculateDervivedStats()
        {
            MaxHp = 50 + Stats.Vitality * 10;
        }
        public int PhysicalDamage()
        {
            return Stats.Strength * Level;
        }

        public void Heal(int amount) //+ HP
        {
            HP = Math.Min(MaxHp, HP + amount);
        }
        public void TakeDamage(int rawDamage) // - HP
        {
            int reduced = Math.Max(1, rawDamage - Stats.Resilience);
            HP -= reduced;
            Console.WriteLine($"{Name} takes {reduced}Damage.");
        }
        public int AttackDamage()
        {
            return EquippedWeapon?.Damage ?? 5;
        }
        public void GainExperience(int amount)
        {
            Experience += amount;
            Console.WriteLine($"{Name} gains {amount} exp.");
            while (Experience >= XpToNextLevel)
            {
                LevelUp();
            }
        }
        private void LevelUp()
        {
            Experience -= XpToNextLevel;
            Level++;
            Console.WriteLine($"{Name} is now {Level}!");
            AllocateStats();
            RecalculateDervivedStats();
            HP = MaxHp;
        }
        private void AllocateStats()
        {
            Console.WriteLine("Choose which stat to increase:");
            Console.WriteLine("1. Strength");
            Console.WriteLine("2. Dexterity");
            Console.WriteLine("3. Vitality");
            Console.WriteLine("4. Resilience");
            Console.WriteLine("5. Intellect");
            Console.WriteLine("6. Willpower");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1": Stats.Strength++; return;
                    case "2": Stats.Dexterity++; return;
                    case "3": Stats.Vitality++; return;
                    case "4": Stats.Resilience++; return;
                    case "5": Stats.Intellect++; return;
                    case "6": Stats.Willpower++; return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}