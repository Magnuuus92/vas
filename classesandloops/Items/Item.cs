using Characters;
namespace Items
{
    public class Item
    {
        public string Name { get; }
        public string Description { get; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public virtual void Use(Player player)
        {
            Console.WriteLine($"You cant use {Name}.");
        }
    }
}