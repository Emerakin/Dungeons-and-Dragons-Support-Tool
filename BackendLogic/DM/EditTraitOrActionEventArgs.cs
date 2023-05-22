namespace BackendLogic.DM
{
    public class EditTraitOrActionEventArgs
    {
        public string Name;
        public string Description;

        public EditTraitOrActionEventArgs(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
