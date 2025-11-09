using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Notes { get; set; }
        public decimal EstimatedPrice { get; set; }
        public decimal FinalPrice { get; set; }

        // היסטוריה וצ׳אט
        public ICollection<OrderStatusHistoryDTO> StatusHistory { get; set; }
        public ICollection<ChatMessageDTO> ChatMessages { get; set; }
    }

}
