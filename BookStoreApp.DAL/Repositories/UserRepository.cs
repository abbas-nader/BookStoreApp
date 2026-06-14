using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookStoreDbContext _dbContext;

        public UserRepository()
        {
            _dbContext = new BookStoreDbContext();
        }

        public async Task InsertAsync(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, int userId)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user == null) return;
            user.IsDeleted = true;
            user.DeletedTime = DateTime.Now;
            user.DeletedBy = userId;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _dbContext.Users
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task UpdateAsync(User user, int userId)
        {
            var current = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.Id == user.Id && !x.IsDeleted);
            if (current == null) return;
            current.FirstName = user.FirstName;
            current.LastName = user.LastName;
            current.Username = user.Username;
            current.Password = user.Password;
            current.LastModifiedTime = DateTime.Now;
            current.LastModifiedBy = userId;
            await _dbContext.SaveChangesAsync();
        }
    }
}
