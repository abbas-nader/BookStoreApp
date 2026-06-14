using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.DTOs
{
    public class CustomerResultDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
    }
}
