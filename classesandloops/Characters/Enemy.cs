namespace Characters
{
    public class Enemy
    {
        public string Name { get; }
        public int HP { get; private set; }
        public int Damage { get; }
        public int Defence { get; }
        public bool IsAlive => HP > 0;
        public Enemy(string name, int hp, int damage)
        {
            Name = name;
            HP = hp;
            Damage = damage;

        }
        public void TakeDamage(int amount)
        {
            HP -= amount;
        }
    }
}