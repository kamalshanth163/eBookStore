#pragma checksum "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e51e4a8b92b9399bca497b3370daf705a531d26"
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
#line 1 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\_ViewImports.cshtml"
using eBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\_ViewImports.cshtml"
using eBookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e51e4a8b92b9399bca497b3370daf705a531d26", @"/Views/Orders/CustomerOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f308b1257f70c8acc7ac486661fbdb7465aab664", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_CustomerOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eBookStore.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
  
    ViewData["Title"] = "CustomerOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
  Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>CustomerOrders</h1>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.Orderdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>Action</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Orderdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
                   Write(Html.ActionLink((item.Status == "pending" ? "Set as completed" : "Set as pending"), "SetOrderStatus", new { obj = item, id = item.Id, status = item.Status }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Orders\CustomerOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
