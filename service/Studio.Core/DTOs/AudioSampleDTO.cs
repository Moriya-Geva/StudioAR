using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class AudioSampleDTO
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }    // קשור לקטגוריה או לתת-קטגוריה
        public int? SubCategoryId { get; set; }
        public string FileName { get; set; }    // שם הקובץ
        public string FilePath { get; set; }    // נתיב אחסון
        public double Duration { get; set; }    // משך הדוגמה בשניות
        public long FileSize { get; set; }      // גודל הקובץ
    }
}
