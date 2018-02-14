using Geoban.WPF.IServices;
using Geoban.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Geoban.WPF.MockServices
{

    public class MockPersonsService : MockItemsService<Person>
    {
        public override void Load()
        {
        }

    }


    public abstract class MockItemsService<TItem> : IItemsService<TItem>
    {
        protected IList<TItem> items = new List<TItem>();

        public virtual void Load()
        {

        }

        public virtual void Add(TItem item)
        {
            items.Add(item);
        }

        public virtual Task AddAsync(TItem item)
        {
            return Task.Run(() => Add(item));
        }

        public virtual IList<TItem> Get()
        {
            return items;
        }

        public virtual TItem Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IList<TItem>> GetAsync()
        {
            return Task.Run(() => Get());
        }
    }


    public class MockProductsService : IProductsService
    {
        private IList<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Mouse", Color = "Gray" , Price = 150},
            new Product { Id = 2, Name = "Monitor", Color = "Black" , Price = 1900 },
            new Product { Id = 3, Name = "Keyboard", Color = "Black" , Price = 200 }
        };

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Product product)
        {
            return Task.Run(() => Add(product));
        }

        public IList<Product> Get()
        {

            Thread.Sleep(TimeSpan.FromSeconds(5));

            return products;
        }

        public Task<IList<Product>> GetAsync()
        {
            // opakowanie metody synchronicznej
            return Task.Run(() => Get());
        }
    }
}
