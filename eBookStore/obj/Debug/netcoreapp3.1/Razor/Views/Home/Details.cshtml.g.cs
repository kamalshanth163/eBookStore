#pragma checksum "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d93200a6e2507726bc29ac60e70833a8dfaf54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d93200a6e2507726bc29ac60e70833a8dfaf54", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f308b1257f70c8acc7ac486661fbdb7465aab664", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eBookStore.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
  Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main");
            BeginWriteAttribute("class", " class=\"", 133, "\"", 141, 0);
            EndWriteAttribute();
            WriteLiteral(@">

    <div class=""container"">

        <section class=""breadcrumb-section"">
            <h2 class=""sr-only"">Site Breadcrumb</h2>
            <div class=""breadcrumb-contents"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d93200a6e2507726bc29ac60e70833a8dfaf545469", async() => {
                WriteLiteral("Home ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"">Product Details</li>
                    </ol>
                </nav>
            </div>
        </section>

        <div class=""row  mb--60"">
            <div class=""col-lg-5 mb--30"">
                <div class=""product-details-slider sb-slick-slider arrow-type-two"" data-slick-setting='{
              ""slidesToShow"": 1,
              ""arrows"": false,
              ""fade"": true,
              ""draggable"": false,
              ""swipe"": false,
              ""asNavFor"": "".product-slider-nav""
              }'>
                    <div class=""single-slide"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36d93200a6e2507726bc29ac60e70833a8dfaf547716", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1210, "~/image/products/", 1210, 17, true);
#nullable restore
#line 37 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 1227, Model.Imgfile, 1227, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""mt--30 product-slider-nav sb-slick-slider arrow-type-two"" data-slick-setting='{
            ""infinite"":true,
              ""autoplay"": true,
              ""autoplaySpeed"": 8000,
              ""slidesToShow"": 4,
              ""arrows"": true,
              ""prevArrow"":{""buttonClass"": ""slick-prev"",""iconClass"":""fa fa-chevron-left""},
              ""nextArrow"":{""buttonClass"": ""slick-next"",""iconClass"":""fa fa-chevron-right""},
              ""asNavFor"": "".product-details-slider"",
              ""focusOnSelect"": true
              }'>
                </div>
            </div>
            <div class=""col-lg-7"">
                <div class=""product-details-info pl-lg--30 "">
                    <h3 class=""product-title"">
                        ");
#nullable restore
#line 56 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>Language : <span class=\"list-value\"> English</span></li>\r\n                        <li>Author : <a href=\"#\" class=\"list-value font-weight-bold\">");
#nullable restore
#line 60 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li>Category : <span class=\"list-value\">");
#nullable restore
#line 61 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
                                                           Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                        <li>ISBN : <span class=\"list-value\">1510109064</span></li>\r\n                        <li>Availability : <span class=\"list-value\"> ");
#nullable restore
#line 63 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
                                                                Write(Html.DisplayFor(model => model.Bookquantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Books In Stock</span></li>\r\n                    </ul>\r\n                    <div class=\"price-block\">\r\n                        <span class=\"price-new\">LKR ");
#nullable restore
#line 66 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                    <article class=\"product-details-article\">\r\n                        <h4");
            BeginWriteAttribute("class", " class=\"", 3062, "\"", 3070, 0);
            EndWriteAttribute();
            WriteLiteral(">Book Summery</h4>\r\n                        <p>\r\n                            ");
#nullable restore
#line 72 "C:\Users\DELL\Desktop\TopUp Projects\eBookStore\eBookStore\Views\Home\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </article>


                    <!-- section-warning -->
                    <div class=""wrapper-warning"">
                        <div class=""card"">
                            <div class=""subject"">
                                <h3>Alert</h3>
                                <p>Please Login to Buy This Book.</p>
                            </div>

                        </div>
                        <!-- section-warning -->
                        
                    </div>
                </div>
        </div>
    </div>
        </div>
</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eBookStore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
