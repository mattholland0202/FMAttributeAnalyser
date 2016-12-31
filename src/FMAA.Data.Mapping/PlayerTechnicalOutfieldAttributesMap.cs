using FMAA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMAA.Data.Mapping
{
    public class PlayerTechnicalOutfieldAttributesMap : VersionedClassMap<PlayerTechnicalOutfieldAttributes>
    {
        public PlayerTechnicalOutfieldAttributesMap()
        {
            Id(x => x.PlayerTechnicalOutfieldAttributesID);
            References(x => x.Player);
            Map(x => x.Corners).Not.Nullable();
            Map(x => x.Crossing).Not.Nullable();
            Map(x => x.Dribbling).Not.Nullable();
            Map(x => x.Finishing).Not.Nullable();
            Map(x => x.FirstTouch).Not.Nullable();
            Map(x => x.FreeKickTaking).Not.Nullable();
            Map(x => x.Heading).Not.Nullable();
            Map(x => x.LongShots).Not.Nullable();
            Map(x => x.LongThrows).Not.Nullable();
            Map(x => x.Marking).Not.Nullable();
            Map(x => x.Passing).Not.Nullable();
            Map(x => x.PenaltyTaking).Not.Nullable();
            Map(x => x.Tackling).Not.Nullable();
            Map(x => x.Technique).Not.Nullable();
        }
    }
}
