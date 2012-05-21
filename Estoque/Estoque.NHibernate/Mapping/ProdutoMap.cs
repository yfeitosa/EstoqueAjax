using Estoque.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Estoque.NHibernate.Mapping
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Table("tb_Produto");
            Id(x => x.CodProduto).GeneratedBy.Native();

            Map(x => x.Descricao).Not.Nullable().Length(100);
            Map(x => x.PrecoVenda).Not.Nullable();
            Map(x => x.Custo).Not.Nullable();
            Map(x => x.QtdeEstoque).Not.Nullable();
            Map(x => x.QtdeMax).Not.Nullable();
            Map(x => x.QtdeMin).Not.Nullable();

            HasManyToMany(x => x.Fornecedores).Table("tb_fornecedor_produto")
            .Cascade.All();
        }
    }
}