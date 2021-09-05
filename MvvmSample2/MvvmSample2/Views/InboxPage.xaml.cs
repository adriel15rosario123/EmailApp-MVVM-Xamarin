using MvvmSample2.Services;
using MvvmSample2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSample2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InboxPage : ContentPage
    {
        public InboxPage()
        {
            InitializeComponent();
            BindingContext = new InboxViewModel(new AlertService(), new NavigationService());
        }
    }
}