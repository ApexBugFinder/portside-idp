using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace IDP.Models
{
  // Add profile data for application users by adding properties to the ApplicationUser class
  [Table("AspNetUsers")]
  public class User : IdentityUser<Guid>
  {

public override string UserName {get; set;}
      public override Guid Id {get; set;}
    public User()
    {
      Id = Guid.NewGuid();
    }
    public User(string name) : this() { UserName = name; }
  }
}
