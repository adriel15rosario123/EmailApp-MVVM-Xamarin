using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvvmSample2.Services
{
    public interface IAlertService
    {
        Task AlertAsync(string title, string description);
    }
}
