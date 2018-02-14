using Geoban.WPF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Geoban.WPF.WPFClient.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        #region SelectedViewModel

        private BaseViewModel selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get
            {
                return selectedViewModel;
            }
            set
            {
                selectedViewModel = value;

                OnPropertyChanged();
            }
        }

        #endregion

        public ShellViewModel()
        {
            this.SelectedViewModel = new ProductsViewModel();
        }


        private ICommand showProductCommand;

        public ICommand ShowProductCommand
        {
            get
            {
                showProductCommand = CreateCommand(p => ShowProduct());

                return showProductCommand;
            }
        }

        private ICommand CreateCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            ICommand command = null;

            if (command == null)
            {
                command = new RelayCommand(execute);
            }

            return command;
        }

        public virtual void ShowProduct()
        {
            SelectedViewModel = new ProductViewModel();
           
        }


        public virtual bool CanShowProduct
        {
            get
            {
                return true;
            }
        }

    }
}
