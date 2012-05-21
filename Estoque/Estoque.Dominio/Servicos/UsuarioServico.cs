
using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;

namespace Estoque.Dominio.Servicos
{
    public class UsuarioServico
    {
        private readonly IUsuarioRepositorio _repositorio;

        public UsuarioServico(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IList<Usuario> PesquisarTodos()
        {
            return _repositorio.GetAll();
        }

        public Usuario Pesquisar(int id)
        {
            return _repositorio.Get(id);
        }
       
    }
}