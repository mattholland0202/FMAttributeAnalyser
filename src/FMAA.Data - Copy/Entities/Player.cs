using System;

namespace FMAA.Data.Entities
{
    public class Player : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual int PlayerID { get; set; }
        public virtual string Name { get; set; }
        public virtual int UniquePlayerIdentifier { get; set; }
        public virtual string Nationality { get; set; }
        public virtual int Age { get; set; }
        public virtual DateTime DateOfBirth { get; set; } 
    }
}
