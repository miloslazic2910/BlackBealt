using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using BlackBealt .Models;

namespace BlackBealt
{
  public class User : BaseEntity
  {
    [Key]
    public int UserId {get; set;}
    [Required]
    [MinLength(2)]    
    [Display(Name = "User Name")]
    public string UserName {get; set;}
    public string UserAlias {get; set;}
    public string Email {get; set;}
    public string Password {get; set;}  
    public List<Like> UserLikes {get; set;}
    public List<Idea> UsersIdeas {get; set;}
    public User()
    {
      UserLikes = new List<Like>();
      UsersIdeas = new List<Idea>();
    }
  }
}