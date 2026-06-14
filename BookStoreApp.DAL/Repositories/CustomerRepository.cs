using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BookStoreDbContext _dbContext;

        public CustomerRepository()
        {
            _dbContext = new BookStoreDbContext();
        }

        public async Task InsertAsync(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, int userId)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null) return;
            customer.IsDeleted = true;
            customer.DeletedTime = DateTime.Now;
            customer.DeletedBy = userId;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _dbContext.Customers
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _dbContext.Customers
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task UpdateAsync(Customer customer, int userId)
        {
            var current = await _dbContext.Customers
                .FirstOrDefaultAsync(x => x.Id == customer.Id && !x.IsDeleted);
            if (current == null) return;
            current.FirstName = customer.FirstName;
            current.LastName = customer.LastName;
            current.Phone = customer.Phone;
            current.LastModifiedTime = DateTime.Now;
            current.LastModifiedBy = userId;
            await _dbContext.SaveChangesAsync();
        }
    }
}
