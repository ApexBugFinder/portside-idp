#pragma checksum "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "555f25f81b00c9c818bd654ab5e4479eeb4d0431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
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
#line 1 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Consent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Device;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Grants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/_ViewImports.cshtml"
using IDP.Controllers.Landing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"555f25f81b00c9c818bd654ab5e4479eeb4d0431", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf01ea518b9c022a420579740f195eead9528b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IDP.Controllers.Consent.ScopeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 204, "\"", 244, 2);
            WriteAttributeValue("", 225, "scopes_", 225, 7, true);
#nullable restore
#line 8 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
WriteAttributeValue("", 232, Model.Value, 232, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 245, "\"", 281, 1);
#nullable restore
#line 9 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
WriteAttributeValue("", 269, Model.Value, 269, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 282, "\"", 322, 1);
#nullable restore
#line 10 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
WriteAttributeValue("", 308, Model.Checked, 308, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 323, "\"", 365, 1);
#nullable restore
#line 11 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
WriteAttributeValue("", 350, Model.Required, 350, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 487, "\"", 527, 1);
#nullable restore
#line 16 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
WriteAttributeValue("", 515, Model.Value, 515, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 915, "\"", 940, 2);
            WriteAttributeValue("", 921, "scopes_", 921, 7, true);
#nullable restore
#line 31 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
WriteAttributeValue("", 928, Model.Value, 928, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "/home/apexbugfinder/portfolio/portsideidp/IDP/Views/Shared/_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IDP.Controllers.Consent.ScopeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
