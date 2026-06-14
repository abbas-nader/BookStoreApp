using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookStoreDbContext _dbContext;

        public OrderRepository()
        {
            _dbContext = new BookStoreDbContext();
        }

        public async Task InsertAsync(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, int userId)
        {
            var order = await _dbContext.Orders.FindAsync(id);
            if (order == null) return;
            order.IsDeleted = true;
            order.DeletedTime = DateTime.Now;
            order.DeletedBy = userId;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _dbContext.Orders
                .Where(x => !x.IsDeleted)
                .Include(x => x.Customer)
                .Include(x => x.User)
                .Include(x => x.OrderItems.Select(oi => oi.Book))
                .ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _dbContext.Orders
                .Include(x => x.Customer)
                .Include(x => x.User)
                .Include(x => x.OrderItems.Select(oi => oi.Book))
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task UpdateAsync(Order order, int userId)
        {
            var current = await _dbContext.Orders
                .FirstOrDefaultAsync(x => x.Id == order.Id && !x.IsDeleted);
            if (current == null) return;
            current.TotalAmount = order.TotalAmount;
            current.LastModifiedTime = DateTime.Now;
            current.LastModifiedBy = userId;
            await _dbContext.SaveChangesAsync();
        }
    }
}
