namespace Estoque.Dominio.Entidades
{
    public class Usuario
    {
        public virtual int CodUsuario { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sobrenome { get; set; }
        public virtual string CPF { get; set; }
        public virtual Permissao Permissao { get; set; }
    }
}
