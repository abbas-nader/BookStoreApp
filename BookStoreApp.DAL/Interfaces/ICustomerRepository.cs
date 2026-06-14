using BookStoreApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
    }
}
