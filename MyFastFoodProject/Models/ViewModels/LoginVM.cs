using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MyFastFoodProject.Models.ViewModels
{
    public class LoginVM
    {
        
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
      
        [ValidateNever]
        public bool IsRemember { get; set; }
    }
}
