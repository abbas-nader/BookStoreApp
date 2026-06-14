using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookStoreDbContext _dbContext;

        public CategoryRepository()
        {
            _dbContext = new BookStoreDbContext();
        }

        public async Task InsertAsync(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, int userId)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            if (category == null) return;
            category.IsDeleted = true;
            category.DeletedTime = DateTime.Now;
            category.DeletedBy = userId;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _dbContext.Categories
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _dbContext.Categories
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task UpdateAsync(Category category, int userId)
        {
            var current = await _dbContext.Categories
                .FirstOrDefaultAsync(x => x.Id == category.Id && !x.IsDeleted);
            if (current == null) return;
            current.Name = category.Name;
            current.LastModifiedTime = DateTime.Now;
            current.LastModifiedBy = userId;
            await _dbContext.SaveChangesAsync();
        }
    }
}
