using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreDbContext _dbContext;
        public BookRepository(BookStoreDbContext bookStoreDbContext)
        {
            _dbContext = bookStoreDbContext;
        }
        public async Task AddAsync(Book book)
        {

            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {

            var book = await _dbContext.Books.FindAsync(id);
            if (book == null)
                return;
            book.IsDeleted = true;
            book.DeletedTime = DateTime.Now;
            book.DeletedBy = 1;
            await _dbContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _dbContext.Books
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _dbContext.Books
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }
        public async Task UpdateAsync(Book book)
        {
            var currentBook = await _dbContext.Books.FindAsync(book.Id);
            if (currentBook == null) return;
            currentBook.Title = book.Title;
            currentBook.Isbn = book.Isbn;
            currentBook.Price = book.Price;
            currentBook.StockQuantity = book.StockQuantity;
            currentBook.CategoryId = book.CategoryId;
            currentBook.PublisherId = book.PublisherId;
            currentBook.PublicationYear = book.PublicationYear;
            currentBook.Description = book.Description;

            currentBook.LastModifiedTime = DateTime.Now;
            currentBook.LastModifiedBy = 1;

            await _dbContext.SaveChangesAsync();
        }
    }
}
