using Items;
namespace Characters
{
    public class Player
    {
        public string Name { get; }
        public int MaxHp { get; } = 100;
        public int HP { get; private set; } = 100;
        public Weapon? EquippedWeapon { get; private set; }
        public List<Item> Inventory { get; } = new();
        public bool IsAlive => HP > 0;
        public Player(string name)
        {
            Name = name;
        }
        public void Heal(int amount) //+ HP
        {
            HP = Math.Min(MaxHp, HP + amount);
        }
        public void TakeDamage(int amount) // - HP
        {

            HP -= amount;
        }
        public int AttackDamage()
        {
            return EquippedWeapon?.Damage ?? 5;
        }
    }
}