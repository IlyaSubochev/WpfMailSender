using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using MailSender.lib.Services;
using MailSender.lib.Data.Linq2SQL;
using MailSender.lib.Services.InMemory;
using MailSender.lib.Services.Interfaces;
using System;

namespace MailSender.ViewModel
{
    
    public class ViewModelLocator
    {
       
        public ViewModelLocator()
        {
            var services = SimpleIoc.Default;
            ServiceLocator.SetLocatorProvider(() => services);

            services.Register<MainWindowViewModel>();

            services
                .TryRegister<IRecipientsDataProvider, Linq2SqlRecipientsDataProvider>()
                .TryRegister(() => new MailSenderDBDataContext());

            //if (services.IsRegistered<IRecipientsDataProvider>())
            //services.Register<IRecipientsDataProvider, Linq2SqlRecipientsDataProvider>();

            //services.Register() => new MailSenderDBDataContext();

            //services.TryRegister<IRecipientsDataProvider, InMemoryRecipientDataProvider>()
            //    .TryRegister<ISendersDataProvider, InMemorySendersDataProvider>()
            //    .TryRegister<IServersDataProvider, InMemoryServersDataProvider>();

        }

        public MainWindowViewModel MainWindowModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }
        
        public static void Cleanup()  { }
       
    }

    public static class SimpleIocExtentions
    {
        public static SimpleIoc TryRegister<TInterface, TService>(this SimpleIoc services)
            where TInterface : class
            where TService : class, TInterface
        {
            if (services.IsRegistered<TInterface>()) return services;
            services.Register<TInterface, TService>();
            return services;

        }

        public static SimpleIoc TryRegister<TService>(this SimpleIoc services)
            where TService : class
        {
            if (services.IsRegistered<TService>()) return services;
            services.Register<TService>();
            return services;

        }

        public static SimpleIoc TryRegister<TService>(this SimpleIoc services, Func<TService> Factory)
            where TService : class
        {
            if (services.IsRegistered<TService>()) return services;
            services.Register(Factory);
            return services;

        }

    }
}