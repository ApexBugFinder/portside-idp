using System;
using Microsoft.AspNetCore.Identity;
using IDP.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;

namespace IDP.Models {
  public class ApplicationUserStore : UserStore<User, Role, ApplicationDbContext,
      Guid, UserClaim, UserRole, UserLogin, UserToken, RoleClaim>
  {
    public ApplicationUserStore(ApplicationDbContext context, IdentityErrorDescriber describer = null) : base(context, describer)
    {
    }

    public override ApplicationDbContext Context => base.Context;

    public override IQueryable<User> Users => base.Users;

    public override Task AddClaimsAsync(User user, IEnumerable<Claim> claims, CancellationToken cancellationToken = default)
    {
      return base.AddClaimsAsync(user, claims, cancellationToken);
    }

    public override Task AddLoginAsync(User user, UserLoginInfo login, CancellationToken cancellationToken = default)
    {
      return base.AddLoginAsync(user, login, cancellationToken);
    }

    public override Task AddToRoleAsync(User user, string normalizedRoleName, CancellationToken cancellationToken = default)
    {
      return base.AddToRoleAsync(user, normalizedRoleName, cancellationToken);
    }

    public override Guid ConvertIdFromString(string id)
    {
      return base.ConvertIdFromString(id);
    }

    public override string ConvertIdToString(Guid id)
    {
      return base.ConvertIdToString(id);
    }

    public override Task<int> CountCodesAsync(User user, CancellationToken cancellationToken)
    {
      return base.CountCodesAsync(user, cancellationToken);
    }

    public override Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.CreateAsync(user, cancellationToken);
    }

    public override Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.DeleteAsync(user, cancellationToken);
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override Task<User> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken = default)
    {
      return base.FindByEmailAsync(normalizedEmail, cancellationToken);
    }

    public override Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken = default)
    {
      return base.FindByIdAsync(userId, cancellationToken);
    }

    public override Task<User> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken = default)
    {
      return base.FindByLoginAsync(loginProvider, providerKey, cancellationToken);
    }

    public override Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken = default)
    {
      return base.FindByNameAsync(normalizedUserName, cancellationToken);
    }

    public override Task<int> GetAccessFailedCountAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetAccessFailedCountAsync(user, cancellationToken);
    }

    public override Task<string> GetAuthenticatorKeyAsync(User user, CancellationToken cancellationToken)
    {
      return base.GetAuthenticatorKeyAsync(user, cancellationToken);
    }

    public override Task<IList<Claim>> GetClaimsAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetClaimsAsync(user, cancellationToken);
    }

    public override Task<string> GetEmailAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetEmailAsync(user, cancellationToken);
    }

    public override Task<bool> GetEmailConfirmedAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetEmailConfirmedAsync(user, cancellationToken);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override Task<bool> GetLockoutEnabledAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetLockoutEnabledAsync(user, cancellationToken);
    }

    public override Task<DateTimeOffset?> GetLockoutEndDateAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetLockoutEndDateAsync(user, cancellationToken);
    }

    public override Task<IList<UserLoginInfo>> GetLoginsAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetLoginsAsync(user, cancellationToken);
    }

    public override Task<string> GetNormalizedEmailAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetNormalizedEmailAsync(user, cancellationToken);
    }

    public override Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetNormalizedUserNameAsync(user, cancellationToken);
    }

    public override Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetPasswordHashAsync(user, cancellationToken);
    }

    public override Task<string> GetPhoneNumberAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetPhoneNumberAsync(user, cancellationToken);
    }

    public override Task<bool> GetPhoneNumberConfirmedAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetPhoneNumberConfirmedAsync(user, cancellationToken);
    }

    public override Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetRolesAsync(user, cancellationToken);
    }

    public override Task<string> GetSecurityStampAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetSecurityStampAsync(user, cancellationToken);
    }

    public override Task<string> GetTokenAsync(User user, string loginProvider, string name, CancellationToken cancellationToken)
    {
      return base.GetTokenAsync(user, loginProvider, name, cancellationToken);
    }

    public override Task<bool> GetTwoFactorEnabledAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetTwoFactorEnabledAsync(user, cancellationToken);
    }

    public override Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetUserIdAsync(user, cancellationToken);
    }

    public override Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.GetUserNameAsync(user, cancellationToken);
    }

    public override Task<IList<User>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken = default)
    {
      return base.GetUsersForClaimAsync(claim, cancellationToken);
    }

    public override Task<IList<User>> GetUsersInRoleAsync(string normalizedRoleName, CancellationToken cancellationToken = default)
    {
      return base.GetUsersInRoleAsync(normalizedRoleName, cancellationToken);
    }

    public override Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.HasPasswordAsync(user, cancellationToken);
    }

    public override Task<int> IncrementAccessFailedCountAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.IncrementAccessFailedCountAsync(user, cancellationToken);
    }

    public override Task<bool> IsInRoleAsync(User user, string normalizedRoleName, CancellationToken cancellationToken = default)
    {
      return base.IsInRoleAsync(user, normalizedRoleName, cancellationToken);
    }

    public override Task<bool> RedeemCodeAsync(User user, string code, CancellationToken cancellationToken)
    {
      return base.RedeemCodeAsync(user, code, cancellationToken);
    }

    public override Task RemoveClaimsAsync(User user, IEnumerable<Claim> claims, CancellationToken cancellationToken = default)
    {
      return base.RemoveClaimsAsync(user, claims, cancellationToken);
    }

    public override Task RemoveFromRoleAsync(User user, string normalizedRoleName, CancellationToken cancellationToken = default)
    {
      return base.RemoveFromRoleAsync(user, normalizedRoleName, cancellationToken);
    }

    public override Task RemoveLoginAsync(User user, string loginProvider, string providerKey, CancellationToken cancellationToken = default)
    {
      return base.RemoveLoginAsync(user, loginProvider, providerKey, cancellationToken);
    }

    public override Task RemoveTokenAsync(User user, string loginProvider, string name, CancellationToken cancellationToken)
    {
      return base.RemoveTokenAsync(user, loginProvider, name, cancellationToken);
    }

    public override Task ReplaceClaimAsync(User user, Claim claim, Claim newClaim, CancellationToken cancellationToken = default)
    {
      return base.ReplaceClaimAsync(user, claim, newClaim, cancellationToken);
    }

    public override Task ReplaceCodesAsync(User user, IEnumerable<string> recoveryCodes, CancellationToken cancellationToken)
    {
      return base.ReplaceCodesAsync(user, recoveryCodes, cancellationToken);
    }

    public override Task ResetAccessFailedCountAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.ResetAccessFailedCountAsync(user, cancellationToken);
    }

    public override Task SetAuthenticatorKeyAsync(User user, string key, CancellationToken cancellationToken)
    {
      return base.SetAuthenticatorKeyAsync(user, key, cancellationToken);
    }

    public override Task SetEmailAsync(User user, string email, CancellationToken cancellationToken = default)
    {
      return base.SetEmailAsync(user, email, cancellationToken);
    }

    public override Task SetEmailConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken = default)
    {
      return base.SetEmailConfirmedAsync(user, confirmed, cancellationToken);
    }

    public override Task SetLockoutEnabledAsync(User user, bool enabled, CancellationToken cancellationToken = default)
    {
      return base.SetLockoutEnabledAsync(user, enabled, cancellationToken);
    }

    public override Task SetLockoutEndDateAsync(User user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken = default)
    {
      return base.SetLockoutEndDateAsync(user, lockoutEnd, cancellationToken);
    }

    public override Task SetNormalizedEmailAsync(User user, string normalizedEmail, CancellationToken cancellationToken = default)
    {
      return base.SetNormalizedEmailAsync(user, normalizedEmail, cancellationToken);
    }

    public override Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken = default)
    {
      return base.SetNormalizedUserNameAsync(user, normalizedName, cancellationToken);
    }

    public override Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken = default)
    {
      return base.SetPasswordHashAsync(user, passwordHash, cancellationToken);
    }

    public override Task SetPhoneNumberAsync(User user, string phoneNumber, CancellationToken cancellationToken = default)
    {
      return base.SetPhoneNumberAsync(user, phoneNumber, cancellationToken);
    }

    public override Task SetPhoneNumberConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken = default)
    {
      return base.SetPhoneNumberConfirmedAsync(user, confirmed, cancellationToken);
    }

    public override Task SetSecurityStampAsync(User user, string stamp, CancellationToken cancellationToken = default)
    {
      return base.SetSecurityStampAsync(user, stamp, cancellationToken);
    }

    public override Task SetTokenAsync(User user, string loginProvider, string name, string value, CancellationToken cancellationToken)
    {
      return base.SetTokenAsync(user, loginProvider, name, value, cancellationToken);
    }

    public override Task SetTwoFactorEnabledAsync(User user, bool enabled, CancellationToken cancellationToken = default)
    {
      return base.SetTwoFactorEnabledAsync(user, enabled, cancellationToken);
    }

    public override Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken = default)
    {
      return base.SetUserNameAsync(user, userName, cancellationToken);
    }

    public override string ToString()
    {
      return base.ToString();
    }

    public override Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken = default)
    {
      return base.UpdateAsync(user, cancellationToken);
    }

    protected override Task AddUserTokenAsync(UserToken token)
    {
      return base.AddUserTokenAsync(token);
    }

    protected override UserClaim CreateUserClaim(User user, Claim claim)
    {
      var userClaim = new UserClaim { UserId = user.Id };
      userClaim.InitializeFromClaim(claim);
      return userClaim;

    }

    protected override UserLogin CreateUserLogin(User user, UserLoginInfo login)
    {
      return new UserLogin
      {
        UserId = user.Id,
        ProviderKey = login.ProviderKey,
        LoginProvider = login.LoginProvider,
        ProviderDisplayName = login.ProviderDisplayName
      };
    }

    protected override UserRole CreateUserRole(User user, Role role)
    {
      return new UserRole
      {
        UserId = user.Id,
        RoleId = role.Id
      };
    }

    protected override UserToken CreateUserToken(User user, string loginProvider, string name, string value)
    {
      return new UserToken
      {
        UserId = user.Id,
        LoginProvider = loginProvider,
        Name = name,
        Value = value
      };
    }

    protected override Task<Role> FindRoleAsync(string normalizedRoleName, CancellationToken cancellationToken)
    {
      return base.FindRoleAsync(normalizedRoleName, cancellationToken);
    }

    protected override Task<UserToken> FindTokenAsync(User user, string loginProvider, string name, CancellationToken cancellationToken)
    {
      return base.FindTokenAsync(user, loginProvider, name, cancellationToken);
    }

    protected override Task<User> FindUserAsync(Guid userId, CancellationToken cancellationToken)
    {
      return base.FindUserAsync(userId, cancellationToken);
    }

    protected override Task<UserLogin> FindUserLoginAsync(Guid userId, string loginProvider, string providerKey, CancellationToken cancellationToken)
    {
      return base.FindUserLoginAsync(userId, loginProvider, providerKey, cancellationToken);
    }

    protected override Task<UserLogin> FindUserLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
    {
      return base.FindUserLoginAsync(loginProvider, providerKey, cancellationToken);
    }

    protected override Task<UserRole> FindUserRoleAsync(Guid userId, Guid roleId, CancellationToken cancellationToken)
    {
      return base.FindUserRoleAsync(userId, roleId, cancellationToken);
    }

    protected override Task RemoveUserTokenAsync(UserToken token)
    {
      return base.RemoveUserTokenAsync(token);
    }
  }
}