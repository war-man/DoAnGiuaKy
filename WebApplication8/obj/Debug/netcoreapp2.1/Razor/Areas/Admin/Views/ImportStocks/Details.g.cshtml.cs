#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "600bc933ccac748c2f4210e3767f267629aac03d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ImportStocks_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ImportStocks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ImportStocks/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_ImportStocks_Details))]
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
#line 1 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600bc933ccac748c2f4210e3767f267629aac03d", @"/Areas/Admin/Views/ImportStocks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ImportStocks_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication8.Models.WebShop.ImportStock>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>ImportStock</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(281, 46, false);
#line 15 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(371, 42, false);
#line 18 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(457, 48, false);
#line 21 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DetailImport));

#line default
#line hidden
            EndContext();
            BeginContext(505, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(549, 44, false);
#line 24 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.DetailImport));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(637, 44, false);
#line 27 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(681, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(725, 40, false);
#line 30 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(809, 43, false);
#line 33 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdStock));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(896, 39, false);
#line 36 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdStock));

#line default
#line hidden
            EndContext();
            BeginContext(935, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(979, 40, false);
#line 39 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lack));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1063, 36, false);
#line 42 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lack));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1143, 41, false);
#line 45 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1228, 37, false);
#line 48 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1309, 41, false);
#line 51 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Payed));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1394, 37, false);
#line 54 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Payed));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1475, 45, false);
#line 57 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentMt));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1564, 41, false);
#line 60 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaymentMt));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1649, 42, false);
#line 63 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1735, 38, false);
#line 66 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1817, 41, false);
#line 69 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1902, 37, false);
#line 72 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1983, 43, false);
#line 75 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2070, 39, false);
#line 78 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2153, 44, false);
#line 81 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserInit));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2241, 40, false);
#line 84 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserInit));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2325, 43, false);
#line 87 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserUpd));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2412, 39, false);
#line 90 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserUpd));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2498, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ed4221d5fd4261a102698291fbbf65", async() => {
                BeginContext(2544, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\ImportStocks\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2552, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2560, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca8538fb9eef4529affc026fa16e0a37", async() => {
                BeginContext(2582, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2598, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication8.Models.WebShop.ImportStock> Html { get; private set; }
    }
}
#pragma warning restore 1591
