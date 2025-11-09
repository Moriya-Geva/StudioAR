using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.Enums
{
    public enum OrderStatus
    {
        Submitted = 1,     // נשלח
        Received = 2,      // התקבל
        InProgress = 3,    // בטיפול
        ReadyForPickup = 4, // מוכן לאיסוף
        Completed = 5,     // הושלם
        Cancelled = 6      // בוטל
    }
}