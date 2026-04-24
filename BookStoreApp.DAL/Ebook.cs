using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class Ebook : Book
    {
        public string DownloadLink { get; set; }
        public decimal FileSize { get; set; }
    }
}
