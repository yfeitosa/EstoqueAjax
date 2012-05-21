using Estoque.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Estoque.NHibernate.Mapping
{
    public class FornecedorMap : ClassMap<Fornecedor>
    {
        public FornecedorMap()
        {
            Table("tb_Fornecedor");
            Id(x => x.CodFornecedor).GeneratedBy.Native();

            Map(x => x.Descricao).Not.Nullable().Length(50);
            Map(x => x.NomeFantasia).Not.Nullable().Length(50);
            Map(x => x.CNPJ).Not.Nullable().Length(50);
            Map(x => x.Telefone).Not.Nullable().Length(50);

            HasManyToMany(x => x.Produtos).Table("tb_fornecedor_produto")
            .Cascade.All();
        }
    }
}