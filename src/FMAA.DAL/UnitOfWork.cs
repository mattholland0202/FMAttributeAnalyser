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

        public UnitOfWork()
        {
             //var cfg = Fluently.Configure().
            //   Database(SQLiteConfiguration.Standard.ShowSql().UsingFile("Foo.db")).
            //   Mappings(m => m.FluentMappings.AddFromAssemblyOf<PlayerMap>());
            //var _sessionFactory = cfg.BuildSessionFactory();
            //BuildSchema(cfg);
            //this.session = _sessionFactory.OpenSession();

            this.PlayerRepository = new PlayerRepository(session);
        }

        //private static void BuildSchema(FluentConfiguration configuration)
        //{
        //    var sessionSource = new SessionSource(configuration);
        //    var session = sessionSource.CreateSession();
        //    sessionSource.BuildSchema(session);            
        //}

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
