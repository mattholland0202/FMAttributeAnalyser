using FMAA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMAA.Data.Mapping
{
    public class PlayerPositionsMap : VersionedClassMap<PlayerPositions>
    {
        public PlayerPositionsMap()
        {
            Id(x => x.PlayerPositionsID);
            References(x => x.Player);
            Map(x => x.Goalkeeper).CustomType<PlayerPositionLevel>();
            Map(x => x.Sweeper).CustomType<PlayerPositionLevel>();
            Map(x => x.RightBack).CustomType<PlayerPositionLevel>();
            Map(x => x.CentreBack).CustomType<PlayerPositionLevel>();
            Map(x => x.LeftBack).CustomType<PlayerPositionLevel>();
            Map(x => x.RightWingBack).CustomType<PlayerPositionLevel>();
            Map(x => x.DefensiveMidfield).CustomType<PlayerPositionLevel>();
            Map(x => x.LeftWingBack).CustomType<PlayerPositionLevel>();
            Map(x => x.RightMidfield).CustomType<PlayerPositionLevel>();
            Map(x => x.CentreMidfield).CustomType<PlayerPositionLevel>();
            Map(x => x.LeftMidfield).CustomType<PlayerPositionLevel>();
            Map(x => x.RightAttackingMidfield).CustomType<PlayerPositionLevel>();
            Map(x => x.CentreAttackingMidfield).CustomType<PlayerPositionLevel>();
            Map(x => x.LeftAttackingMidfield).CustomType<PlayerPositionLevel>();
            Map(x => x.Striker).CustomType<PlayerPositionLevel>();
        }
    }
}
