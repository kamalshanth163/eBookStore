#pragma checksum "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6227091957579bb70478803c9159d29af6cee758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Feedbacks), @"mvc.1.0.view", @"/Views/Books/Feedbacks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6227091957579bb70478803c9159d29af6cee758", @"/Views/Books/Feedbacks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f308b1257f70c8acc7ac486661fbdb7465aab664", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Feedbacks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eBookStore.Models.FeedbackDisplay>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
  
    ViewData["Title"] = "Feedbacks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
  Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Feedbacks</h1>\r\n\r\n<div>\r\n");
#nullable restore
#line 12 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 14 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
       Write(Model.ToList()[0].BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2><br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6227091957579bb70478803c9159d29af6cee7584446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 286, "~/images/", 286, 9, true);
#nullable restore
#line 15 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
AddHtmlAttributeValue("", 295, Model.ToList()[0].Imgfile, 295, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<br />\r\n<div>\r\n");
#nullable restore
#line 21 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
     using (Html.BeginForm("CreateFeedback", "Books", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Feedback: ");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
                   Write(Html.TextBox("feedbackText"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span>Rating: ");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
                                                                      Write(Html.TextBox("rating"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <input type=\"submit\" value=\"Submit\" /> <span>");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
                                                                                                                                                  Write(Html.ActionLink("View all", "AllFeedbacks"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
                                                                                                                                                                                                 Write(Html.ActionLink("My feedbacks", "MyFeedbacks"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
           Write(Html.DisplayNameFor(model => model.FeedbackText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
               Write(Html.DisplayFor(modelItem => item.FeedbackText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\DELL\Desktop\eBookStore\eBookStore\Views\Books\Feedbacks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eBookStore.Models.FeedbackDisplay>> Html { get; private set; }
    }
}
#pragma warning restore 1591
