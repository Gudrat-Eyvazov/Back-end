using Microsoft.AspNetCore.Identity;

namespace MyFastFoodProject.Models
{
    public class ProgramUser:IdentityUser
    {
        
        public string ? Name { get; set; }
        public string ? Surname { get; set; }
        public int ? Age  { get; set; }

    }
}
