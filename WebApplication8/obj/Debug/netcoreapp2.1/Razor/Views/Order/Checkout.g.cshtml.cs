#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06d499cdf25434bb356dd44da85d42e67029536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Checkout), @"mvc.1.0.view", @"/Views/Order/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Checkout.cshtml", typeof(AspNetCore.Views_Order_Checkout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06d499cdf25434bb356dd44da85d42e67029536", @"/Views/Order/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication8.Models.WebShop.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Phone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/maskedInput/jquery.maskedinput.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
  
    ViewBag.Title = "Checkout";



#line default
#line hidden
            BeginContext(91, 23, true);
            WriteLiteral("\r\n<h2>Checkout</h2>\r\n\r\n");
            EndContext();
#line 11 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
 using (Html.BeginForm("Purchase", "Order", FormMethod.Post, new { id = "form-checkout" }))
{
    await Html.RenderPartialAsync("_Alerts");
    

#line default
#line hidden
            BeginContext(262, 50, false);
#line 14 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
Write(await Html.PartialAsync("Partials/_ErrorValidate"));

#line default
#line hidden
            EndContext();
            BeginContext(314, 195, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Mã Khách Hàng</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(509, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ce8d31af5764c0a92b56efe276dc2aa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 19 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(569, 40, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(891, 145, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Ngày yêu cầu</label>\r\n            <div class=\"col-md-10\">\r\n");
            EndContext();
            BeginContext(1136, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1152, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce9efcccb95c4caa939857b0f6174e82", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RequireDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 37 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
                                                             WriteLiteral(DateTime.Now.ToString("dd/MM/yyyy"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1248, 197, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Người nhận</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1446, 73, false);
#line 44 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
           Write(Html.TextBoxFor(model => model.Receiver, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 201, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Email Người nhận</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1720, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "397198fc2c49458ea5daaaf92157cb7b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 50 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmailContact);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1774, 194, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Địa chỉ</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1969, 72, false);
#line 57 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
           Write(Html.TextBoxFor(model => model.Address, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2041, 184, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Số điện thoại</label>\r\n            <div class=\"col-md-10\">\r\n");
            EndContext();
            BeginContext(2329, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2330, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e3a58bffdc840ff8d74f107ffc271ef", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 65 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phone);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2398, 200, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Tổng giá trị </label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2599, 91, false);
#line 72 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
           Write(Html.TextBoxFor(model => model.Amount, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
            EndContext();
            BeginContext(2690, 206, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Tài khoản Ngân Hàng</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2897, 66, false);
#line 79 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
           Write(Html.TextBox("BankAccount", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2963, 192, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Mô tả</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3156, 89, false);
#line 86 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
           Write(Html.TextAreaFor(model => model.Description, new { @class = "form-control", rows = "5" }));

#line default
#line hidden
            EndContext();
            BeginContext(3245, 257, true);
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Purchase"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 96 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
}

#line default
#line hidden
            BeginContext(3505, 31, true);
            WriteLiteral("<h4>The Selected Items</h4>\r\n\r\n");
            EndContext();
            BeginContext(3580, 42, false);
#line 101 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Views\Order\Checkout.cshtml"
Write(await Component.InvokeAsync("OrderDetail"));

#line default
#line hidden
            EndContext();
            BeginContext(3622, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3642, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3644, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "199607c37d414528bfdb4ae30a3b7f4c", async() => {
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
                BeginContext(3711, 1314, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#RequireDate"").mask(""99/99/9999"");
            //  $(""#OrderDate"").mask(""99/99/9999"");
            $('#Phone').mask('0000-000-0000');
            $('#Amount').mask('000,000,000,000,000', { reverse: true });
           
            $('#form-checkout').bootstrapValidator({
                //live: 'disabled',
                message: 'This value is not valid',
                feedbackIcons: {
                    valid: 'glyphicon glyphicon-ok',
                    invalid: 'glyphicon glyphicon-remove',
                    validating: 'glyphicon glyphicon-refresh'
                },
                fields: {
                    
                    RequireDate: {

                        validators: {
                            notEmpty: {
                                message: 'Vui lòng nhập Ngày yêu câu giao hàng'
                            },
                            date: {
           ");
                WriteLiteral(@"                     format: 'DD/MM/YYYY',
                                message: 'Sai dinh dạng dd/mm/yyyy'
                            },
                        }
                    },
                   
                }
            });



         });
    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication8.Models.WebShop.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
