using Geoban.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoban.WPF.IServices
{
    public interface IProductsService
    {
        IList<Product> Get();

        void Add(Product product);

        Task<IList<Product>> GetAsync();

        Task AddAsync(Product product);

        



    }
}
