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
        public ObservableCollection<Email> Inbox { get; set; } = new ObservableCollection<Email>() { 
            
            new Email("Adriel","Supermercado Bravo","tarea 1","adknfasjndasbdjbasjkdbfjkasbdasdfansdjlfasdfasjdsadfsa",DateTime.Now.ToString("MMM dd"),"https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg"),
            new Email("Adriel Rosario","Banco Popular","tarea 2","adknfasjndasbdjbasjkdbfjkasbdasdfansdjlfasdfasjdsadfsa",DateTime.Now.ToString("MMM dd"),"https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg"),
            new Email("Alex","Banco Popular","tarea 3","adknfasjndasbdjbasjkdbfjkasbdasdfansdjlfasdfasjdsadfsa",DateTime.Now.ToString("MMM dd"),"https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg"),
            new Email("Raul Lopez","Libreria ","tarea 4","adknfasjndasbdjbasjkdbfjkasbdasdfansdjlfasdfasjdsadfsa",DateTime.Now.ToString("MMM dd"),"https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg"),
            new Email("Yudelka Sanchez","Adriel Rosario","tarea 5","adknfasjndasbdjbasjkdbfjkasbdasdfansdjlfasdfasjdsadfsa",DateTime.Now.ToString("MMM dd"),"https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg"),
            new Email("Carlos Diaz","Juan Lopez","tarea 6","adknfasjndasbdjbasjkdbfjkasbdasdfansdjlfasdfasjdsadfsa",DateTime.Now.ToString("MMM dd"),"https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg"),
            new Email("Libreria","La Sirena","tarea 7","adknfasjndasbdjbasjkdbfjkasbdasdfansdjlfasdfasjdsadfsa",DateTime.Now.ToString("MMM dd"),"https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg"),



        };

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
