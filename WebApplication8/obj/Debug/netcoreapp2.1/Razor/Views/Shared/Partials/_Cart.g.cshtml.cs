#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db431b5179434ad20e55804c20a636cecfca3ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__Cart), @"mvc.1.0.view", @"/Views/Shared/Partials/_Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partials/_Cart.cshtml", typeof(AspNetCore.Views_Shared_Partials__Cart))]
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
#line 1 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
#line 2 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
using WebApplication8.Models.ShoppingCart;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db431b5179434ad20e55804c20a636cecfca3ed", @"/Views/Shared/Partials/_Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication8.Models.WebShop.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove-from-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/img/icons/Trash.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Product/List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Order/Checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Cart/Clear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
  
    ViewBag.Title = "Shopping Cart ";

#line default
#line hidden
#line 6 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
 if(Model != null)
{

#line default
#line hidden
            BeginContext(174, 313, true);
            WriteLiteral(@"<div class=""col-xs-12 col-sm-12 col-md-9"">
    <table class=""table table-striped"">
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Unit Price</th>
            <th>Discount</th>
            <th>Quantity</th>
            <th>Amount</th>
            <th></th>
        </tr>
");
            EndContext();
#line 19 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
            BeginContext(533, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(572, 4, false);
#line 22 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
               Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(576, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(604, 6, false);
#line 23 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
               Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(610, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(638, 35, false);
#line 24 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
               Write(Html.FormatValue(p.PriceP, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(673, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(701, 37, false);
#line 25 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
               Write(Html.FormatValue(p.Discount, "{0:p}"));

#line default
#line hidden
            EndContext();
            BeginContext(738, 50, true);
            WriteLiteral("</td>\r\n                <td><input class=\"quantity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 788, "\"", 807, 1);
#line 26 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
WriteAttributeValue("", 796, p.Quantity, 796, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(808, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(819, 4, false);
#line 26 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
                                                                    Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(823, 37, true);
            WriteLiteral("\" size=\"3\"></td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 860, "\"", 870, 1);
#line 27 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
WriteAttributeValue("", 865, p.Id, 865, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(871, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(873, 67, false);
#line 27 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
                          Write(Html.FormatValue(p.PriceP * p.Quantity * (1 - p.Discount), "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(940, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(989, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e9e198c5098432db3f672da8b1102f4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 29 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
                                                      Write(p.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1073, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
        }

#line default
#line hidden
            BeginContext(1128, 118, true);
            WriteLiteral("        <tr>\r\n            <th colspan=\"5\" style=\"text-align:right\">Total:</th>\r\n            <th class=\"nn-cart-total\">");
            EndContext();
            BeginContext(1247, 18, false);
#line 35 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
                                 Write(ShoppingCart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1265, 63, true);
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </table>\r\n    ");
            EndContext();
            BeginContext(1328, 526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97f70724537f486db958ddd1635a810f", async() => {
                BeginContext(1370, 158, true);
                WriteLiteral("\r\n        <button class=\"btn btn-default\">\r\n            <span class=\"glyphicon glyphicon-th-list\"></span>\r\n            Clear Cart\r\n        </button>\r\n        ");
                EndContext();
                BeginContext(1528, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72d967776fdf4d27a244c63c412c648c", async() => {
                    BeginContext(1577, 100, true);
                    WriteLiteral("\r\n            <span class=\"glyphicon glyphicon-th-list\"></span>\r\n            Shopping More\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1681, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1691, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbd3409aebe04ed6a9d96c398b500170", async() => {
                    BeginContext(1742, 95, true);
                    WriteLiteral("\r\n            <span class=\"glyphicon glyphicon-th-list\"></span>\r\n            Checkout\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1841, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1854, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 54 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
}

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(1884, 330, true);
                WriteLiteral(@"
    <script>
            $(function () {
                // Xóa khỏi giỏ
                $("".remove-from-cart"").click(function () {
                    pid = $(this).attr(""data-id"");
                    tr = $(this).parents(""tr"");// tim <tr> chua <img> bi click
                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(2215, 54, false);
#line 63 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
                         Write(Url.RouteUrl(new {controller="Cart",action="Remove" }));

#line default
#line hidden
                EndContext();
                BeginContext(2269, 606, true);
                WriteLiteral(@"',
                        data: { id: pid },
                        success: function (response) {
                            $(""#nn-cart-count"").html(response.Count);
                            $("".nn-cart-total"").html(response.Total);
                            tr.hide(500);
                        }
                    });
                });
                // Cập nhật số lượng
                $("".quantity"").keyup(function () {
                    pid = $(this).attr(""data-id"");
                    qty = $(this).val();
                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(2876, 60, false);
#line 77 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Shared\Partials\_Cart.cshtml"
                         Write(Url.RouteUrl(new { controller = "Cart", action = "Update" }));

#line default
#line hidden
                EndContext();
                BeginContext(2936, 429, true);
                WriteLiteral(@"',
                        data: { id: pid, quantity: qty },
                        success: function (response) {
                            $(""#nn-cart-count"").html(response.Count);
                            $("".nn-cart-total"").html(response.Total);
                            $(""#"" + pid).html(response.Name);
                        }
                    });
                });
            });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3368, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication8.Models.WebShop.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591