using Microsoft.AspNetCore.Identity;
using System;
namespace IDP.Models
{
  public class UserClaim : IdentityUserClaim<Guid> { }
}