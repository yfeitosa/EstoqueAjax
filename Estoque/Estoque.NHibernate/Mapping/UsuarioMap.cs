using Estoque.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace Estoque.NHibernate.Mapping
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("tb_Usuario");
            Id(x => x.CodUsuario).GeneratedBy.Native();

            Map(x => x.Nome).Not.Nullable().Length(50);
            Map(x => x.Sobrenome).Not.Nullable().Length(50);
            Map(x => x.CPF).Not.Nullable().Length(11);

            References(x => x.Permissao).Column("CodPermissao");
        }
    }
}