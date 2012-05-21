
using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;

namespace Estoque.Dominio.Servicos
{
    public class LivroServico
    {
        private readonly ILivroRepositorio _livroDAO;
        public LivroServico(ILivroRepositorio livroDAO)
        {
            _livroDAO = livroDAO;
        }

        public IList<Livro> PesquisarTodos()
        {
            return _livroDAO.GetAll();
        }

        public Livro Pesquisar(int id)
        {
            return _livroDAO.Get(id);
        }
    }
}