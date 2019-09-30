using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using MailSender.lib.Services;
using MailSender.lib.Data.Linq2SQL;
using MailSender.lib.Services.InMemory;
using MailSender.lib.Services.Interfaces;

namespace MailSender.ViewModel
{
    
    public class ViewModelLocator
    {
       
        public ViewModelLocator()
        {
            var services = SimpleIoc.Default;
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);



            services.Register<MainWindowViewModel>();
            services.Register<IRecipientsDataProvider, Linq2SqlRecipientsDataProvider>();
            //services.Register<IRecipientsDataProvider,InMemoryRecipientDataProvider>();
            services.Register(() => new MailSenderDBDataContext());
        }

        public MainWindowViewModel MainWindowModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}