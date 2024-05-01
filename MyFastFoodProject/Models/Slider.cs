using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFastFoodProject.Models
{
    public class Slider
    {
        
        public int Id { get; set; }
        [Required]
        public string Tittle { get; set; }
        [Required]
        public string Subtitle { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string LastPrice { get; set; }
        [Required]
        public string NewPrice { get; set; }
        [Required]
        public string? ImgUrl { get; set; }
        [NotMapped]
        [ValidateNever]
        public IFormFile ImgFile { get; set; }

        public bool IsCheck { get; set; } = false;

    }
}
