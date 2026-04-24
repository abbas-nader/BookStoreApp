using System.Collections.Generic;

namespace BookStoreApp.DAL
{
    public class Book: BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublicationYear { get; set; }
        public string Isbn { get; set; }
        public int Price { get ; set; }
        public string  Description { get; set; }
    }
}
