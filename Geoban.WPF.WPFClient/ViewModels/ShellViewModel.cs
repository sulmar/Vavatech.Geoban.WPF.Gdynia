using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.WPFClient.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; set; }


        public ShellViewModel()
        {
            this.SelectedViewModel = new ProductsViewModel();
        }
    }
}
