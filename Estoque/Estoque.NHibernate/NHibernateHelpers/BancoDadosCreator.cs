using Estoque.Dominio.Repositorio;

namespace Estoque.NHibernate.NHibernateHelpers
{
    public class BancoDadosCreator : IBancoDadosCreator
    {
        public void AutoCriarBancoDeDados()
        {
            var sessionFactoryProvider = new SessionFactoryProvider();
            var sessionProvider = new SessionProvider(sessionFactoryProvider);
            sessionProvider.GetCurrentSession();
            sessionFactoryProvider.AutoCriarBancoDeDados();
        }
    }
}
