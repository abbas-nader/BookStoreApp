using BookStoreApp.DAL.Entities;
using System.Collections.Generic;

namespace BookStoreApp.DAL
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int PublicationYear { get; set; }
        public string Description { get; set; }
        public ICollection<BookAuthor>BookAuthors { get; set; }
        public ICollection<BookTranslator> BookTranslators { get; set; }
        public  Category Category { get; set; }
        public Publisher Publisher { get; set; }
    }
}
