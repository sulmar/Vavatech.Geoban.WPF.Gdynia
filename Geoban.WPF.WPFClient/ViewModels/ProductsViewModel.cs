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
        public IList<Product> Products { get; set; }

        public Product SelectedProduct { get; set; }

        private IProductsService productsService;


        public ProductsViewModel()
        {
            productsService = new MockProductsService();

            Products = productsService.Get();

           // SelectedProduct = Products.First();
        }

       

        public bool IsSelected
        {
            get
            {
                return SelectedProduct != null;
            }
        }
    }
}
