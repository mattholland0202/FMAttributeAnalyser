namespace FMAA.Data.Entities
{
    public class PlayerTechnicalGoalkeeperAttributes : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PlayerTechnicalGoalkeeperAttributesID { get; set; }
        public virtual Player Player { get; set; }
        public virtual int AerialReach { get; set; }
        public virtual int CommandOfArea { get; set; }
        public virtual int Communication { get; set; }
        public virtual int Eccentricity { get; set; }
        public virtual int FirstTouch { get; set; }
        public virtual int Handling { get; set; }
        public virtual int Kicking { get; set; }
        public virtual int OneOnOnes { get; set; }
        public virtual int Passing { get; set; }
        public virtual int PenaltyTaking { get; set; }
        public virtual int Reflexes { get; set; }
        public virtual int RushingOut { get; set; }
        public virtual int TendencyToPunch { get; set; }
        public virtual int Throwing { get; set; }
    }
}

