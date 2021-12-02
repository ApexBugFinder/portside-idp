using Microsoft.AspNetCore.Identity;
using IDP.Models;
using IDP.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Threading;
using System.Collections.Generic;
using System;

namespace IDP.Models {
  public class ApplicationRoleStore : RoleStore<Role, ApplicationDbContext, Guid, UserRole, RoleClaim>
  {
    public ApplicationRoleStore(ApplicationDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
    {
    }

    public override ApplicationDbContext Context => base.Context;

    public override IQueryable<Role> Roles => base.Roles;

    public override Task AddClaimAsync(Role role, Claim claim, CancellationToken cancellationToken = default)
    {
      return base.AddClaimAsync(role, claim, cancellationToken);
    }

    public override Guid ConvertIdFromString(string id)
    {

      return System.Guid.Parse(id);
    }

    public override string ConvertIdToString(Guid id)
    {
      return id.ToString();
    }

    public override Task<IdentityResult> CreateAsync(Role role, CancellationToken cancellationToken = default)
    {
      return base.CreateAsync(role, cancellationToken);
    }

    public override Task<IdentityResult> DeleteAsync(Role role, CancellationToken cancellationToken = default)
    {
      return base.DeleteAsync(role, cancellationToken);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override Task<Role> FindByIdAsync(string id, CancellationToken cancellationToken = default)
    {
      return base.FindByIdAsync(id, cancellationToken);
    }

    public override Task<Role> FindByNameAsync(string normalizedName, CancellationToken cancellationToken = default)
    {
      return base.FindByNameAsync(normalizedName, cancellationToken);
    }

    public override Task<IList<Claim>> GetClaimsAsync(Role role, CancellationToken cancellationToken = default)
    {
      return base.GetClaimsAsync(role, cancellationToken);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override Task<string> GetNormalizedRoleNameAsync(Role role, CancellationToken cancellationToken = default)
    {
      return base.GetNormalizedRoleNameAsync(role, cancellationToken);
    }

    public override Task<string> GetRoleIdAsync(Role role, CancellationToken cancellationToken = default)
    {
      return base.GetRoleIdAsync(role, cancellationToken);
    }

    public override Task<string> GetRoleNameAsync(Role role, CancellationToken cancellationToken = default)
    {
      return base.GetRoleNameAsync(role, cancellationToken);
    }

    public override Task RemoveClaimAsync(Role role, Claim claim, CancellationToken cancellationToken = default)
    {
      return base.RemoveClaimAsync(role, claim, cancellationToken);
    }

    public override Task SetNormalizedRoleNameAsync(Role role, string normalizedName, CancellationToken cancellationToken = default)
    {
      return base.SetNormalizedRoleNameAsync(role, normalizedName, cancellationToken);
    }

    public override Task SetRoleNameAsync(Role role, string roleName, CancellationToken cancellationToken = default)
    {
      return base.SetRoleNameAsync(role, roleName, cancellationToken);
    }

    public override string ToString()
    {
      return base.ToString();
    }

    public override Task<IdentityResult> UpdateAsync(Role role, CancellationToken cancellationToken = default)
    {
      return base.UpdateAsync(role, cancellationToken);
    }

    protected override RoleClaim CreateRoleClaim(Role role, Claim claim)
    {
      return new RoleClaim {
        RoleId = role.Id,
        ClaimType = claim.Type,
        ClaimValue = claim.Value
      };
    }
  }
}