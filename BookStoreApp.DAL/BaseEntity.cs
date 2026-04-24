using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public int CreationBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int? DeletedBy { get; set; }
        public bool Isdeleted { get; set; }
    }
}
