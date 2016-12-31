using FMAA.Data.Entities;

namespace FMAA.Data.Mapping
{
    public class PlayerPhysicalAttributesMap : VersionedClassMap<PlayerPhysicalAttributes>
    {
        public PlayerPhysicalAttributesMap()
        {
            Id(x => x.PlayerPhysicalAttributesID);
            References(x => x.Player);

            Map(x => x.Acceleration).Not.Nullable();
            Map(x => x.Agility).Not.Nullable();
            Map(x => x.Balance).Not.Nullable();
            Map(x => x.JumpingReach).Not.Nullable();
            Map(x => x.NaturalFitness).Not.Nullable();
            Map(x => x.Pace).Not.Nullable();
            Map(x => x.Stamina).Not.Nullable();
            Map(x => x.Strength).Not.Nullable();
        }
    }
}
