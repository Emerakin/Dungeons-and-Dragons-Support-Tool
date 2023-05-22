namespace BackendLogic.DM
{
    public class Trait
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Trait() { }
        public Trait(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
