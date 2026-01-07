namespace Items
{
    public class Weapon : Item
    {
        public int Damage { get; }
        public Weapon(string name, string description, int damage)
        : base(name, description)
        {
            Damage = damage;
        }
    }
}