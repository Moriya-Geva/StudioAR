using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.Entities
{
    public class FAQ
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int? CategoryId { get; set; }
        public int ViewCount { get; set; }

        public Category Category { get; set; }
    }
}
