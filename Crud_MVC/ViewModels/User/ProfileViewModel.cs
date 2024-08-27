using System.ComponentModel.DataAnnotations;

namespace Crud_MVC.ViewModels.User
{
    public class ProfileViewModel
    {
        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; }

        [Required]
        [MaxLength(50), MinLength(3)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50), MinLength(3)]
        public string? LastName { get; set; }

        [Required]

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        public string Username { get; set; }

    }
}
