namespace UsersManagement.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class UserViewModel
    {
        [Display(Name="User Name")]
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}