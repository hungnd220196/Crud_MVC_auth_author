using System.ComponentModel.DataAnnotations;

namespace Crud_MVC.ViewModels
{
    public class RoleViewModel
    {
        public string? Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
