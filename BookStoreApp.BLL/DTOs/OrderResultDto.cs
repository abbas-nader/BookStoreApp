using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.BLL.DTOs
{
    public class OrderResultDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemResultDto> OrderItems { get; set; }

    }
}
