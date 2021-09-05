using MvvmSample2.Models;
using MvvmSample2.Services;
using MvvmSample2.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSample2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComposePage : ContentPage
    {
        public ComposePage(ObservableCollection<Email> inbox)
        {
            InitializeComponent();
            BindingContext = new ComposeViewModel(ref inbox, new AlertService(), new NavigationService());
        }
    }
}