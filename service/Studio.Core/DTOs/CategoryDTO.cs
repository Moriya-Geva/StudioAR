using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio.Core.DTOs
{
   public class CategoryDTO
{
    public int Id { get; set; }
    public string Name { get; set; }       // שם הקטגוריה
    public decimal EstimatedPrice { get; set; } // מחיר משוער
    public int DisplayOrder { get; set; }  // סדר הצגה באתר
    public string ImageUrl { get; set; }   // תמונה של הקטגוריה
    public string FormUrl { get; set; }    // קישור לטופס Google Forms
}
}
