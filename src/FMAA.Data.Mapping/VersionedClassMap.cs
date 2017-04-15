// VersionedClassMap.cs
// Copyright Jamie Kurtz, Brian Wortman 2014.

using FluentNHibernate.Mapping;
using FMAA.Data;

namespace FMAA.Data.Mapping
{
    public abstract class VersionedClassMap<T> : ClassMap<T> where T : IVersionedEntity
    {
        protected VersionedClassMap()
        {
            Version(x => x.Version)
                .Nullable()
                .Column("ts")
                .CustomSqlType("Rowversion")
                .Generated.Always()
                .UnsavedValue("null");
        }
    }
}