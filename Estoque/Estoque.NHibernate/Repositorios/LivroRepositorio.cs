using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;
using Estoque.NHibernate.NHibernateHelpers;
using System.Collections.Generic;

namespace Estoque.NHibernate.Repositorios
{
    public class LivroRepositorio : Repositorio<Livro>, ILivroRepositorio
    {
        public LivroRepositorio(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}

