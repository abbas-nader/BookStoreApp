using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.Interfaces
{
    public interface ITranslatorService
    {
        Task<OperationResult> AddAsync(Translator translator, int userId);
        Task<OperationResult> UpdateAsync(Translator translator, int userId);
        Task<OperationResult> DeleteAsync(int id, int userId);
        Task<OperationResult<IEnumerable<Translator>>> GetAllAsync();
        Task<OperationResult<Translator>> GetByIdAsync(int id);
    }
}
