using System.Collections.Generic;
using System.Linq;

namespace BackendLogic.PC
{
    // Class representing item used to store data and work in backend
    public class Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public List<int> Cost { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        public bool Equipped { get; set; }

        public Item(string name, string category, List<int> cost, int weight, string description)
        {
            Name = name;
            Category = category;
            Cost = cost;
            Weight = weight;
            Description = description;
            Equipped = false;
        }

        public string CostToString()
        {
            var costs = new List<string> { $"{Cost[0]} PP", $"{Cost[1]} GP", $"{Cost[2]} EP", $"{Cost[3]} SP", $"{Cost[4]} CP" };
            costs = costs.Where(cost => cost.Split()[0] != "0").ToList();
            if (costs.Count == 0 )
            {
                return "Free";
            }
            return costs.Aggregate((c1, c2) => string.Join(" ", c1, c2));
        }
    }
}