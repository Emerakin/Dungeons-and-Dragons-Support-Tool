namespace BackendLogic.DM
{
    public struct BasicInformation
    {
        public string Name { get; set; }
        public int ArmorClass { get; set; }
        public float ChallangeRating { get; set; }
        public int ProficiencyBonus { get; set; }
        public Aligment Aligment { get; set; }
        public Size Size { get; set; }
        public Type Type { get; set; }
        public int HitDice { get; set; }
        public int DiceCount { get; set; }
        public int Hp { get; set; }
    }
}
