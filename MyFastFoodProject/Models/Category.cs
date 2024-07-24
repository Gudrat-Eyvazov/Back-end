using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MyFastFoodProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ValidateNever]
        public bool IsActive { get; set; } = true;
        public List<Products> Products { get; set; }
    }
}
