using MvvmSample2.Models;
using MvvmSample2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmSample2.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        public string Subject { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string ProfileImage { get; set; }

        public DetailViewModel(Email email, IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            Subject = email.Subject;
            From = email.Sender;
            To = email.Receiver;
            Date = email.Created;
            Description = email.Description;
            ProfileImage = email.ProfileImage;
        }

    }
}
