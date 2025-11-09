using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studio.Core.Entities;

namespace Studio.Core.Entities
{
    public class OrderFile
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OriginalFileName { get; set; }
        public string StoredFileName { get; set; }
        public long FileSize { get; set; }
        public string FileType { get; set; }

        // קשרים
        public Order Order { get; set; }
    }
}
