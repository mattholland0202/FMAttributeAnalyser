namespace FMAA.Data.Entities
{
    public class PlayerMentalAttributes : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PlayerMentalAttributesID { get; set; }
        public virtual Player Player { get; set; }
        public virtual int Aggression { get; set; }
        public virtual int Anticipation { get; set; }
        public virtual int Bravery { get; set; }
        public virtual int Composure { get; set; }
        public virtual int Concentration { get; set; }
        public virtual int Decisions { get; set; }
        public virtual int Determination { get; set; }
        public virtual int Flair { get; set; }
        public virtual int Leadership { get; set; }
        public virtual int OffTheBall { get; set; }
        public virtual int Positioning { get; set; }
        public virtual int Teamwork { get; set; }
        public virtual int Vision { get; set; }
        public virtual int WorkRate { get; set; }
    }
}
