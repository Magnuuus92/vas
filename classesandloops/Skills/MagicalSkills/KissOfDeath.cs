using Characters;
namespace Skills
{
    public class KissOfDeath : Skill
    {
        public KissOfDeath()
        : base(
        "Kiss of death",
        "Blow a magical kiss, scales with Willpower*3.",
        40)
        { }
        public override void Use(Player user, Enemy target)
        {
            int damage =
            user.Stats.Willpower * 3 +
            user.Stats.Intellect * 1 +
            user.Level * 2;

            target.TakeDamage(damage);
            Console.WriteLine(
                $"{user.Name} uses {Name} on {target.Name}" +
                $"for {damage} damage!"
            );
        }
    }

}