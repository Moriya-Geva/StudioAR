using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class DeliverableFileDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string FileName { get; set; }
        public string StoredFileName { get; set; }
        public long FileSize { get; set; }
        public int DownloadCount { get; set; } // כמה פעמים הורד
    }
}
