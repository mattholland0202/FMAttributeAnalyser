using FMAA.Data.CustomAttributes;

namespace FMAA.Data.Entities
{
    public class PlayerPositions : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PlayerPositionsID { get; set; }
        public virtual Player Player { get; set; }

        [FriendlyName("Goalkeeper")]
        [ShortName("GK")]
        public virtual PlayerPositionLevel Goalkeeper { get; set; }

        [FriendlyName("Sweeper")]
        [ShortName("SW")]
        public virtual PlayerPositionLevel Sweeper { get; set; }

        [FriendlyName("Right Back")]
        [ShortName("RB")]
        public virtual PlayerPositionLevel RightBack { get; set; }

        [FriendlyName("Centre Back")]
        [ShortName("CB")]
        public virtual PlayerPositionLevel CentreBack { get; set; }

        [FriendlyName("Left Back")]
        [ShortName("LB")]
        public virtual PlayerPositionLevel LeftBack { get; set; }

        [FriendlyName("Right Wing Back")]
        [ShortName("RWB")]
        public virtual PlayerPositionLevel RightWingBack { get; set; }

        [FriendlyName("Defensive Midfield")]
        [ShortName("DM")]
        public virtual PlayerPositionLevel DefensiveMidfield { get; set; }

        [FriendlyName("Left Wing Back")]
        [ShortName("LWB")]
        public virtual PlayerPositionLevel LeftWingBack { get; set; }

        [FriendlyName("Right Midfield")]
        [ShortName("RM")]
        public virtual PlayerPositionLevel RightMidfield { get; set; }

        [FriendlyName("Centre Midfield")]
        [ShortName("CM")]
        public virtual PlayerPositionLevel CentreMidfield { get; set; }

        [FriendlyName("Left Midfield")]
        [ShortName("LM")]
        public virtual PlayerPositionLevel LeftMidfield { get; set; }

        [FriendlyName("Right Attacking Midfield")]
        [ShortName("AMR")]
        public virtual PlayerPositionLevel RightAttackingMidfield { get; set; }

        [FriendlyName("Centre Attacking Midfield")]
        [ShortName("AMC")]
        public virtual PlayerPositionLevel CentreAttackingMidfield { get; set; }

        [FriendlyName("Left Attacking Midfield")]
        [ShortName("AML")]
        public virtual PlayerPositionLevel LeftAttackingMidfield { get; set; }

        [FriendlyName("Striker")]
        [ShortName("ST")]
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
