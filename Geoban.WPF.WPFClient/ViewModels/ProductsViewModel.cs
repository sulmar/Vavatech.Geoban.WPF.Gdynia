using Geoban.WPF.Common;
using Geoban.WPF.IServices;
using Geoban.WPF.MockServices;
using Geoban.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Geoban.WPF.WPFClient.ViewModels
{
    public partial class ProductsViewModel : BaseViewModel
    {
        private IList<Product> products;
        public IList<Product> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;

                OnPropertyChanged();
            }
        }

        public Product SelectedProduct { get; set; }

        private IProductsService productsService;

        public ProductsViewModel()
            : this(new MockProductsService())
        {
        }

        public ProductsViewModel(IProductsService productsService)
        {
            this.productsService = productsService;

          // Products = productsService.Get();

           // SelectedProduct = Products.First();
        }


        private ICommand loadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (loadCommand == null)
                {
                    loadCommand = new RelayCommand(p => LoadAsync());
                }

                return loadCommand;
            }
        }

        private void Load()
        {
           Products = productsService.Get();
        }

        private async void LoadAsync()
        {
            Products = await productsService.GetAsync();
        }

        public bool IsSelected
        {
            get
            {
                return true;
                // return SelectedProduct != null;
            }
        }
    }
}
