using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }           // קשר לקטגוריה ראשית
        public string Name { get; set; }              // שם תת-קטגוריה
        public decimal EstimatedPrice { get; set; }   // מחיר משוער

        // קשרים
        public Category Category { get; set; }
        public ICollection<AudioSample> AudioSamples { get; set; }
    }
}
