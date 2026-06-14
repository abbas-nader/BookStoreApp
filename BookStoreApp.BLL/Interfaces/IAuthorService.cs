using BookStoreApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Interfaces
{
    public interface IAuthorService
    {
        Task<OperationResult> AddAsync(Author author, int userId);
        Task<OperationResult> UpdateAsync(Author author, int userId);
        Task<OperationResult> DeleteAsync(int id, int userId);
        Task<OperationResult<IEnumerable<Author>>> GetAllAsync();
        Task<OperationResult<Author>> GetByIdAsync(int id);
    }
}
