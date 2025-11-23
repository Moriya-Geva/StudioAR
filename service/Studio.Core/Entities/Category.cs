using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }             // שם הקטגוריה
        public decimal EstimatedPrice { get; set; }  // מחיר משוער
        public int DisplayOrder { get; set; }        // סדר הצגה באתר
        public string ImageUrl { get; set; }
        public string FormUrl { get; set; }

        // קשרים
        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<AudioSample> AudioSamples { get; set; }
    }
}

