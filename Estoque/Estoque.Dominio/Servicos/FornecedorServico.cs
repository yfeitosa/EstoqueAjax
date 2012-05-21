using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;

namespace Estoque.Dominio.Servicos
{
    public class FornecedorServico
    {
        private readonly IFornecedorRepositorio _repositorio;

        public FornecedorServico(IFornecedorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IList<Fornecedor> PesquisarTodos()
        {
            return _repositorio.GetAll();
        }

        public Fornecedor Pesquisar(int id)
        {
            return _repositorio.Get(id);
        }
       
    }
}