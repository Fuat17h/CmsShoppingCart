#pragma checksum "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd27996c0aa4108bd279d1d854a5c00b73a716ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
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
#line 1 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\_ViewImports.cshtml"
using CmsShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\_ViewImports.cshtml"
using CmsShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd27996c0aa4108bd279d1d854a5c00b73a716ec", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2d9e2255235de1d8237b86afbfd21e88c603d8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEdit>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
  
    ViewData["Title"] = "Edit Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Roles</h1>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-10\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd27996c0aa4108bd279d1d854a5c00b73a716ec4963", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd27996c0aa4108bd279d1d854a5c00b73a716ec5233", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n             <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 305, "\"", 329, 1);
#nullable restore
#line 15 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 313, Model.Role.Name, 313, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n             <div class=\"row\">\r\n                    <div class=\"col-6\">\r\n                        <h2>Add users to <span class=\"badge badge-primary\">");
#nullable restore
#line 18 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                                                      Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>role</h2>\r\n                        <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 20 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                             if (Model.NonMembers.Count() == 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr><td>All users are members.</td></tr>\r\n");
#nullable restore
#line 23 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                }
                            else
                                {
                                    foreach (AppUser user in Model.NonMembers)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 29 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>\r\n                                                <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1215, "\"", 1231, 1);
#nullable restore
#line 31 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1223, user.Id, 1223, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"AddIds\" />\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                    }   
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </table>\r\n                    </div>\r\n\r\n                        <div class=\"col-6\">\r\n                             <h2>Remove users from <span class=\"badge badge-primary\">");
#nullable restore
#line 40 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                                                                Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>role</h2>\r\n                                <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 42 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                      if (Model.Members.Count() == 0)
                                         {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                             <tr><td>No users are members.</td></tr>\r\n");
#nullable restore
#line 45 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                         }
                                     else
                                         {
                                             foreach (AppUser user in Model.Members)
                                             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                 <tr>\r\n                                                     <td>");
#nullable restore
#line 51 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                                    Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                     <td>\r\n                                                         <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 2465, "\"", 2481, 1);
#nullable restore
#line 53 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 2473, user.Id, 2473, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"DeleteIds\" />\r\n                                                     </td>\r\n                                                 </tr>\r\n");
#nullable restore
#line 56 "C:\Users\FUAD\source\repos\CmsShoppingCart\CmsShoppingCart\Areas\Admin\Views\Roles\Edit.cshtml"
                                             }   
                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </table>
                        </div>

             </div>


                <div class=""form-group"">
                    <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd27996c0aa4108bd279d1d854a5c00b73a716ec14432", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEdit> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
