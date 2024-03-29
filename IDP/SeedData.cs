﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using System.Linq;
using System.Security.Claims;
using IdentityModel;
using IDP.Data;
using IDP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace IDP
{
  public class SeedData
  {
    public static void EnsureSeedData(string connectionString)
    {
      var services = new ServiceCollection();
      services.AddLogging();
      services.AddDbContext<ApplicationDbContext>(options =>
         options.UseSqlServer(connectionString));

      services.AddScoped<UserStore<User, Role, ApplicationDbContext, Guid, UserClaim, UserRole, UserLogin, UserToken, RoleClaim>, ApplicationUserStore>();
      services.AddScoped<UserManager<User>, ApplicationUserManager>();
      services.AddScoped<RoleManager<Role>, ApplicationRoleManager>();
      services.AddScoped<SignInManager<User>, ApplicationSignInManager>();
      services.AddScoped<RoleStore<Role, ApplicationDbContext, Guid, UserRole, RoleClaim>, ApplicationRoleStore>();

      services.AddIdentity<User, Role>(identityOptions =>
      {

      })
      .AddUserStore<ApplicationUserStore>()
      .AddUserManager<ApplicationUserManager>()
      .AddRoleStore<ApplicationRoleStore>()
      .AddRoleManager<ApplicationRoleManager>()
      .AddSignInManager<ApplicationSignInManager>()
      .AddDefaultTokenProviders();

      using (var serviceProvider = services.BuildServiceProvider())
      {
        using (var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
          var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
          context.Database.Migrate();

          var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
          var alice = userMgr.FindByNameAsync("alice").Result;
          if (alice == null)
          {
            alice = new User
            {
              UserName = "alice",
              Email = "AliceSmith@email.com",
              EmailConfirmed = true,
            };
            var result = userMgr.CreateAsync(alice, "Pass123$").Result;
            if (!result.Succeeded)
            {
              throw new Exception(result.Errors.First().Description);
            }

            result = userMgr.AddClaimsAsync(alice, new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Alice Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Alice"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                        }).Result;
            if (!result.Succeeded)
            {
              throw new Exception(result.Errors.First().Description);
            }
            Log.Debug("alice created");
          }
          else
          {
            Log.Debug("alice already exists");
          }

          var bob = userMgr.FindByNameAsync("bob").Result;
          if (bob == null)
          {
            bob = new User
            {
              UserName = "bob",
              Email = "BobSmith@email.com",
              EmailConfirmed = true
            };
            var result = userMgr.CreateAsync(bob, "Pass123$").Result;
            if (!result.Succeeded)
            {
              throw new Exception(result.Errors.First().Description);
            }

            result = userMgr.AddClaimsAsync(bob, new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Bob Smith"),
                            new Claim(JwtClaimTypes.GivenName, "Bob"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                            new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                            new Claim("location", "somewhere")
                        }).Result;
            if (!result.Succeeded)
            {
              throw new Exception(result.Errors.First().Description);
            }
            Log.Debug("bob created");
          }
          else
          {
            Log.Debug("bob already exists");
          }
        }
      }
    }
  }
}
