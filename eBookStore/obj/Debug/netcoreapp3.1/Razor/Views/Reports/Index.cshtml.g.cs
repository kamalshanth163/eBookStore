#pragma checksum "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Reports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "127483446142d60064628abd48670c00058713e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Index), @"mvc.1.0.view", @"/Views/Reports/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127483446142d60064628abd48670c00058713e8", @"/Views/Reports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f308b1257f70c8acc7ac486661fbdb7465aab664", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Reports\Index.cshtml"
  
    ViewData["Title"] = "GenerateReports";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Generate Reports</h1>\r\n\r\n<h2>\r\n    ");
#nullable restore
#line 9 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Reports\Index.cshtml"
Write(Html.ActionLink("Generate Book Report", "GenerateBookReport", "Reports"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n<h2>\r\n    ");
#nullable restore
#line 12 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Reports\Index.cshtml"
Write(Html.ActionLink("Generate User Report", "GenerateUserReport", "Reports"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n<h2>\r\n    ");
#nullable restore
#line 15 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Reports\Index.cshtml"
Write(Html.ActionLink("Generate Order Report", "GenerateOrderReport", "Reports"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
