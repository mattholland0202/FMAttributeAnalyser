using FMAA.DAL;
using FMAA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UnitOfWork u = new UnitOfWork();

            Player p = new Player
            {
                Name = "John",
                IsGoalkeeper = false,
                DateOfBirth = new DateTime(1992, 02, 02),
                
            };

            try
            {
                u.PlayerRepository.Add(p);

                var players = u.PlayerRepository.GetAll();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
