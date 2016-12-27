using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FMAA.DAL.Interfaces;
using NHibernate;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMAA.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISession session;

        public UnitOfWork(ISession session)
        {
            this.session = session;

            this.PlayerRepository = new PlayerRepository(session);
        }

        public IPlayerRepository PlayerRepository { get; set; }

        public void SaveChanges(object o)
        {
            session.Save(o);
        }

        public void SaveOrUpdateChanges(object o)
        {
            session.SaveOrUpdate(o);
        }
    }
}
