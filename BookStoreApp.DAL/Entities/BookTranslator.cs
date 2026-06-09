using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL.Entities
{
    public class BookTranslator : BaseEntity
    {
        public int BookId { get; set; }
        public int TranslatorId { get; set; }
        public Book Book { get; set; }
        public Translator Translator { get; set; }
    }
}
