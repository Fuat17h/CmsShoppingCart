#pragma checksum "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f23411a946fc96884050fee84e4d528f924cb65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart__PaypalPartial), @"mvc.1.0.view", @"/Views/Cart/_PaypalPartial.cshtml")]
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
#line 1 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\_ViewImports.cshtml"
using CmsShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\_ViewImports.cshtml"
using CmsShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f23411a946fc96884050fee84e4d528f924cb65", @"/Views/Cart/_PaypalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bafcca044c23f3ae64fd57297ff83c598c51caa3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart__PaypalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://www.sandbox.paypal.com/us/cgi-bin/webscr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
  
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f23411a946fc96884050fee84e4d528f924cb654242", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"cmd\" value=\"_cart\">\r\n    <input type=\"hidden\" name=\"upload\" value=\"1\">\r\n    <input type=\"hidden\" name=\"business\" value=\"sb-qjtse22140956@personal.example.com\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 374, "\"", 397, 2);
                WriteAttributeValue("", 381, "item_name_", 381, 10, true);
#nullable restore
#line 13 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 391, count, 391, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 398, "\"", 423, 1);
#nullable restore
#line 13 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 406, item.ProductName, 406, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 455, "\"", 475, 2);
                WriteAttributeValue("", 462, "amount_", 462, 7, true);
#nullable restore
#line 14 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 469, count, 469, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 476, "\"", 495, 1);
#nullable restore
#line 14 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 484, item.Price, 484, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 527, "\"", 549, 2);
                WriteAttributeValue("", 534, "quantity_", 534, 9, true);
#nullable restore
#line 15 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 543, count, 543, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 550, "\"", 572, 1);
#nullable restore
#line 15 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 558, item.Quantity, 558, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 16 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Views\Cart\_PaypalPartial.cshtml"
        count++;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"currency_code\" value=\"USD\">\r\n    <input type=\"image\" src=\"http://www.paypal.com/en_US/i/btn/x-click-but01.gif\" name=\"submit\" alt=\"Make payments with PayPal - it\'s fast, free and secure!\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591