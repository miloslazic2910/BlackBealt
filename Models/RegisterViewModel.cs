using System.ComponentModel.DataAnnotations;

namespace BlackBealt.Models
{
  public class RegisterViewModel : BaseEntity
  {
    [Required]
    [MinLength(1)]    
    [Display(Name = " UserName ")]
    [RegularExpression(@"^[' 'A-Za-z ]+$", ErrorMessage = "User Name can only contain letters and space")]
    public string UserName {get; set;}



    [Required]
    [MinLength(1)]
    [Display(Name = " serAlias Name")]
    [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "User alias can only contain letters and number")]
    public string UserAlias {get; set;}



    [Required]
    [MinLength(1)]
    [EmailAddress]
    public string Email {get; set;}



    [Required]
    [MinLengthAttribute(8)]
    public string Password {get; set;}
    [Compare(nameof(Password))]
    public string PasswordConf {get; set;}
  }
}