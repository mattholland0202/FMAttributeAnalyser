using FMAA.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMAA.Data.Entities;
using NHibernate;

namespace FMAA.DAL
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ISession session;

        public PlayerRepository(ISession session)
        {
            this.session = session;
        }

        public void Add(Player player)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetAll()
        {
            Player p1 = new Player() { PlayerID = 12, Name = "Test Player 1" };
            Player p2 = new Player() { PlayerID = 1689, Name = "Test Player 2" };
            return new List<Player> { p1, p2 };
        }
    }
}
