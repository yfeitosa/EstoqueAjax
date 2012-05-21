using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;
using Estoque.NHibernate.NHibernateHelpers;
using NHibernate;

namespace Estoque.NHibernate.Repositorios
{
    public class AutorRepositorio : Repositorio<Autor>, IAutorRepositorio

    {
        public AutorRepositorio(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
        }
}
