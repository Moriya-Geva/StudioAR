using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.Entities
{
    public class OrderStatusHistory
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }
        public int ChangedById { get; set; }
        public string Notes { get; set; }
        public DateTime ChangedAt { get; set; }

        // קשרים
        public Order Order { get; set; }
        public User ChangedBy { get; set; }
    }
}
