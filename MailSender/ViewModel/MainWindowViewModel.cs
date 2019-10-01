using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MailSender.lib.Entityes.Base;
using MailSender.lib.Services.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MailSender.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IRecipientsDataProvider _RecipientsProvider;

        private string _WindowTitle = "Mail sender v0.1";

        public string WindowTitle
        {
            get => _WindowTitle;
            set => Set(ref _WindowTitle, value);
        }

        private ObservableCollection<Recipient> _Recipients  = new ObservableCollection<Recipient>();
         
        public ObservableCollection<Recipient> Recipients
        {
            get => _Recipients;
            set => Set(ref _Recipients, value);
        }
        public ICommand RefreshDataCommand { get; }

        public ICommand SaveChangesCommand { get; }

        public MainWindowViewModel(IRecipientsDataProvider RecipientsProvider)
        {
            _RecipientsProvider = RecipientsProvider;

            RefreshDataCommand = new RelayCommand(OnRefreshDataCommandExecuted, CanRefreshDataCommand);
            SaveChangesCommand = new RelayCommand(OnSaveChangesCommandExecuted);
        }

        private void OnSaveChangesCommandExecuted()
        {
            _RecipientsProvider.SaveChanges();
        }
       
        public bool CanRefreshDataCommand() => true;

        private void OnRefreshDataCommandExecuted()
        {
            RefreshData();
        }
        public void RefreshData()
        {
            var recipients = new ObservableCollection<Recipient>();
            recipients.Clear();
            foreach (var recipient in _RecipientsProvider.GetAll())
                recipients.Add(recipient);
            Recipients = recipients;
        }

        #region SelectedRecipient: Recepient - Выбранный получатель

        private Recipient _SelectedRecipient;
        public Recipient SelectedRecipient
        {
            get => _SelectedRecipient; 
            set => Set(ref _SelectedRecipient, value); 
        }             
        #endregion



    }
}
