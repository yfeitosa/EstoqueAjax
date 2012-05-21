﻿using System;
using Estoque.Dominio.Repositorio;
using Estoque.Dominio.Servicos;
using Estoque.NHibernate.NHibernateHelpers;
using Estoque.NHibernate.Repositorios;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Estoque.WebApplication
{
    public class Global : System.Web.HttpApplication
    {
        private static WindsorContainer _container;
        private IAdministradorServico _administradorServico;


        public static WindsorContainer InicializarContainer()
        {
            //if (_container == null)
            //{
                _container = new WindsorContainer();
                _container.Register(Component.For<IBancoDadosCreator>().ImplementedBy<BancoDadosCreator>());
                _container.Register(Component.For<IAdministradorServico>().ImplementedBy<AdministradorServico>());
                _container.Register(Component.For<IAutorRepositorio>().ImplementedBy<AutorRepositorio>());
                _container.Register(Component.For<ILivroRepositorio>().ImplementedBy<LivroRepositorio>());
                _container.Register(Component.For<IEstanteRepositorio>().ImplementedBy<EstanteRepositorio>());
                _container.Register(Component.For<IPrateleiraRepositorio>().ImplementedBy<PrateleiraRepositorio>());

                var sessionFactoryProvider = new SessionFactoryProvider();
                _container.Register(Component.For<SessionProvider>().LifeStyle.Singleton.Instance(new SessionProvider(sessionFactoryProvider)));
            //}
            return _container;

        }


        void Application_Start(object sender, EventArgs e)
        {
            var container =  Global.InicializarContainer();
            _administradorServico = container.Resolve<IAdministradorServico>();

            _administradorServico.AutoCriarBancoDeDados();
            _administradorServico.InserirDados();
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
