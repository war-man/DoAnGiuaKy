#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf0df77e84215a6ab14d7f500fa4884081388ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cat), @"mvc.1.0.view", @"/Views/Product/Cat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Cat.cshtml", typeof(AspNetCore.Views_Product_Cat))]
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
#line 1 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
using WebApplication8.Models.WebShop;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf0df77e84215a6ab14d7f500fa4884081388ddf", @"/Views/Product/Cat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Cat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
  
    ViewBag.Title = "Category";

#line default
#line hidden
            BeginContext(109, 191, true);
            WriteLiteral("\r\n\r\n    <!-- ============================================== FEATURED PRODUCTS ============================================== -->\r\n    <section class=\"section featured-product wow fadeInUp\">\r\n");
            EndContext();
#line 10 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
      
            //var Language = System.Threading.Thread.CurrentThread.CurrentCulture.DisplayName;
            var Language = "Vietnamese";
            switch (Language)
            {
                case "English":

#line default
#line hidden
            BeginContext(525, 42, true);
            WriteLiteral("                <h3 class=\"section-title\">");
            EndContext();
            BeginContext(568, 25, false);
#line 16 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                     Write(ViewBag.CategoryName.Name);

#line default
#line hidden
            EndContext();
            BeginContext(593, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
#line 17 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                break;
            default:

#line default
#line hidden
            BeginContext(647, 38, true);
            WriteLiteral("            <h3 class=\"section-title\">");
            EndContext();
            BeginContext(686, 27, false);
#line 19 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                 Write(ViewBag.CategoryName.NameVN);

#line default
#line hidden
            EndContext();
            BeginContext(713, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
#line 20 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                break;

        }

#line default
#line hidden
            BeginContext(761, 103, true);
            WriteLiteral("        \r\n        <div class=\"owl-carousel home-owl-carousel custom-carousel owl-theme outer-top-xs\">\r\n");
            EndContext();
#line 26 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
         foreach(var m in Model)
        {

#line default
#line hidden
            BeginContext(909, 265, true);
            WriteLiteral(@"            <div class=""item item-carousel"">
                <div class=""products"">

                    <div class=""product"">
                        <div class=""product-image"">
                            <div class=""image"">
                                ");
            EndContext();
            BeginContext(1174, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96f577add4242b3ba851f4311b6c8d9", async() => {
                BeginContext(1225, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8c2207914dc43b7942c169b38b0dd31", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1235, "~/Content/img/products/images/", 1235, 30, true);
#line 34 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
AddHtmlAttributeValue("", 1265, m.Image, 1265, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 34 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
AddHtmlAttributeValue("", 1310, m.Id, 1310, 5, false);

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
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1183, "~/Product/Detail/", 1183, 17, true);
#line 34 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
AddHtmlAttributeValue("", 1200, m.Id, 1200, 5, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1205, "/", 1205, 1, true);
#line 34 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
AddHtmlAttributeValue("", 1206, m.Name.ToAscii(), 1206, 17, false);

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
            BeginContext(1321, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(1409, 84, true);
            WriteLiteral("                            </div><!-- /.image -->\r\n\r\n                            \r\n");
            EndContext();
#line 41 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                 if (m.Special == true)
                                {

#line default
#line hidden
            BeginContext(1585, 81, true);
            WriteLiteral("                                    <div class=\"tag hot\"><span>hot</span></div>\r\n");
            EndContext();
#line 44 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                }

#line default
#line hidden
            BeginContext(1701, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                 if (m.Discount > 0)
                                {

#line default
#line hidden
            BeginContext(1792, 83, true);
            WriteLiteral("                                    <div class=\"tag sale\"><span>sale</span></div>\r\n");
            EndContext();
#line 49 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"

                                }

#line default
#line hidden
            BeginContext(1912, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 51 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                             if (m.Latest == true)
                            {

#line default
#line hidden
            BeginContext(1995, 77, true);
            WriteLiteral("                                <div class=\"tag new\"><span>new</span></div>\r\n");
            EndContext();
#line 54 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"

                            }

#line default
#line hidden
            BeginContext(2105, 222, true);
            WriteLiteral("\r\n                           \r\n                        </div><!-- /.product-image -->\r\n\r\n                        \r\n                        <div class=\"product-info text-left\">\r\n                            <h3 class=\"name\">");
            EndContext();
            BeginContext(2327, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7328218c31ad43a9ba114a63305581b3", async() => {
                BeginContext(2379, 6, false);
#line 62 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                                                           Write(m.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2336, "~/Product/Detail/", 2336, 17, true);
#line 62 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
AddHtmlAttributeValue("", 2353, m.Id, 2353, 5, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2358, "/", 2358, 1, true);
#line 62 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
AddHtmlAttributeValue("", 2359, m.Name.ToAscii(), 2359, 17, false);

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
            BeginContext(2389, 245, true);
            WriteLiteral("</h3>\r\n                          \r\n                            <div class=\"description\"></div>\r\n\r\n                            <div class=\"product-price\">\r\n                                <span class=\"price\">\r\n                                    ");
            EndContext();
            BeginContext(2635, 54, false);
#line 68 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                               Write(Html.FormatValue(m.PriceP * (1 - m.Discount), "{0:N}"));

#line default
#line hidden
            EndContext();
            BeginContext(2689, 111, true);
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"price-before-discount\">");
            EndContext();
            BeginContext(2801, 35, false);
#line 70 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                               Write(Html.FormatValue(m.PriceP, "{0:N}"));

#line default
#line hidden
            EndContext();
            BeginContext(2836, 494, true);
            WriteLiteral(@" </span>

                            </div><!-- /.product-price -->

                        </div><!-- /.product-info -->
                        <div class=""cart clearfix animate-effect"">
                            <div class=""action"">
                                <ul class=""list-unstyled"">
                                    <li class=""add-cart-button btn-group"">
                                        <button class=""btn btn-primary icon addProduct"" type=""button"" data-id=""");
            EndContext();
            BeginContext(3331, 4, false);
#line 79 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                                                                          Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3335, 249, true);
            WriteLiteral("\">\r\n                                            <i class=\"fa fa-shopping-cart\"></i>\r\n                                        </button>\r\n                                        <button class=\"btn btn-primary addProduct hidden\" type=\"button\" data-id=\"");
            EndContext();
            BeginContext(3585, 4, false);
#line 82 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                                                                            Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3589, 188, true);
            WriteLiteral("\">Thêm vào giỏ</button>\r\n                                        <button class=\"btn btn-primary addProduct\" type=\"button\"\r\n                                                data-urladdcart=\"");
            EndContext();
            BeginContext(3778, 51, false);
#line 84 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                            Write(Url.RouteUrl(new {controller="Cart",action="Add" }));

#line default
#line hidden
            EndContext();
            BeginContext(3829, 60, true);
            WriteLiteral("\"\r\n                                                data-id=\"");
            EndContext();
            BeginContext(3890, 4, false);
#line 85 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                    Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3894, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(3908, 6, false);
#line 85 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                                      Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3914, 12, true);
            WriteLiteral("\" data-url=\"");
            EndContext();
            BeginContext(3927, 7, false);
#line 85 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                                                         Write(m.Image);

#line default
#line hidden
            EndContext();
            BeginContext(3934, 23, true);
            WriteLiteral("\" data-urlpartialcart=\"");
            EndContext();
            BeginContext(3958, 65, false);
#line 85 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
                                                                                                                        Write(Url.RouteUrl(new { controller = "Cart", action = "PartialCart" }));

#line default
#line hidden
            EndContext();
            BeginContext(4023, 461, true);
            WriteLiteral(@""">
                                            Thêm vào giỏ
                                        </button>
                                    </li>

                                    
                                </ul>
                            </div><!-- /.action -->
                        </div><!-- /.cart -->
                    </div><!-- /.product -->

                </div><!-- /.products -->
            </div><!-- /.item -->
");
            EndContext();
#line 98 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Product\Cat.cshtml"
            }

#line default
#line hidden
            BeginContext(4499, 232, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n        </div><!-- /.home-owl-carousel -->\r\n\r\n\r\n\r\n    </section><!-- /.section -->\r\n    <!-- ============================================== FEATURED PRODUCTS : END ============================================== -->\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591