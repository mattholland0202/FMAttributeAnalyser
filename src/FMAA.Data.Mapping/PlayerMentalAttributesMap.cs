using FMAA.Data.Entities;

namespace FMAA.Data.Mapping
{
    public class PlayerMentalAttributesMap : VersionedClassMap<PlayerMentalAttributes>
    {
        public PlayerMentalAttributesMap()
        {
            Id(x => x.PlayerMentalAttributesID);
            References(x => x.Player);
            Map(x => x.Aggression).Not.Nullable();
            Map(x => x.Anticipation).Not.Nullable();
            Map(x => x.Bravery).Not.Nullable();
            Map(x => x.Composure).Not.Nullable();
            Map(x => x.Concentration).Not.Nullable();
            Map(x => x.Decisions).Not.Nullable();
            Map(x => x.Determination).Not.Nullable();
            Map(x => x.Flair).Not.Nullable();
            Map(x => x.Leadership).Not.Nullable();
            Map(x => x.OffTheBall).Not.Nullable();
            Map(x => x.Positioning).Not.Nullable();
            Map(x => x.Teamwork).Not.Nullable();
            Map(x => x.Vision).Not.Nullable();
            Map(x => x.WorkRate).Not.Nullable();
        }
    }
}
