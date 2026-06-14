using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.DTOs
{
    public class BookCreateDto
    {
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int PublicationYear { get; set; }
        public string Description { get; set; }
        public List<int> AuthorIds { get; set; }
        public List<int> TranslatorIds { get; set; }
    }
}
