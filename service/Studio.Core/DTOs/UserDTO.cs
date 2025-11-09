using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }          // מזהה ייחודי של המשתמש
        public string UserName { get; set; } // שם משתמש להציג
        public string Email { get; set; }    // אימייל ליצירת קשר
        public string UserRole { get; set; } // Customer או Admin
        public bool IsActive { get; set; }   // האם המשתמש פעיל
    }
}
