using MvvmSample2.Models;
using MvvmSample2.Services;
using MvvmSample2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmSample2.ViewModels
{
    public class InboxViewModel: BaseViewModel
    {
        public ObservableCollection<Email> Inbox { get; set; } = new ObservableCollection<Email>();

        private Email _selectedEmail;

        public Email SelectedEmail
        {
            get
            {
                return _selectedEmail;
            }

            set
            {
                _selectedEmail = value;

                if(_selectedEmail != null)
                {
                    ShowEmailDetailPageCommand.Execute(_selectedEmail);
                    //SelectedEmail = null;
                }
            }
        }

        public ICommand ComposeNewEmailCommand { get; }
        public ICommand DeleteEmailCommnad { get; }
        public ICommand ShowEmailDetailPageCommand { get; }

        public InboxViewModel(IAlertService alertService, INavigationService navigationService): base(alertService,navigationService)
        {
            ComposeNewEmailCommand = new Command(OnComposeNewEmail);
            DeleteEmailCommnad = new Command<Email>(OnDeleteEmail);
            ShowEmailDetailPageCommand = new Command<Email>(OnShowEmailDetailPage);
        }

        private async void OnShowEmailDetailPage(Email email)
        {
            await NavigationService.NonModalPush(new DetailPage(email));
        }

        private async void OnDeleteEmail(Email email)
        {
            Inbox.Remove(email);
            await AlertService.AlertAsync("Email borrado", "borrado exitosamente");
        }

        private async void OnComposeNewEmail()
        {
            await NavigationService.NonModalPush(new ComposePage(Inbox));
        }
    }
}
