using FMAA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMAA.Data.Mapping
{
    public class PlayerTechnicalGoalkeeperAttributesMap : VersionedClassMap<PlayerTechnicalGoalkeeperAttributes>
    {
        public PlayerTechnicalGoalkeeperAttributesMap()
        {
            Id(x => x.PlayerTechnicalGoalkeeperAttributesID);
            References(x => x.Player);
            Map(x => x.AerialReach).Not.Nullable();
            Map(x => x.CommandOfArea).Not.Nullable();
            Map(x => x.Communication).Not.Nullable();
            Map(x => x.Eccentricity).Not.Nullable();
            Map(x => x.FirstTouch).Not.Nullable();
            Map(x => x.Handling).Not.Nullable();
            Map(x => x.Kicking).Not.Nullable();
            Map(x => x.OneOnOnes).Not.Nullable();
            Map(x => x.Passing).Not.Nullable();
            Map(x => x.PenaltyTaking).Not.Nullable();
            Map(x => x.Reflexes).Not.Nullable();
            Map(x => x.RushingOut).Not.Nullable();
            Map(x => x.TendencyToPunch).Not.Nullable();
            Map(x => x.Throwing).Not.Nullable();
        }
    }
}
