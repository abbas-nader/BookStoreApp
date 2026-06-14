using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class PublisherRepository
    {
        private readonly BookStoreDbContext _dbContext;
        public PublisherRepository()
        {
        _dbContext = new BookStoreDbContext();

        }
        public async Task AddAsync(Publisher publisher)
        {
            _dbContext.Publishers.Add(publisher);
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
    }
}
