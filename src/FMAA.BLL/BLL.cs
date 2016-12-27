using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FMAA.BLL.Interfaces;
using FMAA.DAL;
using FMAA.DAL.Interfaces;
using FMAA.Data.Mapping;
using NHibernate;

namespace FMAA.BLL
{
    public class BLL : IBLL
    {
        public BLL()
        {
            //var cfg = Fluently.Configure().
            //   Database(SQLiteConfiguration.Standard.ShowSql().UsingFile("Foo.db")).
            //   Mappings(m => m.FluentMappings.AddFromAssemblyOf<PlayerMap>());
            //var _sessionFactory = cfg.BuildSessionFactory();
            //BuildSchema(cfg);

            //this.UnitOfWork = new UnitOfWork(_sessionFactory.OpenSession());
            this.UnitOfWork = new UnitOfWork(null);

            this.Players = new Players(UnitOfWork);
        }

        //private static void BuildSchema(FluentConfiguration configuration)
        //{
        //    var sessionSource = new SessionSource(configuration);
        //    var session = sessionSource.CreateSession();
        //    sessionSource.BuildSchema(session);            
        //}

        public IUnitOfWork UnitOfWork { get; set; }

        public IPlayers Players { get; set; }
    }
}
