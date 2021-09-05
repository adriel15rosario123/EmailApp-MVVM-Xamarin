using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvvmSample2.Services
{
    public class AlertService : IAlertService
    {
        public Task AlertAsync(string title, string description)
        {
            return UserDialogs.Instance.AlertAsync(description, title);
        }
    }
}
