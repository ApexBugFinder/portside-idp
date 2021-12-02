using Microsoft.AspNetCore.Identity;
using System;
namespace IDP.Models
{
  public class UserToken : IdentityUserToken<Guid> { }
}