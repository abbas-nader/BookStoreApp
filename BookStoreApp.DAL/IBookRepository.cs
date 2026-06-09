using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
        Task UpdateAsync(Book book, int userId);
        Task DeleteAsync(int id, int userId);
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
    }
}
