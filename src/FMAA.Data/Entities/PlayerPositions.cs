using FMAA.Data.Utils;

namespace FMAA.Data.Entities
{
    public class PlayerPositions : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PlayerPositionsID { get; set; }

        [FriendlyName("Goalkeeper", "GK")]
        public virtual PlayerPositionLevel Goalkeeper { get; set; }

        [FriendlyName("Sweeper", "SW")]
        public virtual PlayerPositionLevel Sweeper { get; set; }

        [FriendlyName("Right Back", "RB")]
        public virtual PlayerPositionLevel RightBack { get; set; }

        [FriendlyName("Centre Back", "CB")]
        public virtual PlayerPositionLevel CentreBack { get; set; }

        [FriendlyName("Left Back", "LB")]
        public virtual PlayerPositionLevel LeftBack { get; set; }

        [FriendlyName("Right Wing Back", "RWB")]
        public virtual PlayerPositionLevel RightWingBack { get; set; }

        [FriendlyName("Defensive Midfield", "DM")]
        public virtual PlayerPositionLevel DefensiveMidfield { get; set; }

        [FriendlyName("Left Wing Back", "LWB")]
        public virtual PlayerPositionLevel LeftWingBack { get; set; }

        [FriendlyName("Right Midfield", "RM")]
        public virtual PlayerPositionLevel RightMidfield { get; set; }

        [FriendlyName("Centre Midfield", "CM")]
        public virtual PlayerPositionLevel CentreMidfield { get; set; }

        [FriendlyName("Left Midfield", "LM")]
        public virtual PlayerPositionLevel LeftMidfield { get; set; }

        [FriendlyName("Right Attacking Midfield", "AMR")]
        public virtual PlayerPositionLevel RightAttackingMidfield { get; set; }

        [FriendlyName("Centre Attacking Midfield", "AMC")]
        public virtual PlayerPositionLevel CentreAttackingMidfield { get; set; }

        [FriendlyName("Left Attacking Midfield", "AML")]
        public virtual PlayerPositionLevel LeftAttackingMidfield { get; set; }

        [FriendlyName("Striker", "ST")]
        public virtual PlayerPositionLevel Striker { get; set; }
    }

    /// <summary>
    /// Enum to store the levels of competence that a Player can have in a position
    /// </summary>
    public enum PlayerPositionLevel
    {
        None,
        Awkward,
        Unconvincing,
        Competent,
        Accomplished,
        Natural
    }
}
