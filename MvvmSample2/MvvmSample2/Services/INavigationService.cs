using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmSample2.Services
{
    public interface INavigationService
    {
        Task NonModalPush(Page page);
        Task ModalPush(Page page);
        Task NonModalPop();
        Task ModalPop();
    }
}
