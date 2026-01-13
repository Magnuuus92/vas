using Characters;
namespace Skills
{
    public class OneTwoCombo : Skill
    {
        public OneTwoCombo()
        : base(
        "OneTwoCombo",
        "Strike Twice, scales with STR*3.",
        30)
        { }
        public override void Use(Player user, Enemy target)
        {
            int damage =
            user.Stats.Strength * 3 +
            user.Level * 2;

            target.TakeDamage(damage);
            Console.WriteLine(
                $"{user.Name} uses {Name} on {target.Name}" +
                $"for {damage} damage!"
            );
        }
    }

}