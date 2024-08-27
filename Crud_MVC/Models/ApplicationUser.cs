using Microsoft.AspNetCore.Identity;

namespace Crud_MVC.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? ImageName { get; set; }
        public string? ContentType { get; set; } 

    }
}
