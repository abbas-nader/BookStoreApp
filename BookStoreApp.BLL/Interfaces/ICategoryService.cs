using BookStoreApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<OperationResult> AddAsync(Category category, int userId);
        Task<OperationResult> UpdateAsync(Category category, int userId);
        Task<OperationResult> DeleteAsync(int id, int userId);
        Task<OperationResult<IEnumerable<Category>>> GetAllAsync();
        Task<OperationResult<Category>> GetByIdAsync(int id);
    }
}
