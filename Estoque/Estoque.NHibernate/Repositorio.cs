﻿using System.Collections.Generic;
using Estoque.Dominio.Repositorio;
using Estoque.NHibernate.NHibernateHelpers;
using NHibernate;

namespace Estoque.NHibernate
{
    public class Repositorio<T> : IRepositorio<T>
    {
        private readonly SessionProvider _sessionProvider;

        public Repositorio(SessionProvider sessionProvider)
        {
            _sessionProvider = sessionProvider;
        }

        protected ISession Session
        {
            get { return _sessionProvider.GetCurrentSession(); }
        }

        public void Save(T entidade)
        {
            Session.SaveOrUpdate(entidade);
            Session.Flush();
        }

        public T Get(int id)
        {
            return Session.Load<T>(id);
        }

        public void Delete(int id)
        {
            T entidade = Get(id);
            Delete(entidade);
        }

        public void Delete(T entidade)
        {
            Session.Delete(entidade);
            Session.Flush();
        }

        public IList<T> GetAll()
        {
            ICriteria criteria = Session.CreateCriteria(typeof(T));
            return criteria.List<T>();
        }
    }
}
