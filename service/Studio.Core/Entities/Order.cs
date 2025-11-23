using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Core.Entities;

namespace Studio.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }       // מספר ייחודי להזמנה
        public int UserId { get; set; }               // מי ביצע את ההזמנה
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string Status { get; set; }            // Submitted, Received, InProgress, ReadyForPickup, Completed
        public string Description { get; set; }       // תיאור העבודה
        public DateTime RequestedDate { get; set; }   // מועד רצוי
        public string Notes { get; set; }             // הערות נוספות
        public decimal EstimatedPrice { get; set; }   // מחיר משוער
        public decimal FinalPrice { get; set; }       // מחיר סופי

        // קשרים
        public User User { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<OrderFile> OrderFiles { get; set; }
        public ICollection<DeliverableFile> DeliverableFiles { get; set; }
        public ICollection<OrderStatusHistory> StatusHistory { get; set; }
        public ICollection<ChatMessage> ChatMessages { get; set; }
    }
}