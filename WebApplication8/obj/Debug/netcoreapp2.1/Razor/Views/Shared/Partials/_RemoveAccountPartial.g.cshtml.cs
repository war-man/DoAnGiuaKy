#pragma checksum "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968ddced253895f880c4eb8e9ea23455d0f960b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__RemoveAccountPartial), @"mvc.1.0.view", @"/Views/Shared/Partials/_RemoveAccountPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partials/_RemoveAccountPartial.cshtml", typeof(AspNetCore.Views_Shared_Partials__RemoveAccountPartial))]
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
#line 1 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968ddced253895f880c4eb8e9ea23455d0f960b0", @"/Views/Shared/Partials/_RemoveAccountPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__RemoveAccountPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Microsoft.AspNetCore.Identity.UserLoginInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(93, 76, true);
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 8 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
             foreach (var account in Model)
            {

#line default
#line hidden
            BeginContext(229, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(276, 21, false);
#line 11 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
                   Write(account.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(297, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 13 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
                         if (ViewBag.ShowRemoveButton)
                        {
                            using (Html.BeginForm("Disassociate", "Account"))
                            {
                                

#line default
#line hidden
            BeginContext(556, 23, false);
#line 17 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(581, 75, true);
            WriteLiteral("                                <div>\r\n                                    ");
            EndContext();
            BeginContext(657, 51, false);
#line 19 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
                               Write(Html.Hidden("loginProvider", account.LoginProvider));

#line default
#line hidden
            EndContext();
            BeginContext(708, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(747, 47, false);
#line 20 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
                               Write(Html.Hidden("providerKey", account.ProviderKey));

#line default
#line hidden
            EndContext();
            BeginContext(794, 97, true);
            WriteLiteral("\r\n                                    <input type=\"submit\" class=\"btn btn-default\" value=\"Remove\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 891, "\"", 957, 7);
            WriteAttributeValue("", 899, "Remove", 899, 6, true);
            WriteAttributeValue(" ", 905, "this", 906, 5, true);
#line 21 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
WriteAttributeValue(" ", 910, account.LoginProvider, 911, 22, false);

#line default
#line hidden
            WriteAttributeValue(" ", 933, "login", 934, 6, true);
            WriteAttributeValue(" ", 939, "from", 940, 5, true);
            WriteAttributeValue(" ", 944, "your", 945, 5, true);
            WriteAttributeValue(" ", 949, "account", 950, 8, true);
            EndWriteAttribute();
            BeginContext(958, 45, true);
            WriteLiteral(" />\r\n                                </div>\r\n");
            EndContext();
#line 23 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1118, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1148, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 28 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
                        }

#line default
#line hidden
            BeginContext(1184, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(1249, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 34 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Partials\_RemoveAccountPartial.cshtml"
}

#line default
#line hidden
            BeginContext(1284, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CustomerIdentity CustomerIdentity { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Global { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Microsoft.AspNetCore.Identity.UserLoginInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
