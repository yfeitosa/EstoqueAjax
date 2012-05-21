
using System.Collections.Generic;
using Estoque.Dominio.Entidades;
using Estoque.Dominio.Repositorio;

namespace Estoque.Dominio.Servicos
{
    public class AutorServico
    {
        private readonly IAutorRepositorio _repositorio;

        public AutorServico(IAutorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IList<Autor> PesquisarTodos()
        {
            return _repositorio.GetAll();
        }

        public Autor Pesquisar(int id)
        {
            return _repositorio.Get(id);
        }
       
    }
}