#pragma checksum "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb47e5c01d27fbedce63097818034ca660666595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__Category), @"mvc.1.0.view", @"/Views/Shared/Partials/_Category.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partials/_Category.cshtml", typeof(AspNetCore.Views_Shared_Partials__Category))]
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
#line 1 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
#line 1 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
using WebApplication8.Models.WebShop;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb47e5c01d27fbedce63097818034ca660666595", @"/Views/Shared/Partials/_Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(96, 118, true);
            WriteLiteral("\r\n\r\n<!-- ============================================== SIDEBAR ============================================== -->\r\n\r\n");
            EndContext();
            BeginContext(270, 241, true);
            WriteLiteral("\r\n\r\n\r\n    <!-- ================================== TOP NAVIGATION ================================== -->\r\n\r\n    <div class=\"side-menu animate-dropdown outer-bottom-xs\">\r\n        <div class=\"head\"><i class=\"icon fa fa-align-justify fa-fw\"></i>");
            EndContext();
            BeginContext(533, 18, true);
            WriteLiteral("Categories</div>\r\n");
            EndContext();
#line 16 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
         foreach (var item in Model)
        {




#line default
#line hidden
            BeginContext(606, 167, true);
            WriteLiteral("        <nav class=\"yamm megamenu-horizontal\" role=\"navigation\">\r\n            <ul class=\"nav\">\r\n                <li class=\"dropdown menu-item\">\r\n                    \r\n");
            EndContext();
#line 25 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
                  
                        // var Language = System.Threading.Thread.CurrentThread.CurrentCulture.DisplayName;
                        var Language = "English";
                        switch (Language)
                        {
                            case "English":

#line default
#line hidden
            BeginContext(1068, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1088, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a09d7cf0a31445d9b696663476436ea", async() => {
                BeginContext(1132, 2, true);
                WriteLiteral("<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1134, "\"", 1157, 2);
                WriteAttributeValue("", 1142, "icon", 1142, 4, true);
#line 31 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
WriteAttributeValue(" ", 1146, item.Icon, 1147, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1158, 5, true);
                WriteLiteral("></i>");
                EndContext();
                BeginContext(1164, 9, false);
#line 31 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
                                                                                          Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1097, "~/Product/Cat/", 1097, 14, true);
#line 31 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
AddHtmlAttributeValue("", 1111, item.Id, 1111, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1119, "/", 1119, 1, true);
#line 31 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
AddHtmlAttributeValue("", 1120, item.Name, 1120, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
                        break;
                  default:

#line default
#line hidden
            BeginContext(1239, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1259, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07405f45a7a842c89f5673431af4603e", async() => {
                BeginContext(1305, 2, true);
                WriteLiteral("<i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1307, "\"", 1330, 2);
                WriteAttributeValue("", 1315, "icon", 1315, 4, true);
#line 34 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
WriteAttributeValue(" ", 1319, item.Icon, 1320, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1331, 5, true);
                WriteLiteral("></i>");
                EndContext();
                BeginContext(1337, 11, false);
#line 34 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
                                                                                            Write(item.NameVN);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1268, "~/Product/Cat/", 1268, 14, true);
#line 34 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
AddHtmlAttributeValue("", 1282, item.Id, 1282, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1290, "/", 1290, 1, true);
#line 34 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
AddHtmlAttributeValue("", 1291, item.NameVN, 1291, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1352, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
                        break;

                    }
                    

#line default
#line hidden
            BeginContext(1438, 138, true);
            WriteLiteral("                </li><!-- /.menu-item -->\r\n\r\n            \r\n            </ul><!-- /.nav -->\r\n        </nav><!-- /.megamenu-horizontal -->\r\n");
            EndContext();
#line 44 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Shared\Partials\_Category.cshtml"
        }

#line default
#line hidden
            BeginContext(1587, 161, true);
            WriteLiteral("    </div><!-- /.side-menu -->\r\n\r\n  \r\n    <!-- ============================================== COLOR: END ============================================== -->\r\n\r\n\r\n");
            EndContext();
            BeginContext(1758, 144, true);
            WriteLiteral("<!-- /.sidemenu-holder -->\r\n<!-- ============================================== SIDEBAR : END ============================================== -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
