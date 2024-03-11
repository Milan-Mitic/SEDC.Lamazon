using SEDC.Lamazon.Web.Views.Role;
using System.ComponentModel.DataAnnotations;

namespace SEDC.Lamazon.Services.ViewModels.User;

public class RegisterUserViewModel
{
    [Required(ErrorMessage = "Please enter your full name.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2 and 100 characters.")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Invalid characters in the full name.")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter a password.")]
    [DataType(DataType.Password)]
    [MinLength(3, ErrorMessage = "Password must be at least 3 characters.")]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
    [DataType(DataType.Password)]
    public string ConfirmationPassword { get; set; }

    [Required(ErrorMessage = "Please enter your phone number.")]
    [RegularExpression(@"^[0-9-]*$", ErrorMessage = "Invalid characters in the phone number.")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Please enter your Street Adress.")]
    [RegularExpression(@"^[a-zA-Z0-9\s,.'-]+$", ErrorMessage = "Invalid characters in the Street Address.")]
    public string StreetAdress { get; set; }

    [Required(ErrorMessage = "Please enter your city.")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Invalid characters in the City.")]
    public string City { get; set; }

    [Required(ErrorMessage = "Please enter your state.")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Invalid characters in the State.")]
    public string State { get; set; }

    [Required(ErrorMessage = "Please enter your postal code.")]
    [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid postal code.")]
    public string PostalCode { get; set; }

    public int RoleId { get; set; }
}
