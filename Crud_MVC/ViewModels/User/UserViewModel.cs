using Crud_MVC.Helper;

namespace Crud_MVC.ViewModels.User
{
    public class UserViewModel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string UserName { get; set; } = null!;

    }
}
