using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class ContactMessageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }          // שם השולח
        public string Email { get; set; }         // אימייל השולח
        public string Subject { get; set; }       // נושא ההודעה
        public string Message { get; set; }       // תוכן ההודעה
        public bool IsRead { get; set; }          // האם המנהל קרא את ההודעה
        public bool IsReplied { get; set; }       // האם נשלח מענה
        public DateTime CreatedAt { get; set; }   // מתי נשלחה ההודעה
    }
}
