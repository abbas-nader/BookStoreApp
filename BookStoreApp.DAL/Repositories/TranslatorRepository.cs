using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class TranslatorRepository : ITranslatorRepository
    {
        private readonly BookStoreDbContext _dbContext;

        public TranslatorRepository()
        {
            _dbContext = new BookStoreDbContext();
        }

        public async Task InsertAsync(Translator translator)
        {
            _dbContext.Translators.Add(translator);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, int userId)
        {
            var translator = await _dbContext.Translators.FindAsync(id);
            if (translator == null) return;
            translator.IsDeleted = true;
            translator.DeletedTime = DateTime.Now;
            translator.DeletedBy = userId;
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

        public async Task UpdateAsync(Translator translator, int userId)
        {
            var current = await _dbContext.Translators
                .FirstOrDefaultAsync(x => x.Id == translator.Id && !x.IsDeleted);
            if (current == null) return;
            current.FirstName = translator.FirstName;
            current.LastName = translator.LastName;
            current.LastModifiedTime = DateTime.Now;
            current.LastModifiedBy = userId;
            await _dbContext.SaveChangesAsync();
        }
    }
}

