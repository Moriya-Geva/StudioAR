using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.Entities
{
    
    public class SystemSetting
    {
        public int Id { get; set; }
        public string Key { get; set; }   // שם ההגדרה
        public string Value { get; set; } // ערך ההגדרה
    }
    //מאפשר למנהל לשנות הגדרות כלליות בלי לכתוב קוד.

//למשל שם הסטודיו, פרטי קשר, הגדרות קבצים, זמני עבודה וכו’
}
