using Estoque.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Estoque.NHibernate.Mapping
{
    public class PermissaoMap : ClassMap<Permissao>
    {
        public PermissaoMap()
        {
            Table("tb_Permissao");
            Id(x => x.CodPermissao).GeneratedBy.Native();
            Map(x => x.Descricao).Not.Nullable().Length(50);
        }
    }
}