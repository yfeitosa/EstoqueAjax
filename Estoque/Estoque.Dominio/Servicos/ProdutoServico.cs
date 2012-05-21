using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;

namespace Estoque.Dominio.Servicos
{
    public class ProdutoServico
    {
        private readonly IProdutoRepositorio _repositorio;

        public ProdutoServico(IProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IList<Produto> PesquisarTodos()
        {
            return _repositorio.GetAll();
        }

        public Produto Pesquisar(int id)
        {
            return _repositorio.Get(id);
        }
       
    }
}