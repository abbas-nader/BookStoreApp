using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
         Task InsertAsync(T entity);
        Task UpdateAsync(T entity, int userId);
        Task DeleteAsync(int id, int userId);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
    }
}
