using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class FAQDTO
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? CategoryId { get; set; }  // אפשר להציג לפי קטגוריה
        public int ViewCount { get; set; }    // מספר צפיות
    }
}
