using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookStoreDbContext _dbContext;

        public AuthorRepository()
        {
            _dbContext = new BookStoreDbContext();
        }

        public async Task InsertAsync(Author author)
        {
            _dbContext.Authors.Add(author);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, int userId)
        {
            var author = await _dbContext.Authors.FindAsync(id);
            if (author == null) return;
            author.IsDeleted = true;
            author.DeletedTime = DateTime.Now;
            author.DeletedBy = userId;
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

        public async Task UpdateAsync(Author author, int userId)
        {
            var current = await _dbContext.Authors
                .FirstOrDefaultAsync(x => x.Id == author.Id && !x.IsDeleted);
            if (current == null) return;
            current.FirstName = author.FirstName;
            current.LastName = author.LastName;
            current.LastModifiedTime = DateTime.Now;
            current.LastModifiedBy = userId;
            await _dbContext.SaveChangesAsync();
        }
    }
}
