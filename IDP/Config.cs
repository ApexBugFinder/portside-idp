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


         new Secret("F6:F9:6C:64:C4:82:42:6F:1F:0E:16:BA:30:FF:8C:04:A0:BB:BD:9D")
                    {

                            Type = IdentityServerConstants.SecretTypes.X509CertificateThumbprint
                    },

    },
},

            new Client
            {
                ClientId = "portfoliofront",
                ClientName = "Portfolio Client",
                ClientUri = "http://23.94.40.225:3000",

                AllowedGrantTypes = GrantTypes.Implicit,
                PostLogoutRedirectUris = new List<string> { "http://23.94.40.225:3000/" },
                AllowedScopes = new List<string> {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    "portfoliowebapi", "mtls"},
                RedirectUris = new List<string> { "http://23.94.40.225:3000", "https://23.94.40.225:3000", "https://identity.portside.cyou",
                "https://portside.cyou/#/auth/auth-callback","https://portside.cyou/#/auth/auth-callback/", "https://portside.cyou/#/auth/auth-callback/?",
                "https://portside.cyou/auth/auth-callback","https://portside.cyou/auth/auth-callback/", "https://portside.cyou/auth/auth-callback/?",
                "http://23.94.40.225:3000/auth/auth-callback", "https://23.94.40.225:4200/auth/auth-callback", "https://23.94.40.225:8085"},
                AllowedCorsOrigins = new List<string> {
                        "https://23.94.40.225",   //Client
                        "https://portside.cyou",


                        "https://23.94.40.225:8000",     // IDP
                            "https://identity.portside.cyou",
                            "http://identity.portside.cyou",
                        "https://23.94.40.225:8085",   // WEB API
                        "https://webapi.portside.cyou",
                        "http://webapi.portside.cyou"
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