namespace BackendLogic.DM
{
    public class Action
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Action() { }
        public Action(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
