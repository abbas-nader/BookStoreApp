using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Interfaces
{
    public interface IUserService
    {
        Task<OperationResult> AddAsync(User user, int userId);
        Task<OperationResult> UpdateAsync(User user, int userId);
        Task<OperationResult> DeleteAsync(int id, int userId);
        Task<OperationResult<IEnumerable<User>>> GetAllAsync();
        Task<OperationResult<User>> GetByIdAsync(int id);
    }
}
