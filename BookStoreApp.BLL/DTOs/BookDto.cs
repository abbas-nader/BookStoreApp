using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.DTOs
{
    public class BookDto
    {
        public int? Id { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public int AuthorId { get; set; }

        public int PublisherId { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }
    }
}
