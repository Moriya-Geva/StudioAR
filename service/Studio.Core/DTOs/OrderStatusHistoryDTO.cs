using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class OrderStatusHistoryDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; }       // הסטטוס החדש
        public int ChangedById { get; set; }     // מי שינה את הסטטוס
        public string Notes { get; set; }        // הערות לשינוי
        public DateTime ChangedAt { get; set; }  // מתי השינוי בוצע
    }
}
