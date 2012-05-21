using System.Collections.Generic;

namespace Estoque.Dominio.Entidades
{
    public class Produto
    {
        public virtual int CodProduto { get; set; }
        public virtual string Descricao { get; set; }
        public virtual decimal Custo { get; set; }
        public virtual decimal PrecoVenda { get; set; }
        public virtual decimal QtdeMin { get; set; }
        public virtual decimal QtdeMax { get; set; }
        public virtual decimal QtdeEstoque { get; set; }
        public virtual IList<Fornecedor> Fornecedores { get; set; }
    }
}
