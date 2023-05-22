using System.Collections.Generic;

namespace BackendLogic.DM
{
    public struct DamageTypeModifiers
    {
        public List<DamageType> DamageTypeVulnerabilities { get; set; }
        public List<DamageType> DamageTypeResistances { get; set; }
        public List<DamageType> DamageTypeImmunities { get; set; }
    }
}
