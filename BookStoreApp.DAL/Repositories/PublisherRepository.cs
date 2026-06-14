using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly BookStoreDbContext _dbContext;

        public PublisherRepository()
        {
            _dbContext = new BookStoreDbContext();
        }

        public async Task InsertAsync(Publisher publisher)
        {
            _dbContext.Publishers.Add(publisher);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, int userId)
        {
            var publisher = await _dbContext.Publishers.FindAsync(id);
            if (publisher == null) return;
            publisher.IsDeleted = true;
            publisher.DeletedTime = DateTime.Now;
            publisher.DeletedBy = userId;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Publisher>> GetAllAsync()
        {
            return await _dbContext.Publishers
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public async Task<Publisher> GetByIdAsync(int id)
        {
            return await _dbContext.Publishers
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task UpdateAsync(Publisher publisher, int userId)
        {
            var current = await _dbContext.Publishers
                .FirstOrDefaultAsync(x => x.Id == publisher.Id && !x.IsDeleted);
            if (current == null) return;
            current.Name = publisher.Name;
            current.LastModifiedTime = DateTime.Now;
            current.LastModifiedBy = userId;
            await _dbContext.SaveChangesAsync();
        }
    }
}
