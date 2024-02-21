using System.ComponentModel.DataAnnotations;

namespace Mission_6.Models
{
    public class Category
    {
        public int CategoryId {  get; set; }

        [Required(ErrorMessage = "Category Name is Required")]

        public string CategoryName { get; set; }
    }
}
