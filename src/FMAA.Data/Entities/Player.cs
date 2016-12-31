using FMAA.Data.CustomAttributes;
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
        public virtual bool IsGoalkeeper { get; set; }

        // Attributes
        public IPlayerTechnicalAttributes TechnicalAttributes { get; set; }
        public PlayerMentalAttributes MentalAttributes { get; set; }
        public PlayerPhysicalAttributes PhysicalAttributes { get; set; }

        // Common Polygon Values
        public double Physical
        {
            get
            {
                double physical = (PhysicalAttributes.Agility + 
                                   PhysicalAttributes.Balance + 
                                   PhysicalAttributes.Stamina + 
                                   PhysicalAttributes.Strength)
                                  / 4;
                return physical;
            }
        }
        
        public double Speed
        {
            get
            {
                double speed = (PhysicalAttributes.Acceleration +
                                PhysicalAttributes.Pace)
                               / 2;
                return speed;
            }
        }
        
        public double Mental
        {
            get
            {
                double mental = (MentalAttributes.Anticipation  + 
                                 MentalAttributes.Bravery       + 
                                 MentalAttributes.Concentration + 
                                 MentalAttributes.Decisions     + 
                                 MentalAttributes.Determination + 
                                 MentalAttributes.Teamwork)
                                / 6;
                return mental;
            }
        }
        
        public double Aerial
        {
            get
            {
                double aerial;

                if (IsGoalkeeper)
                {
                    PlayerTechnicalGoalkeeperAttributes technical = (PlayerTechnicalGoalkeeperAttributes)TechnicalAttributes;

                    aerial = (technical.AerialReach + 
                              technical.Handling    + 
                              technical.TendencyToPunch)
                             / 3;
                }
                else
                {
                    PlayerTechnicalOutfieldAttributes technical = (PlayerTechnicalOutfieldAttributes)TechnicalAttributes;

                    aerial = (technical.Heading + 
                              PhysicalAttributes.JumpingReach)
                             / 2;
                }

                return aerial;
            }
        }

        // Outfield Polygon Values
        public double Defending
        {
            get
            {
                PlayerTechnicalOutfieldAttributes technical = (PlayerTechnicalOutfieldAttributes)TechnicalAttributes;

                double defending = (technical.Marking  + 
                                    technical.Tackling + 
                                    MentalAttributes.Positioning)
                                   / 3;
                return defending;
            }
        }
        
        
        public double Creativity
        {
            get
            {
                PlayerTechnicalOutfieldAttributes technical = (PlayerTechnicalOutfieldAttributes)TechnicalAttributes;

                double creativity = (technical.Passing       + 
                                     MentalAttributes.Vision + 
                                     MentalAttributes.Flair)
                                    / 3;
                return creativity;

            }
        }

        public double Attacking
        {
            get
            {
                PlayerTechnicalOutfieldAttributes technical = (PlayerTechnicalOutfieldAttributes)TechnicalAttributes;

                double attacking = (technical.Finishing        + 
                                    MentalAttributes.Composure + 
                                    MentalAttributes.OffTheBall)
                                   / 3;
                return attacking;
            }
        }

        public double Technical
        {
            get
            {
                PlayerTechnicalOutfieldAttributes technical = (PlayerTechnicalOutfieldAttributes)TechnicalAttributes;

                double technicalValue = (technical.Dribbling  + 
                                         technical.FirstTouch + 
                                         technical.Technique)
                                        / 3;
                return technicalValue;
            }
        }

        // Goalkeeper Polygon Values
        public double ShotStopping
        {
            get
            {
                PlayerTechnicalGoalkeeperAttributes technical = (PlayerTechnicalGoalkeeperAttributes)TechnicalAttributes;

                double shotStopping = (technical.OneOnOnes + 
                                       technical.Reflexes)
                                      / 2; 

                return shotStopping;
            }
        }

        public double Communication
        {
            get
            {
                PlayerTechnicalGoalkeeperAttributes technical = (PlayerTechnicalGoalkeeperAttributes)TechnicalAttributes;

                double communication = (technical.CommandOfArea + 
                                        technical.Communication)
                                       / 2; 

                return communication;
            }
        }

        public double Eccentricity
        {
            get
            {
                PlayerTechnicalGoalkeeperAttributes technical = (PlayerTechnicalGoalkeeperAttributes)TechnicalAttributes;
                
                return technical.Eccentricity;
            }
        }

        public double Distribution
        {
            get
            {
                PlayerTechnicalGoalkeeperAttributes technical = (PlayerTechnicalGoalkeeperAttributes)TechnicalAttributes;

                double distribution = (technical.Kicking + 
                                       technical.Throwing)
                                      / 2; 

                return distribution;
            }
        }

    }
}
