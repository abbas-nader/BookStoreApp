using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class AuthorRepository
    {
        private readonly BookStoreDbContext _dbContext;
        public AuthorRepository()
        {
            _dbContext = new BookStoreDbContext();
        }
        public async Task AddAsync(Author author)
        {
            _dbContext.Authors.Add(author);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _dbContext.Authors
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }
        public async Task<Author> GetByIdAsync(int id)
        {
            return await _dbContext.Authors
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }
    }
}
