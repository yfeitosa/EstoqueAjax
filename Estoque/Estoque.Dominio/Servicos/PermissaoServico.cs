using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;

namespace Estoque.Dominio.Servicos
{
    public class PermissaoServico
    {
        private readonly IPermissaoRepositorio _repositorio;

        public PermissaoServico(IPermissaoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IList<Permissao> PesquisarTodos()
        {
            return _repositorio.GetAll();
        }

        public Permissao Pesquisar(int id)
        {
            return _repositorio.Get(id);
        }
       
    }
}