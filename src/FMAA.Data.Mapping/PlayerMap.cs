using FMAA.Data.Entities;

namespace FMAA.Data.Mapping
{
    public class PlayerMap : VersionedClassMap<Player>
    {
        public PlayerMap()
        {
            Id(x => x.PlayerID);
        }
    }
}
