using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class TranslatorRepository
    {
        private readonly BookStoreDbContext _dbContext;
        public TranslatorRepository()
        {
        _dbContext = new BookStoreDbContext();
        }
        public async Task AddAsync(Translator translator)
        {
            _dbContext.Translators.Add(translator);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Translator>> GetAllAsync()
        {
            return await _dbContext.Translators
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }
        public async Task<Translator> GetByIdAsync(int id)
        {
            return await _dbContext.Translators
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }
    }
}

