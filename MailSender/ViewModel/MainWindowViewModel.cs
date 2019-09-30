using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MailSender.lib.Data.Linq2SQL;
using MailSender.lib.Services;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        private ObservableCollection<Recepient> _Recipients  = new ObservableCollection<Recepient>();
         
        public ObservableCollection<Recepient> Recipients
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
            var recipients = new ObservableCollection<Recepient>();
            recipients.Clear();
            foreach (var recipient in _RecipientsProvider.GetAll())
                recipients.Add(recipient);
            Recipients = recipients;
        }

        #region SelectedRecipient: Recepient - Выбранный получатель

        private Recepient _SelectedRecipient;
        public Recepient SelectedRecipient
        {
            get => _SelectedRecipient; 
            set => Set(ref _SelectedRecipient, value); 
        }             
        #endregion



    }
}
