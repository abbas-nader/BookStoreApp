using BookStoreApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL
{
    public interface IBookService
    {
        Task<OperationResult> AddAsync(Book book, int userId);
        Task<OperationResult> UpdateAsync(Book book, int userId);
        Task<OperationResult> DeleteAsync(int id, int userId);
        Task<OperationResult<IEnumerable<Book>>> GetAllAsync();
        Task<OperationResult<Book>> GetByIdAsync(int id);
    }
}
