namespace FMAA.Data.Entities
{
    public class PlayerPhysicalAttributes : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PlayerPhysicalAttributesID { get; set; }
        public virtual Player Player { get; set; }
        public virtual int Acceleration { get; set; }
        public virtual int Agility { get; set; }
        public virtual int Balance { get; set; }
        public virtual int JumpingReach { get; set; }
        public virtual int NaturalFitness { get; set; }
        public virtual int Pace { get; set; }
        public virtual int Stamina { get; set; }
        public virtual int Strength { get; set; }
    }
}
