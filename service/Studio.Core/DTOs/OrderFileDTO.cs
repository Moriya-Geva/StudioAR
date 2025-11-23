using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class OrderFileDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OriginalFileName { get; set; } // שם הקובץ המקורי
        public string StoredFileName { get; set; }   // שם קובץ באחסון
        public long FileSize { get; set; }
        public string FileType { get; set; }
    }
}
