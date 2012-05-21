using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;
using Estoque.NHibernate.NHibernateHelpers;
using System.Collections.Generic;

namespace Estoque.NHibernate.Repositorios
{
    public class PrateleiraRepositorio : Repositorio<Prateleira>, IPrateleiraRepositorio
    {
        public PrateleiraRepositorio(SessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}
