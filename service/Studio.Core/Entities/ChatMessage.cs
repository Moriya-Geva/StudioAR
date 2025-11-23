using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.Entities
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SenderId { get; set; }
        public string MessageType { get; set; } // Text, File, System
        public string MessageText { get; set; }
        public string FilePath { get; set; }
        public bool IsReadByAdmin { get; set; }
        public bool IsReadByCustomer { get; set; }
        public DateTime CreatedAt { get; set; }

        // קשרים
        public Order Order { get; set; }
    }
}
