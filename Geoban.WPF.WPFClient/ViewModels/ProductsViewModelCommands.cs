using Geoban.WPF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Geoban.WPF.WPFClient.ViewModels
{
    public partial class ProductsViewModel
    {
        #region CalculateCommand

        private ICommand calculateCommand;

        public ICommand CalculateCommand
        {
            get
            {
                if (calculateCommand == null)
                {
                    calculateCommand = new RelayCommand(p => Calculate(), p => CanCalculate);
                }

                return calculateCommand;
            }
        }



        public void Calculate()
        {
            SelectedProduct.Price = 100;
        }

        public bool CanCalculate
        {
            get
            {
                return IsSelected;
            }

        }

        #endregion

    }
}
