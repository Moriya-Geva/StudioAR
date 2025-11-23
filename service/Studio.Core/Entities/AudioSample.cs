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
    public class AudioSample
    {
        public int Id { get; set; }
        public string FileName { get; set; }         // שם הקובץ המקורי
        public string FilePath { get; set; }         // נתיב אחסון
        public double Duration { get; set; }         // משך הדוגמה בשניות
        public long FileSize { get; set; }           // גודל הקובץ בבייטים

        // קשרים
        public Category Category { get; set; }
    }
}
