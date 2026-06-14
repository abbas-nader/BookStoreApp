using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class CategoryRepository
    {
        private readonly BookStoreDbContext _dbContext;
        public CategoryRepository()
        {
            _dbContext = new BookStoreDbContext();
        }
        public async Task AddAsync(Category category)
        {
            _dbContext.Categories.Add(category);
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
    }
}
