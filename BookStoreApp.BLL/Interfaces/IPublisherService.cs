using BookStoreApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Interfaces
{
    public interface IPublisherService
    {
        Task<OperationResult> AddAsync(Publisher publisher, int userId);
        Task<OperationResult> UpdateAsync(Publisher publisher, int userId);
        Task<OperationResult> DeleteAsync(int id, int userId);
        Task<OperationResult<IEnumerable<Publisher>>> GetAllAsync();
        Task<OperationResult<Publisher>> GetByIdAsync(int id);
    }
}
