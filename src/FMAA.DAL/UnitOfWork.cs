using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FMAA.DAL.Interfaces;
using FMAA.Data.Mapping;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMAA.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private ISession session;
        private IConfigurationRoot configuration { get; set; }

        public UnitOfWork()
        {
            //ConfigurationSetup();

            NHibernateSetup();

            this.PlayerRepository = new PlayerRepository(session);
        }

        private void ConfigurationSetup()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            configuration = builder.Build();
        }

        private void NHibernateSetup()
        {
            var sessionFactory = Fluently.Configure()
                                         .Database(SQLiteConfiguration.Standard.UsingFile("FMAA.db"))
                                         .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PlayerMap>())
                                         .ExposeConfiguration(BuildSchema)
                                         .BuildSessionFactory();

            session = sessionFactory.OpenSession();
        }

        private static void BuildSchema(Configuration config)
        {
            if (File.Exists("FMAA.db"))
            {
                File.Delete("FMAA.db");
            }

            new SchemaExport(config).Create(false, true);
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
