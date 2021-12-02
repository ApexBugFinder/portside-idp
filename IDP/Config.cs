// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using IDP.Services;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace IDP
{
  public static class Config
  {

    public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),
                new IdentityResource("country", "the country you're living in", new List<string>() {"country"}),
                new IdentityResource("username", "what handle you go by", new List<string>() {"username" }),
                new IdentityResource("email", "your email is", new List<string>() {"email" })
            };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
                new ApiScope("portfoliowebapi", "Portfolio Web API", new List<string>() {"role"}),

                new ApiScope("mtls", "mtls"),
                new ApiScope("scope2"),
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
                // m2m client credentials flow client
           new Client
    {
    ClientId = "mtls",
    AllowedGrantTypes = GrantTypes.ClientCredentials,
    AllowedScopes = { "portfoliowebapi", "portfoliofront"},
    ClientSecrets =
    {


         new Secret("DE:B7:53:C3:AF:09:2F:E1:76:A2:1F:91:FD:E3:39:55:29:77:E8:78")
                    {

                            Type = IdentityServerConstants.SecretTypes.X509CertificateThumbprint
                    },

    },
},

            new Client
            {
                ClientId = "portfoliofront",
                ClientName = "Portfolio Client",
                ClientUri = "http://198.211.29.93:3000",

                AllowedGrantTypes = GrantTypes.Implicit,
                PostLogoutRedirectUris = new List<string> { "http://198.211.29.93:3000/" },
                AllowedScopes = new List<string> {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "portfoliowebapi", "mtls"},
                RedirectUris = new List<string> { "http://198.211.29.93:3000", "https://198.211.29.93:3000",
                "https://portside.sbs/#/auth/auth-callback","https://portside.sbs/#/auth/auth-callback/", "https://portside.sbs/#/auth/auth-callback/?",
                "https://portside.sbs/auth/auth-callback","https://portside.sbs/auth/auth-callback/", "https://portside.sbs/auth/auth-callback/?",
                "http://198.211.29.93:3000/auth/auth-callback", "https://198.211.29.93:4200/auth/auth-callback", "https://198.211.29.93:8085"},
                AllowedCorsOrigins = new List<string> {
                        "https://198.211.29.93",   //Client
                        "https://portside.sbs",


                        "https://198.211.29.93:8000",     // IDP
                            "https://identity.portside.sbs",
                            "http://identity.portside.sbs",
                        "https://198.211.29.93:8085",   // WEB API
                        "https://webapi.portside.sbs",
                        "http://webapi.portside.sbs"
                    },

                AllowAccessTokensViaBrowser = true,
                 ClientSecrets = {
                    new Secret("apisecret".Sha256())
                }

                // ClientSecrets = {
                //     new Secret("78:37:35:B8:55:58:F6:1B:50:4D:E1:1C:E5:EA:6F:63:27:C3:4D:6C") {

                //                                 Type = IdentityServerConstants.SecretTypes.X509CertificateThumbprint

                //                                 }


                // }
            }
    };
 }
}