using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using BlackBealt.Models;

namespace BlackBealt
{
  public class Idea : BaseEntity
  {
    [Key]
    public int IdeaId {get; set;}

    public int UserId {get; set;}
    [Required]
    [MinLength(5, ErrorMessage="Name must be at least 5 characters!")]    
    public string UserIdea {get; set;}
    public User Owner {get; set;}
    public List<Like> LikedBy {get; set;}
    public Idea()
    {
      LikedBy = new List<Like>();
    }
  }
}