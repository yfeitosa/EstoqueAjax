﻿using System;
using Estoque.Dominio.Entidades;
using Estoque.NHibernate.Mapping;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using Estoque.NHibernate.Convencoes;
using NHibernate;


namespace Estoque.NHibernate.NHibernateHelpers
{
    public class SessionFactoryProvider : IDisposable
    {
        private FluentConfiguration _fluentConfiguration;
        private ISessionFactory _sessionFactory;

        public void Dispose()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Dispose();
            }
        }

        public ISessionFactory GetSessionFactory()
        {
            if (_sessionFactory == null)
            {
                _fluentConfiguration = Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ShowSql().ConnectionString(c => c.FromConnectionStringWithKey("ConnectionString")))
                    //.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Livro>(new AppAutomappingCfg())));
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<AutorMap>());

                _sessionFactory = _fluentConfiguration.BuildSessionFactory();
            }

            return _sessionFactory;
        }

        public void AutoCriarBancoDeDados()
        {
            if (_fluentConfiguration != null)
            {
                var sessionSource = new SessionSource(_fluentConfiguration);
                ISession session = sessionSource.CreateSession();
                sessionSource.BuildSchema(session);
            }
        }

        private Action<IConventionFinder> GetConventions()
        {
            return c => c.Add<EnumConvention>();
        }
    }

    public class AppAutomappingCfg : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace != null && type.Namespace.StartsWith("Estoque.Dominio.Entidades");
        }
    }
}