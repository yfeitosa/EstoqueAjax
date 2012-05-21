using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;
using Estoque.NHibernate.NHibernateHelpers;

namespace Estoque.NHibernate.Repositorios
{
    public class EstanteRepositorio : Repositorio<Estante>, IEstanteRepositorio
    {
        public EstanteRepositorio(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}

