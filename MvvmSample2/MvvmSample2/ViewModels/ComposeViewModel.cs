using MvvmSample2.Models;
using MvvmSample2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmSample2.ViewModels
{
    public class ComposeViewModel :  BaseViewModel
    {
        public ObservableCollection<Email> Inbox { get; set; }

        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        public ICommand AddEmailCommand { get; set; }

        public ComposeViewModel(ref ObservableCollection<Email> inbox, IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            Inbox = inbox;
            AddEmailCommand = new Command(OnAddCommand);
        }

        private async void OnAddCommand()
        {
            if(!string.IsNullOrEmpty(To) && !string.IsNullOrEmpty(From) && !string.IsNullOrEmpty(Subject) &&
                !string.IsNullOrEmpty(Description)){

                var newEmail = new Email(To, From, Subject, Description, DateTime.Now.ToString("MMM dd"), "https://cdn.psychologytoday.com/sites/default/files/styles/article-inline-half-caption/public/field_blog_entry_images/2018-09/shutterstock_648907024.jpg?itok=0hb44OrI");
                Inbox.Add(newEmail);

                await AlertService.AlertAsync("Nuevo email agregado", $"Se ha agregado con exito");

                await NavigationService.NonModalPop();
            }
            else
            {
                await AlertService.AlertAsync("Error", "Faltan campos por llenar, revise e intente de nuevo");
            }
        }
    }
}
