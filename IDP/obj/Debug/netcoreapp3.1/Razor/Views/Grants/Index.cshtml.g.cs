#pragma checksum "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be6d6916c7519c7c3e3c3fd6310f64c78c039197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grants_Index), @"mvc.1.0.view", @"/Views/Grants/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Consent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Device;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Grants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6d6916c7519c7c3e3c3fd6310f64c78c039197", @"/Views/Grants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8470a1c5783ac756b64f646ebfbdedb78dd34058", @"/Views/_ViewImports.cshtml")]
    public class Views_Grants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IDP.Controllers.Grants.GrantsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Revoke", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"grants-page\">\r\n    <div class=\"lead\">\r\n        <h1>Client Application Permissions</h1>\r\n        <p>Below is the list of applications you have given permission to and the resources they have access to.</p>\r\n    </div>\r\n\r\n");
#nullable restore
#line 9 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
     if (Model.Grants.Any() == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                <div class=\"alert alert-info\">\r\n                    You have not given access to any applications\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 18 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
    }
    else
    {
        foreach (var grant in Model.Grants)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-header\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-8 card-title\">\r\n");
#nullable restore
#line 27 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                             if (grant.ClientLogoUrl != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 948, "\"", 974, 1);
#nullable restore
#line 29 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
WriteAttributeValue("", 954, grant.ClientLogoUrl, 954, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 30 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <strong>");
#nullable restore
#line 31 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                               Write(grant.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </div>\r\n\r\n                        <div class=\"col-sm-2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6d6916c7519c7c3e3c3fd6310f64c78c0391977287", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"clientId\"");
                BeginWriteAttribute("value", " value=\"", 1279, "\"", 1302, 1);
#nullable restore
#line 36 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
WriteAttributeValue("", 1287, grant.ClientId, 1287, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <button class=\"btn btn-danger\">Revoke Access</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 44 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                     if (grant.Description != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>Description:</label> ");
#nullable restore
#line 47 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                                   Write(grant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 49 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <label>Created:</label> ");
#nullable restore
#line 51 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                           Write(grant.Created.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 53 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                     if (grant.Expires.HasValue)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>Expires:</label> ");
#nullable restore
#line 56 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                               Write(grant.Expires.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 58 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                     if (grant.IdentityGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>Identity Grants</label>\r\n                            <ul>\r\n");
#nullable restore
#line 64 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                 foreach (var name in grant.IdentityGrantNames)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 66 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 67 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 70 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                     if (grant.ApiGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <label>API Grants</label>\r\n                            <ul>\r\n");
#nullable restore
#line 76 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                 foreach (var name in grant.ApiGrantNames)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 78 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 79 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 82 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 85 "/home/apexbugfinder/Documents/codePractice/portfolio/Portfolio/portfolioIDP/idp-generic-v1c/IDP/Views/Grants/Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IDP.Controllers.Grants.GrantsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
