#pragma checksum "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b68c16773629fe1185779694807d96582cc1e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Detail.cshtml", typeof(AspNetCore.Views_Product_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b68c16773629fe1185779694807d96582cc1e2", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication8.Models.WebShop.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
  
    ViewBag.Title = "Detail";

#line default
#line hidden
            BeginContext(85, 170, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 product\">\r\n        <div class=\"col-xs-12 col-sm-6 col-md-5 gallery-holder\">\r\n            <img class=\"img-responsive\" alt=\"\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 255, "\"", 302, 2);
            WriteAttributeValue("", 261, "/Content/img/products/images/", 261, 29, true);
#line 9 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 290, Model.Image, 290, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 303, "\"", 317, 1);
#line 9 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 308, Model.Id, 308, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(318, 206, true);
            WriteLiteral(">\r\n\r\n\r\n        </div>\r\n        <div class=\"col-sm-6 col-md-7 product-info-block\">\r\n            <div class=\"single-product\">\r\n                <div class=\"product-info\">\r\n                    <h1 class=\"name\">");
            EndContext();
            BeginContext(525, 10, false);
#line 16 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(535, 1603, true);
            WriteLiteral(@"</h1>

                    <div class=""rating-reviews m-t-20"">
                        <div class=""row"">
                            <div class=""col-sm-3 hidden"">
                                <div class=""rating rateit-small rateit""><button id=""rateit-reset-5"" data-role=""none"" class=""rateit-reset"" aria-label=""reset rating"" aria-controls=""rateit-range-5"" style=""""></button>
                                <div id=""rateit-range-5"" class=""rateit-range"" tabindex=""0"" role=""slider"" aria-label=""rating"" aria-owns=""rateit-reset-5"" aria-valuemin=""0"" aria-valuemax=""5"" aria-valuenow=""0"" aria-readonly=""false"" style=""width: 80px; height: 16px;""><div class=""rateit-selected"" style=""height: 16px; width: 0px; display: block;""></div>
                                    <div class=""rateit-hover"" style=""height: 16px; width: 0px; display: none;""></div></div><button id=""rateit-reset-5"" data-role=""none"" class=""rateit-reset"" aria-label=""reset rating"" aria-controls=""rateit-range-5""></button><div id=""rateit-range-5"" class=""rate");
            WriteLiteral(@"it-range"" tabindex=""0"" role=""slider"" aria-label=""rating"" aria-owns=""rateit-reset-5"" aria-valuemin=""0"" aria-valuemax=""5"" aria-valuenow=""0"" aria-readonly=""false"" style=""width: 80px; height: 16px;""><div class=""rateit-selected"" style=""height: 16px; width: 0px; display: block;""></div><div class=""rateit-hover"" style=""height: 16px; width: 0px; display: none;""></div></div></div>
                            </div>
                            <div class=""col-sm-8"">
                                <div class=""reviews"">
                                    <a href=""#"" class=""lnk"">(");
            EndContext();
            BeginContext(2139, 11, false);
#line 27 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                        Write(Model.Views);

#line default
#line hidden
            EndContext();
            BeginContext(2150, 473, true);
            WriteLiteral(@" Reviews)</a>
                                </div>
                            </div>
                        </div><!-- /.row -->
                    </div><!-- /.rating-reviews -->

                    <div class=""stock-container info-container m-t-10"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""stock-box"">
                                    <span class=""label"">");
            EndContext();
            BeginContext(2624, 22, false);
#line 37 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                   Write(Global["Availability"]);

#line default
#line hidden
            EndContext();
            BeginContext(2646, 195, true);
            WriteLiteral(":</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-sm-9\">\r\n                                <div class=\"stock-box\">\r\n");
            EndContext();
#line 42 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                     if (@Model.Available == true)
                                    {

#line default
#line hidden
            BeginContext(2948, 106, true);
            WriteLiteral("                                        <span class=\"text-bold\">\r\n                                        ");
            EndContext();
            BeginContext(3055, 17, false);
#line 45 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                   Write(Global["Instock"]);

#line default
#line hidden
            EndContext();
            BeginContext(3072, 51, true);
            WriteLiteral("\r\n                                        </span>\r\n");
            EndContext();
#line 47 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3243, 106, true);
            WriteLiteral("                                        <span class=\"text-danger\">\r\n                                      ");
            EndContext();
            BeginContext(3350, 20, false);
#line 51 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                 Write(Global["NotInStock"]);

#line default
#line hidden
            EndContext();
            BeginContext(3370, 51, true);
            WriteLiteral("\r\n                                        </span>\r\n");
            EndContext();
#line 53 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3460, 266, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div><!-- /.row -->
                    </div><!-- /.stock-container -->

                    <div class=""description-container m-t-20"">
                      ");
            EndContext();
            BeginContext(3727, 28, false);
#line 61 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                 Write(Html.Raw(@Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3755, 358, true);
            WriteLiteral(@"
                    </div><!-- /.description-container -->

                    <div class=""price-container info-container m-t-20"">
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""price-box"">
                                    <span class=""price numeral-init"">");
            EndContext();
            BeginContext(4163, 24, false);
#line 68 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                 Write((double)ViewBag.PriceOff);

#line default
#line hidden
            EndContext();
            BeginContext(4188, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 69 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                    if ((double)ViewBag.PriceOff != Model.PriceP)
                                   {

#line default
#line hidden
            BeginContext(4318, 76, true);
            WriteLiteral("                                    <span class=\"price-strike numeral-init\">");
            EndContext();
            BeginContext(4442, 12, false);
#line 71 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                      Write(Model.PriceP);

#line default
#line hidden
            EndContext();
            BeginContext(4454, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 72 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                   }

#line default
#line hidden
            BeginContext(4501, 400, true);
            WriteLiteral(@"                                      </div>
                            </div>
                        </div><!-- /.row -->
                    </div><!-- /.price-container -->

                    <div class=""quantity-container info-container"">
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <span class=""label"">");
            EndContext();
            BeginContext(4902, 17, false);
#line 81 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                               Write(Global["Quanity"]);

#line default
#line hidden
            EndContext();
            BeginContext(4919, 988, true);
            WriteLiteral(@" :</span>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""cart-quantity"">
                                    <div class=""quant-input"">
                                        <div class=""arrows"">
                                            <div class=""arrow plus gradient""><span class=""ir""><i class=""icon fa fa-sort-asc""></i></span></div>
                                            <div class=""arrow minus gradient""><span class=""ir""><i class=""icon fa fa-sort-desc""></i></span></div>
                                        </div>

                                        <input type=""text"" value=""1"" name=""soluong"" id=""soluong"">

                                    </div>
                                </div>
                            </div>

                            <div class=""col-sm-7"">
                                <a href=""#"" class=""btn btn-primary addProduct"" data-id=""");
            EndContext();
            BeginContext(5908, 8, false);
#line 98 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5916, 20, true);
            WriteLiteral("\"  data-urladdcart=\"");
            EndContext();
            BeginContext(5937, 51, false);
#line 98 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                Write(Url.RouteUrl(new {controller="Cart",action="Add" }));

#line default
#line hidden
            EndContext();
            BeginContext(5988, 63, true);
            WriteLiteral("\"\r\n                                                 data-name=\"");
            EndContext();
            BeginContext(6052, 10, false);
#line 99 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6062, 12, true);
            WriteLiteral("\" data-url=\"");
            EndContext();
            BeginContext(6075, 11, false);
#line 99 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                              Write(Model.Image);

#line default
#line hidden
            EndContext();
            BeginContext(6086, 23, true);
            WriteLiteral("\" data-urlpartialcart=\"");
            EndContext();
            BeginContext(6110, 65, false);
#line 99 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                 Write(Url.RouteUrl(new { controller = "Cart", action = "PartialCart" }));

#line default
#line hidden
            EndContext();
            BeginContext(6175, 2120, true);
            WriteLiteral(@"""><i class=""fa fa-shopping-cart inner-right-vs""></i> Thêm vào giỏ</a>
                            </div>


                        </div><!-- /.row -->
                    </div><!-- /.quantity-container -->

                    <div class=""product-social-link m-t-20 text-right"">
                        <span class=""social-label"">Chia sẻ :</span>
                        <div class=""social-icons"">
                            <ul class=""list-inline"">
                                <li><a class=""fa fa-facebook"" href=""#""></a></li>
                                <li><a class=""fa fa-twitter"" href=""#""></a></li>
                                <li><a class=""fa fa-linkedin"" href=""#""></a></li>
                                <li><a class=""fa fa-rss"" href=""#""></a></li>
                                <li><a class=""fa fa-pinterest"" href=""#""></a></li>
                            </ul><!-- /.social-icons -->
                        </div>
                    </div>




                </div><!-- /.");
            WriteLiteral(@"product-info -->
            </div> <!--Single Product-->
        </div>

        <div class=""single-product outer-bottom-sm"">
           
         
            <div class=""product-tabs inner-bottom-xs"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <ul id=""product-tabs"" class=""nav nav-tabs nav-tab-cell"">
                            <li class=""active""><a data-toggle=""tab"" href=""#description"">MÔ TẢ</a></li>
                            <li class=""hidden""><a data-toggle=""tab"" href=""#review"">REVIEW</a></li>
                            <li class=""hidden""><a data-toggle=""tab"" href=""#tags"">TAGS</a></li>
                        </ul><!-- /.nav-tabs #product-tabs -->
                    </div>
                    <div class=""col-sm-9"">

                        <div class=""tab-content"">

                            <div id=""description"" class=""tab-pane in active"">
                                <div class=""product-tab"">
                      ");
            WriteLiteral("              <p class=\"text\">\r\n                                        ");
            EndContext();
            BeginContext(8296, 28, false);
#line 145 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                   Write(Html.Raw(@Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(8324, 467, true);
            WriteLiteral(@"
                                    </p>
                                </div>
                            </div><!-- /.tab-pane -->

                        </div><!-- /.tab-content -->

                    </div><!-- /.col -->
                </div>

            </div>
        </div>


    </div>
 </div>
<div class=""row"">

    <section class=""section featured-product wow fadeInUp"">
        <h3 class=""section-title""> SẢN PHẨM ĐÃ XEM</h3>

");
            EndContext();
#line 166 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
         foreach (WebApplication8.Models.WebShop.Product m in ViewBag.Views)
        {

            var tukhoa = ViewBag.tukhoa;

#line default
#line hidden
            BeginContext(8924, 220, true);
            WriteLiteral("            <div class=\"products\" style=\"float:left\">\r\n\r\n                <div class=\"product\">\r\n                    <div class=\"product-image\">\r\n                        <div class=\"image\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9144, "\"", 9190, 4);
            WriteAttributeValue("", 9151, "/Product/Detail/", 9151, 16, true);
#line 175 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 9167, m.Id, 9167, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 9172, "/", 9172, 1, true);
#line 175 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 9173, m.Name.ToAscii(), 9173, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9191, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9196, "\"", 9239, 2);
            WriteAttributeValue("", 9202, "/Content/img/products/images/", 9202, 29, true);
#line 175 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 9231, m.Image, 9231, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9240, 51, true);
            WriteLiteral("  alt=\"\" style=\"height:70px\" class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9291, "\"", 9301, 1);
#line 175 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 9296, m.Id, 9296, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9302, 11, true);
            WriteLiteral("></a>\r\n\r\n\r\n");
            EndContext();
            BeginContext(9391, 308, true);
            WriteLiteral(@"                        </div><!-- /.image -->

                        <div class=""tag sale""><span>sale</span></div>
                    </div><!-- /.product-image -->


                    <div class=""product-info text-left"">
                        <h3 class=""name"">
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9699, "\"", 9727, 2);
            WriteAttributeValue("", 9706, "/Product/Detail/", 9706, 16, true);
#line 187 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
WriteAttributeValue("", 9722, m.Id, 9722, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9728, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(9731, 6, false);
#line 187 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                        Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(9737, 303, true);
            WriteLiteral(@";  </a>

                        </h3>

                        <div class=""rating rateit-small""></div>
                        <div class=""description""></div>

                        <div class=""product-price"">
                            <span class=""price"">
                                ");
            EndContext();
            BeginContext(10041, 54, false);
#line 196 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                           Write(Html.FormatValue(m.PriceP * (1 - m.Discount), "{0:N}"));

#line default
#line hidden
            EndContext();
            BeginContext(10095, 106, true);
            WriteLiteral("\r\n\r\n                            </span>\r\n                            <span class=\"price-before-discount\"> ");
            EndContext();
            BeginContext(10202, 35, false);
#line 199 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                            Write(Html.FormatValue(m.PriceP, "{0:N}"));

#line default
#line hidden
            EndContext();
            BeginContext(10237, 466, true);
            WriteLiteral(@" </span>

                        </div><!-- /.product-price -->

                    </div><!-- /.product-info -->
                    <div class=""cart clearfix animate-effect"">
                        <div class=""action"">
                            <ul class=""list-unstyled"">
                                <li class=""add-cart-button btn-group"">
                                    <button class=""btn btn-primary icon addProduct"" type=""button"" data-id=""");
            EndContext();
            BeginContext(10704, 4, false);
#line 208 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                      Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10708, 230, true);
            WriteLiteral("\">\r\n                                        <i class=\"fa fa-shopping-cart\"></i>\r\n                                    </button>\r\n                                    <button class=\"btn btn-primary addProduct\" type=\"button\" data-id=\"");
            EndContext();
            BeginContext(10939, 4, false);
#line 211 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                 Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10943, 274, true);
            WriteLiteral(@""">Thêm vào giỏ</button>
                                </li>
                            </ul>
                        </div><!-- /.action -->
                    </div><!-- /.cart -->
                </div><!-- /.product -->

            </div><!-- /.products -->
");
            EndContext();
#line 219 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\Detail.cshtml"

        }

#line default
#line hidden
            BeginContext(11230, 60, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </section><!-- /.section -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication8.Models.WebShop.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
