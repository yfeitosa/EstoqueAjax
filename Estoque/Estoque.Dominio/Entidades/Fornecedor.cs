using System.Collections.Generic;

namespace Estoque.Dominio.Entidades
{
    public class Fornecedor
    {
        public virtual int CodFornecedor { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string NomeFantasia { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string Telefone { get; set; }
        public virtual IList<Produto> Produtos { get; set; }
    }
}
