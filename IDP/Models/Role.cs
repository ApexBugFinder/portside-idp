using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace IDP.Models
{
  [Table("AspNetRoles")]
  public class Role : IdentityRole<Guid>
  {

    public override string Name { get; set; }
    public Role()
    {
      Id = Guid.NewGuid();

    }
    public Role(string name) : this() { Name = name; }
  }
}