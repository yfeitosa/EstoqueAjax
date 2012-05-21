
using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;

namespace Estoque.Dominio.Servicos
{
    public class EstanteServico
    {
        private readonly IEstanteRepositorio _estanteDAO;

        public  EstanteServico(IEstanteRepositorio estanteDAO)
        {
            _estanteDAO = estanteDAO;
        }

        public IList<Estante> PesquisarTodos()
        {
            return _estanteDAO.GetAll();
        }

        public Estante Pesquisar(int id)
        {
            return _estanteDAO.Get(id);
        }
    }
}