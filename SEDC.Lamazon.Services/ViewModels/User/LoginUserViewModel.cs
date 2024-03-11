using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SEDC.Lamazon.Services.ViewModels.User;

public class LoginUserViewModel
{

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
    public string Password { get; set; }
    
    public bool RememberMe  { get; set; }
}
