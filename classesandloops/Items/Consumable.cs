using Characters;
namespace Items
{
    public class Consumable : Item
    {
        public int HealAmount { get; }

        public Consumable(string name, string description, int healAmount)
        : base(name, description)
        {
            HealAmount = healAmount;
        }
        public override void Use(Player player)
        {
            player.Heal(HealAmount);
            Console.WriteLine($"You heal {HealAmount} HP.");
        }
    }
}