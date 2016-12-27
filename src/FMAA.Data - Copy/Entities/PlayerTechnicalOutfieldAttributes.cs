namespace FMAA.Data.Entities
{
    public class PlayerTechnicalOutfieldAttributes : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PlayerTechnicalOutfieldAttributesID { get; set; }
        public virtual Player Player { get; set; }
        public virtual int Corners { get; set; }
        public virtual int Crossing { get; set; }
        public virtual int Dribbling { get; set; }
        public virtual int Finishing { get; set; }
        public virtual int FirstTouch { get; set; }
        public virtual int FreeKickTaking { get; set; }
        public virtual int Heading { get; set; }
        public virtual int LongShots { get; set; }
        public virtual int LongThrows { get; set; }
        public virtual int Marking { get; set; }
        public virtual int Passing { get; set; }
        public virtual int PenaltyTaking { get; set; }
        public virtual int Tackling { get; set; }
        public virtual int Technique { get; set; }
    }
}
