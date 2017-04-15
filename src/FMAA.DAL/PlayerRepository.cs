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
            using (ITransaction tr = session.BeginTransaction())
            {
                try
                {
                    session.SaveOrUpdate(player);
                    tr.Commit();
                }
                catch (Exception)
                {
                    tr.Rollback();
                    throw;
                }
            }
        }

        public IEnumerable<Player> GetAll()
        {
            var query = session.QueryOver<Player>();
            return query.List();
        }
    }
}
