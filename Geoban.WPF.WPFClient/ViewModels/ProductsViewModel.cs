using Geoban.WPF.IServices;
using Geoban.WPF.MockServices;
using Geoban.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.WPFClient.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public IList<Product> Products { get; set; }

        private IProductsService productsService;


        public ProductsViewModel()
        {
            productsService = new MockProductsService();

            Products = productsService.Get();
        }

    }
}
