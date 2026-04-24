using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class PrintedBook : Book
    {
        public int StockQuantity { get; set; }
        public string CoverType { get; set; }

    }
}
