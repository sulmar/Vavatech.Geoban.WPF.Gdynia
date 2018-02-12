using Geoban.WPF.IServices;
using Geoban.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.MockServices
{
    public class MockProductsService : IProductsService
    {
        private IList<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Mouse", Color = "Gray" , Price = 150},
            new Product { Id = 2, Name = "Monitor", Color = "Black" , Price = 1900 },
            new Product { Id = 3, Name = "Keyboard", Color = "Black" , Price = 200 }
        };

        public IList<Product> Get()
        {
            return products;
        }
    }
}
