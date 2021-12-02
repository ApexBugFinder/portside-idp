// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IDP.Data;
using IDP.Abstract;
using IDP.Concrete;
using IDP.Models;
using IDP.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Security;
using System.Net;
using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace IDP
{
  public class Startup
  {
    public IWebHostEnvironment Environment { get; }
    public IConfiguration Configuration { get; }
    public readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
    public readonly string MustOwnProject = "_mustOwnProject";
    public Startup(IWebHostEnvironment environment)
    {
      // var builder = new ConfigurationBuilder()
      //     .SetBasePath(environment.ContentRootPath)
      //     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
      //     .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
      //     .AddEnvironmentVariables();
      Environment = environment;
      // Configuration = builder.Build();
    //   var certificateSettings = Configuration.GetSection("Certificates.Production");
    //   X509Certificate2 cert = new X509Certificate2("/https/identity.pfx", "password");
    // cert.FriendlyName = "identity";
    //   X509Store store = new X509Store("idpStore", StoreLocation.LocalMachine);
    //   store.Open(OpenFlags.ReadWrite);

    // if(!store.Certificates.Contains(cert)) {
    //   store.Add(cert);
    // }
      // Helper.certFileName = certificateSettings.GetValue<string>("Production.Identity.Filename");
      // Helper.certFilePath= certificateSettings.GetValue<string>("Production.Identity.Path");
      // Helper.certPassword = certificateSettings.GetValue<string>("Production.Identity.Password");

    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.Configure<CookiePolicyOptions>(options =>
      {
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.Lax;
      });



      services.AddControllersWithViews();


      services.Configure<ForwardedHeadersOptions>(options => {
        options.ForwardLimit = 2;
        // options.KnownProxies.Add(IPAddress.Parse("identity.portside.sbs"));
        options.KnownProxies.Add(IPAddress.Parse("198.211.29.93"));
        // options.KnownProxies.Add(IPAddress.Parse("198.211.29.93:8000"));
        options.ForwardedForHeaderName = "X-Forwarded-For-Identity-Portside";
      });


      services.AddCertificateForwarding(options =>
      {
        options.CertificateHeader = "X-SSL-CERT";
        options.HeaderConverter = (headerValue) =>
        {
          X509Certificate2 clientCertificate = null;
          if (!string.IsNullOrWhiteSpace(headerValue))
          {
            var bytes = Encoding.UTF8.GetBytes(Uri.UnescapeDataString(headerValue));
            clientCertificate = new X509Certificate2(bytes);


          }
          return clientCertificate;
        };
      });


      services.AddCors(options =>
      {
        options.AddPolicy(MyAllowSpecificOrigins,
        builder =>
        {
          builder.WithOrigins(
                // Web API

                "https://identity.portside.sbs", "https://198.211.29.93:8000", // IDP

                "http://webapi.portside.sbs","https://198.211.29.93:8085", "https://webapi.portside.sbs", "http://198.211.29.93:8086", // WEBAPI

                "http://localhost:3000", "https://198.211.29.93",  // FRONT
                "https://portside.sbs"
            )
              .AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
        });
      });


      var connectStrg =Helper.GetConnectionString;
      services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(
            // Configuration.GetConnectionString("ConnectionStrings.DefaultConnection")
            connectStrg
            )
            );

      services.AddScoped<IUserRepository, UserRepository>();



      services.AddMvc(options => options.EnableEndpointRouting = false)
        .AddRazorPagesOptions(options =>
        {
            options.Conventions.AddPageRoute("/Landing/Index", "");
        });


      services.AddScoped<UserStore<User, Role, ApplicationDbContext, Guid, UserClaim, UserRole, UserLogin, UserToken, RoleClaim>, ApplicationUserStore>();
      services.AddScoped<UserManager<User>, ApplicationUserManager>();
      services.AddScoped<RoleManager<Role>, ApplicationRoleManager>();
      services.AddScoped<SignInManager<User>, ApplicationSignInManager>();
      services.AddScoped<RoleStore<Role, ApplicationDbContext, Guid, UserRole, RoleClaim>, ApplicationRoleStore>();

      services.AddIdentity<User, Role>(identityOptions => {

      })
      .AddUserStore<ApplicationUserStore>()
      .AddUserManager<ApplicationUserManager>()
      .AddRoleStore<ApplicationRoleStore>()
      .AddRoleManager<ApplicationRoleManager>()
      .AddSignInManager<ApplicationSignInManager>()
      .AddDefaultTokenProviders();

      var builder = services.AddIdentityServer(options =>
      {
        options.Events.RaiseErrorEvents = true;
        options.Events.RaiseInformationEvents = true;
        options.Events.RaiseFailureEvents = true;
        options.Events.RaiseSuccessEvents = true;
        options.MutualTls.Enabled = true;
        options.MutualTls.ClientCertificateAuthenticationScheme = "Certificate";
        options.MutualTls.DomainName = "mtls";



      }).AddInMemoryIdentityResources(Config.IdentityResources)

                      .AddInMemoryApiScopes(Config.ApiScopes)
                      .AddInMemoryClients(Config.Clients)
                      .AddDeveloperSigningCredential()
                      .AddMutualTlsSecretValidators();
      ;
      services.AddAuthorization();
      builder.AddMutualTlsSecretValidators();

      // var builder = services.AddIdentityServer(options =>
      // {
      //     // options.Events.RaiseErrorEvents = true;
      //     // options.Events.RaiseInformationEvents = true;
      //     // options.Events.RaiseFailureEvents = true;
      //     // options.Events.RaiseSuccessEvents = true;

      //     // see https://identityserver4.readthedocs.io/en/latest/topics/resources.html
      //     // options.EmitStaticAudienceClaim = true;
      // })
      //     .AddInMemoryIdentityResources(Config.IdentityResources)
      //     .AddInMemoryApiScopes(Config.ApiScopes)
      //     .AddInMemoryClients(Config.Clients);

      // // not recommended for production - you need to store your key material somewhere secure
      // builder.AddDeveloperSigningCredential();

      //   JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
      //   services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
      //     .AddJwtBearer(options => {
      //         options.Authority = "https://198.211.29.93:44004";
      //         options.Audience  = "portfoliowebapi";
      //         options.RequireHttpsMetadata = false;
      //         options.TokenValidationParameters = new TokenValidationParameters()
      //         {
      //             ValidateLifetime = false,
      //             ValidateIssuer = false,
      //             ValidateAudience = false
      //         };
      //     })
      // services.AddDatabaseDeveloperPageExceptionFilter();
      // services.AddAuthentication(options => {
      //     options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
      //     options.DefaultChallengeScheme = "oidc";
      //     }).AddCookie("Cookies")
      // .AddOpenIdConnect(options => {
      // options.SignInScheme = "Cookies";

      // options.Authority = "https://identity.portside.sbs";
      // options.RequireHttpsMetadata = false;

      // options.ClientId = "portfoliofront";
      // options.SaveTokens = true;
      // });
          services.AddAuthentication(options => {
              options.DefaultScheme = "Cookies";
              options.DefaultChallengeScheme = "oidc";
          }).AddCookie("Cookies")
              .AddGoogle("Google", options => {
          options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
          options.CallbackPath = "/signin-google";
          options.ClientId = "896122756583-u21hkavku4lf10sa3au0n34glgpljbv5.apps.googleusercontent.com";
          options.ClientSecret = "J88zp-p3XS0-jDfNraNlW3tI";
      });


      // services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme)
      //    .AddCertificate(options =>
      //    {

      //      options.AllowedCertificateTypes = CertificateTypes.All;
      //      options.RevocationMode = X509RevocationMode.NoCheck;

      //      options.Events = new CertificateAuthenticationEvents
      //      {
      //        OnCertificateValidated = context =>
      //        {
      //          var claims = new[] {
      //               new Claim(
      //                   ClaimTypes.NameIdentifier,
      //                   context.ClientCertificate.Subject,
      //                   ClaimValueTypes.String,
      //                   context.Options.ClaimsIssuer),
      //                   new Claim(ClaimTypes.Name,
      //                   context.ClientCertificate.Subject,
      //                   ClaimValueTypes.String,
      //                   context.Options.ClaimsIssuer)
      //         };
      //          context.Principal = new ClaimsPrincipal(new ClaimsIdentity(claims, context.Scheme.Name));
      //          context.Success();
      //          return Task.CompletedTask;
      //        }
      //      };
      //    }).AddGoogle("Google", options =>
      //         {

      //              options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
      //              options.ClientId = "896122756583-u21hkavku4lf10sa3au0n34glgpljbv5.apps.googleusercontent.com";
      //              options.ClientSecret = "J88zp-p3XS0-jDfNraNlW3tI";
      //           });





    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseForwardedHeaders();
      // app.UsePathBase("/");
      if (Environment.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseMigrationsEndPoint();
      }
      app.UseCors(MyAllowSpecificOrigins);
      app.UsePreflightRequestHandler();
      app.UseCookiePolicy();

      app.UseIdentityServer();

      app.UseStaticFiles();
      app.UseRouting();
      app.UseAuthentication();
    //   app.UseAuthorization();
     app.UseEndpoints(endpoints => {
         endpoints.MapControllerRoute(
             name: "default",
             pattern: "{controller}/{action}/{id?}",
             defaults: new { controller = "Landing", action = "Index" }
        );
     });

    // app.UseEndpoints(endpoints =>
    //         {
    //             endpoints.MapDefaultControllerRoute();
    //         });
    }
    // app.UseMvcWithDefaultRoute();
    //   app.UseMvc( d => d.MapRoute("default", "{controller=Landing}/{action=Index}"));
    // }
  }
}