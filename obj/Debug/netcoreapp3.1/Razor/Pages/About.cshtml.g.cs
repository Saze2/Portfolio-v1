#pragma checksum "C:\Users\TYPHOON\Desktop\PortfolioWebApp\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d93b5ab2ece4438b676dec9685fc9d0cd349d73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PortfolioWebApp.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace PortfolioWebApp.Pages
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
#line 1 "C:\Users\TYPHOON\Desktop\PortfolioWebApp\Pages\_ViewImports.cshtml"
using PortfolioWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d93b5ab2ece4438b676dec9685fc9d0cd349d73f", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977e7b04d6c2bd69a18dc24ea994a8fb9eb4be95", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""px-3 py-3 pt-md-5 pb-md-4 mx-auto text-center"">
    <h1 class=""display-4"">About</h1>
    <p class=""lead"">Short Description.</p>
</div>

<div class=""container"">
    <ul class=""list-group"">
        <li class=""list-group-item"">
            <p class=""text-sm-center""><strong>Technical Skills</strong></p>
        </li>
        <li class=""list-group-item "">
            <p><strong>Programming: </strong>C#, Java, SQL</p>
        </li>
        <li class=""list-group-item"">
            <p><strong>Web: </strong>HTML, CSS, Bootstrap v4</p>
        </li>
        <li class=""list-group-item"">
            <p>
                <strong>Tools: </strong>Unity, Visual Studio IDE, Visual Studio Code, IntelliJ IDEA, Gluon
                Scene Builder
            </p>
        </li>
    </ul>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioWebApp.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioWebApp.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioWebApp.Pages.AboutModel>)PageContext?.ViewData;
        public PortfolioWebApp.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591