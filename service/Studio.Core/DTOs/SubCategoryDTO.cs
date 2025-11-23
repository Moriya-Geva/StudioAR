using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }      // מזהה הקטגוריה הראשית
        public string Name { get; set; }         // שם תת-הקטגוריה
        public decimal EstimatedPrice { get; set; } // מחיר משוער
    }
}
