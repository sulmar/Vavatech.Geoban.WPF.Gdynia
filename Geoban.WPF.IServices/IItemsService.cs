using System.Collections.Generic;
using System.Threading.Tasks;

namespace Geoban.WPF.IServices
{
    public interface IItemsService<TItem>
    {
        IList<TItem> Get();

        TItem Get(int id);

        void Add(TItem item);

        Task<IList<TItem>> GetAsync();

        Task AddAsync(TItem item);
    }

   
}
