#pragma checksum "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2546c578d259f8913a1d39ecb2cd7a737112a2d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(YellowBucket1.Pages.Movies.Rentals.Pages_Movies_Rentals_Details), @"mvc.1.0.razor-page", @"/Pages/Movies/Rentals/Details.cshtml")]
namespace YellowBucket1.Pages.Movies.Rentals
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
#line 1 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\_ViewImports.cshtml"
using YellowBucket1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2546c578d259f8913a1d39ecb2cd7a737112a2d3", @"/Pages/Movies/Rentals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f9d90033312f8c8f157582fc43be5ab5e99bc1c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Movies_Rentals_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"flex-container\" style=\"column-gap:15px;grid-row-gap:15px\">\r\n    <div class=\"card\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 175, "\"", 231, 1);
#nullable restore
#line 7 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
WriteAttributeValue("", 181, Html.DisplayFor(model => model.Movies.CoverPhoto), 181, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 232, "\"", 287, 1);
#nullable restore
#line 7 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
WriteAttributeValue("", 238, Html.DisplayNameFor(model => model.Movies.Title), 238, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:480px;height:720px\">\r\n    </div>\r\n    <div class=\"card\">\r\n        <h1>");
#nullable restore
#line 10 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movies.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p>");
#nullable restore
#line 11 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
      Write(Html.DisplayFor(model => model.Movies.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"text-align:left\">Rating: ");
#nullable restore
#line 12 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.Movies.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p style=\"text-align:left\">Length: ");
#nullable restore
#line 13 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.Movies.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutes</p>\r\n        <p style=\"text-align:left\">Available on:</p>\r\n        <p style=\"text-align:left\">");
#nullable restore
#line 15 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
                              Write(Html.DisplayFor(model => model.Movies.IsBluRay));

#line default
#line hidden
#nullable disable
            WriteLiteral(" BluRay </p>\r\n        <p style=\"text-align:left\">");
#nullable restore
#line 16 "C:\Users\Steve\Source\Repos\YellowBucket1\Pages\Movies\Rentals\Details.cshtml"
                              Write(Html.DisplayFor(model => model.Movies.IsDVD));

#line default
#line hidden
#nullable disable
            WriteLiteral(" DVD</p>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2546c578d259f8913a1d39ecb2cd7a737112a2d36190", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <span style=\"float:right;\">\r\n        <button type=\"button\">Add to Cart</button>\r\n    </span>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YellowBucket1.Pages.Movies.Rentals.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YellowBucket1.Pages.Movies.Rentals.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YellowBucket1.Pages.Movies.Rentals.DetailsModel>)PageContext?.ViewData;
        public YellowBucket1.Pages.Movies.Rentals.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
