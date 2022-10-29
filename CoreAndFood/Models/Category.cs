using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Category Name must be filled.")]
        [StringLength(20,ErrorMessage ="Max 20 characters allowed.")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Food> Foods { get; set; }
    }
}
