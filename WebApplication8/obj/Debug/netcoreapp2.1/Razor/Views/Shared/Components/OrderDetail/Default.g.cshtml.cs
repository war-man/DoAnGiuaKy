#pragma checksum "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f82bf93f2c1214d46ab04534ba87f54c7b55b0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OrderDetail_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OrderDetail/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/OrderDetail/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_OrderDetail_Default))]
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
#line 2 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
using WebApplication8.Models.ShoppingCart;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f82bf93f2c1214d46ab04534ba87f54c7b55b0bb", @"/Views/Shared/Components/OrderDetail/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OrderDetail_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication8.Models.WebShop.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(105, 217, true);
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Tên Sản phẩm</th>\r\n        <th>Giá </th>\r\n        <th>Discount</th>\r\n        <th>Số lượng</th>\r\n        <th>Giá trị</th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(360, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(391, 4, false);
#line 17 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
           Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(395, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(419, 6, false);
#line 18 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(425, 50, true);
            WriteLiteral("</td>\r\n            <td><span class=\"numeral-init\">");
            EndContext();
            BeginContext(476, 8, false);
#line 19 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                      Write(p.PriceP);

#line default
#line hidden
            EndContext();
            BeginContext(484, 30, true);
            WriteLiteral("</span></td>\r\n            <td>");
            EndContext();
            BeginContext(515, 24, false);
#line 20 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
           Write(Html.Raw(p.Discount*100));

#line default
#line hidden
            EndContext();
            BeginContext(539, 46, true);
            WriteLiteral("</td>\r\n            <td><input class=\"quantity\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 585, "\"", 604, 1);
#line 21 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
WriteAttributeValue("", 593, p.Quantity, 593, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(605, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(616, 4, false);
#line 21 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                                                Write(p.Id);

#line default
#line hidden
            EndContext();
            BeginContext(620, 10, true);
            WriteLiteral("\" size=\"3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 630, "\"", 643, 2);
#line 21 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
WriteAttributeValue("", 635, p.Id, 635, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 640, "-ss", 640, 3, true);
            EndWriteAttribute();
            BeginContext(644, 25, true);
            WriteLiteral(" /></td>\r\n            <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 669, "\"", 679, 1);
#line 22 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
WriteAttributeValue("", 674, p.Id, 674, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(680, 28, true);
            WriteLiteral("><span class=\"numeral-init\">");
            EndContext();
            BeginContext(709, 50, false);
#line 22 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                                 Write(Html.Raw(p.PriceP * p.Quantity * (1 - p.Discount)));

#line default
#line hidden
            EndContext();
            BeginContext(759, 31, true);
            WriteLiteral("</span></td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 25 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(797, 133, true);
            WriteLiteral("    <tr>\r\n        <th colspan=\"5\" style=\"text-align:right\">Total:</th>\r\n        <th class=\"nn-cart-total\"><span class=\"numeral-init\">");
            EndContext();
            BeginContext(931, 18, false);
#line 28 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\Components\OrderDetail\Default.cshtml"
                                                        Write(ShoppingCart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(949, 43, true);
            WriteLiteral("</span></th>\r\n\r\n    </tr>\r\n</table>\r\n\r\n\r\n\r\n");
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
