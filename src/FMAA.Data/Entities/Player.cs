using FMAA.Data.Utils;
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

        // Attributes
        public IPlayerTechnicalAttributes TechnicalAttributes { get; set; }
        public PlayerMentalAttributes MentalAttributes { get; set; }
        public PlayerPhysicalAttributes PhysicalAttributes { get; set; }

        // Polygon Values
        public int Defending { get; set; }
        public int Physical { get; set; }
        public int Speed { get; set; }
        public int Creativity { get; set; }
        public int Attacking { get; set; }
        public int Technical { get; set; }
        public int Aerial { get; set; }
        public int Mental { get; set; }
    }
}
