using MvvmSample2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvvmSample2.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IAlertService AlertService { get; }
        public INavigationService NavigationService { get; }
        protected BaseViewModel(IAlertService alertService, INavigationService navigationService)
        {
            AlertService = alertService;
            NavigationService = navigationService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
