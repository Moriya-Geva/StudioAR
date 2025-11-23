using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Core.Entities;

namespace Studio.Core.Entities
{
    public class User
    {

        public int Id { get; set; }                
        public string UserName { get; set; }        
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }    // מלח להצפנה
        public string UserRole { get; set; }        // Customer / Admin
        public bool IsActive { get; set; }          // האם המשתמש פעיל
        public DateTime? LastLoginAt { get; set; }  // מתי המשתמש התחבר לאחרונה
                                                    // קשרים
        public ICollection<Order> Orders { get; set; } // הזמנות של הלקוח

    }
}