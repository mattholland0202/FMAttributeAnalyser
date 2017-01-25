using FMAA.Data.Entities;

namespace FMAA.Data.Mapping
{
    public class PlayerMap : VersionedClassMap<Player>
    {
        public PlayerMap()
        {
            Id(x => x.PlayerID);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.UniquePlayerIdentifier).Nullable();
            Map(x => x.Nationality).Nullable();
            Map(x => x.Age).Nullable();
            Map(x => x.DateOfBirth).Nullable();
            Map(x => x.IsGoalkeeper).Not.Nullable();
            
            HasOne(x => x.MentalAttributes).Cascade.All();
            HasOne(x => x.PhysicalAttributes).Cascade.All();

            // TODO: How to do Technical Attributes -> Goalkeeper / Outfield?
            //References<PlayerTechnicalOutfieldAttributes>(x => x.TechnicalAttributes).Nullable().Cascade.All();
            //References<PlayerTechnicalGoalkeeperAttributes>(x => x.TechnicalAttributes).Nullable().Cascade.All();
        }
    }
}
