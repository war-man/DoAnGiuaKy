#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715faff88ff5bdebe6b074bd9a369073c5d1843e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715faff88ff5bdebe6b074bd9a369073c5d1843e", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication8.Models.WebShop.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:60px; border:1px solid #ececec"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/LoadDataTable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/ModelPopup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/CheckAll.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(162, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 10 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(205, 152, true);
            WriteLiteral("<div> <a href=\"/Admin/Products/Insert\" class=\"btn btn-success btn-lg\" id=\"create-supplier\"> Create New <i class=\"fa fa-plus icon-white\"></i></a></div>\r\n");
            EndContext();
#line 14 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(387, 213, true);
            WriteLiteral("    <table class=\"table\" id=\"domainTable\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    <input type=\"checkbox\" id=\"check-all-header\" />\r\n                </th>\r\n                <th>");
            EndContext();
            BeginContext(601, 30, false);
#line 22 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(631, 49, true);
            WriteLiteral("</th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(681, 32, false);
#line 24 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(713, 45, true);
            WriteLiteral("\r\n                </th>\r\n                <th>");
            EndContext();
            BeginContext(759, 34, false);
#line 26 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.PriceP));

#line default
#line hidden
            EndContext();
            BeginContext(793, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(821, 33, false);
#line 27 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Image));

#line default
#line hidden
            EndContext();
            BeginContext(854, 96, true);
            WriteLiteral("</th>\r\n                <th>Action</th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 33 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1007, 79, true);
            WriteLiteral("                <tr>\r\n                    <td><input type=\"checkbox\" name=\"ids\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1086, "\"", 1102, 1);
#line 36 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 1094, item.Id, 1094, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1103, 34, true);
            WriteLiteral(" /></td>\r\n                    <td>");
            EndContext();
            BeginContext(1138, 29, false);
#line 37 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1199, 31, false);
#line 38 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1288, 51, false);
#line 40 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Convert.ToDecimal(item.PriceP).ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1384, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8eb73e4dfd774d82b67656e01dc3bb0b", async() => {
                BeginContext(1427, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1428, 177, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19ad583795be4d3984f8cfa9ab47c297", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1438, "~/Content/img/products/images/", 1438, 30, true);
#line 42 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1468, item.Image, 1468, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
                WriteLiteral("/Content/img/products/images/");
#line 42 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
                                                                                                                                                        Write(item.Image);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-echo", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1605, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1393, "~/Admin/Products/Detail/", 1393, 24, true);
#line 42 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 1417, item.Id, 1417, 8, false);

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
            BeginContext(1610, 31, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n");
            EndContext();
            BeginContext(1795, 46, true);
            WriteLiteral("                    <button id=\"supplier-edit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1841, "\"", 1939, 7);
            WriteAttributeValue("", 1851, "form.action", 1851, 11, true);
            WriteAttributeValue(" ", 1862, "=", 1863, 2, true);
            WriteAttributeValue(" ", 1864, "\'", 1865, 2, true);
#line 46 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 1866, Url.RouteUrl(new {controller="/",area="" }), 1866, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 1910, "Admin/Products/Edit/", 1910, 20, true);
#line 46 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 1930, item.Id, 1930, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1938, "\'", 1938, 1, true);
            EndWriteAttribute();
            BeginContext(1940, 84, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\"><i class=\"fa fa-pencil icon-white\"></i></button>\r\n\r\n");
            EndContext();
            BeginContext(2293, 86, true);
            WriteLiteral("\r\n                    <button type=\"button\" class=\"btn delete-asset btn-danger btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2379, "\"", 2479, 7);
            WriteAttributeValue("", 2389, "form.action", 2389, 11, true);
            WriteAttributeValue(" ", 2400, "=", 2401, 2, true);
            WriteAttributeValue(" ", 2402, "\'", 2403, 2, true);
#line 50 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2404, Url.RouteUrl(new {controller="/",area="" }), 2404, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 2448, "Admin/Products/Delete/", 2448, 22, true);
#line 50 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2470, item.Id, 2470, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2478, "\'", 2478, 1, true);
            EndWriteAttribute();
            BeginContext(2480, 74, true);
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#confirmDelete\" data-title=\"Delete item ");
            EndContext();
            BeginContext(2555, 7, false);
#line 50 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
                                                                                                                                                                                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2562, 53, true);
            WriteLiteral("\" data-message=\"Are you sure you want to delete item ");
            EndContext();
            BeginContext(2616, 7, false);
#line 50 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
                                                                                                                                                                                                                                                                                                                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2623, 152, true);
            WriteLiteral(" ?\">\r\n                        <i class=\"glyphicon glyphicon-trash\"></i>\r\n                    </button>\r\n                    <button id=\"supplier-detail\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2775, "\"", 2875, 7);
            WriteAttributeValue("", 2785, "form.action", 2785, 11, true);
            WriteAttributeValue(" ", 2796, "=", 2797, 2, true);
            WriteAttributeValue(" ", 2798, "\'", 2799, 2, true);
#line 53 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2800, Url.RouteUrl(new {controller="/",area="" }), 2800, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 2844, "Admin/Products/Detail/", 2844, 22, true);
#line 53 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2866, item.Id, 2866, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2874, "\'", 2874, 1, true);
            EndWriteAttribute();
            BeginContext(2876, 110, true);
            WriteLiteral(" class=\"btn btn-info btn-sm\"><i class=\"fa fa-info\"></i></button>\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2997, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
            BeginContext(3031, 348, true);
            WriteLiteral(@"    <button class=""btn btn-lg btn-danger"" type=""button"" onclick=""form.action = '/Admin/Products/DeleteSelected'"" data-toggle=""modal"" data-target=""#confirmDelete"" data-title=""Delete item item"" data-message=""Are you sure you want to delete selected item ?"">
        Delete Selected
        <i class=""glyphicon glyphicon-trash""></i>
    </button>
");
            EndContext();
#line 65 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3385, 38, false);
#line 66 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
Write(await Html.PartialAsync("_ModelPopup"));

#line default
#line hidden
            EndContext();
#line 66 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Products\Index.cshtml"
                                         ; 

#line default
#line hidden
            BeginContext(3428, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3447, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3453, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2a965cba4494c299c3407715cb6a059", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3503, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3509, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3ceacab4c99427ea6dc38a899381ee0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3556, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3562, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8680cd47acb4d518351103bcdc96695", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3607, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication8.Models.WebShop.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591