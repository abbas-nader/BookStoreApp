using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.DTOs
{
    public class BookResultDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string CategoryName { get; set; }
        public string PublisherName { get; set; }
        public int PublicationYear { get; set; }
        public string Description { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Translators { get; set; }
    }
}
