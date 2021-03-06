#pragma checksum "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d60ca4300891ba5cdf5f0a95952a76afac5b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_CustomerOrders), @"mvc.1.0.view", @"/Views/Orders/CustomerOrders.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\_ViewImports.cshtml"
using eBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\_ViewImports.cshtml"
using eBookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d60ca4300891ba5cdf5f0a95952a76afac5b75", @"/Views/Orders/CustomerOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f308b1257f70c8acc7ac486661fbdb7465aab664", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_CustomerOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eBookStore.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "admindashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
  
    ViewData["Title"] = "CustomerOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
  Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""breadcrumb-section"">
    <h2 class=""sr-only"">Site Breadcrumb</h2>
    <div class=""container"">
        <div class=""breadcrumb-contents"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1d60ca4300891ba5cdf5f0a95952a76afac5b754591", async() => {
                WriteLiteral("Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"">Customer Orders</li>
                </ol>
            </nav>
        </div>
    </div>
</section>




<main class=""inner-page-sec-padding-bottom"">
    <div class=""container"">

        <div class=""myaccount-content"">
            <h3>Customer Orders</h3>


            <div class=""myaccount-table table-responsive text-center"">
                <table class=""table table-bordered"">
                    <thead class=""thead-light"">
                        <tr>
                            <th>
                                ");
#nullable restore
#line 39 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                           Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 42 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 45 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                           Write(Html.DisplayNameFor(model => model.Orderdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 48 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>Action</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 54 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                               Write(Html.DisplayFor(modelItem => item.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Orderdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 67 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 69 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                               Write(Html.ActionLink((item.Status == "pending" ? "Set as completed" : "Set as pending"), "SetOrderStatus", new { obj = item, id = item.Id, status = item.Status }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eBookStore.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
