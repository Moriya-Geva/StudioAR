using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class ChatMessageDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int SenderId { get; set; }        // מי שלח
        public string MessageType { get; set; }  // Text, File, System
        public string MessageText { get; set; }  // תוכן ההודעה
        public string FilePath { get; set; }     // אם קובץ, היכן הוא שמור
        public bool IsReadByAdmin { get; set; }
        public bool IsReadByCustomer { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
