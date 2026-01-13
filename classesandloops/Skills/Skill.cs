

using Characters;

namespace Skills
{
    public abstract class Skill
    {
        public string Name { get; }
        public string SkillDescription { get; }
        public int EnergyCost { get; }
        protected Skill(string name, string skilldescription, int energycost)
        {
            Name = name;
            SkillDescription = skilldescription;
            EnergyCost = energycost;
        }
        public abstract void Use(Player user, Enemy target);
    }
}