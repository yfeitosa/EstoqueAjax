﻿using System;
using System.Collections.Generic;

namespace Estoque.Dominio.Entidades
{
    public class Prateleira
    {
        public virtual int Id { get; private set; }
        public virtual string Classe { get; set; }
        public virtual Estante Estante { get; set; }
        public virtual DateTime Data_Criacao { get; set; }
        public virtual IList<Livro> Livros { get; set; }

        public virtual void AdicionarLivros(Livro livro)
        {
            if (Livros == null)
            {
                Livros = new List<Livro>();
            }
            livro.Prateleira = this;
            Livros.Add(livro);
        }
    }
}
