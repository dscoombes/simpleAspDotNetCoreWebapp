#pragma checksum "C:\Users\David Coombes\source\repos\simpleAspDotNetCoreWebapp\simpleAspDotNetCoreWebapp\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "314b0a34cbad4fad17b5943b2136ed37a9a28458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(simpleAspDotNetCoreWebapp.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(simpleAspDotNetCoreWebapp.Pages.Pages_About), null)]
namespace simpleAspDotNetCoreWebapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\David Coombes\source\repos\simpleAspDotNetCoreWebapp\simpleAspDotNetCoreWebapp\Pages\_ViewImports.cshtml"
using simpleAspDotNetCoreWebapp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314b0a34cbad4fad17b5943b2136ed37a9a28458", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0ffc4819e3c6e375a26474f4e67fb5b38a884b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\David Coombes\source\repos\simpleAspDotNetCoreWebapp\simpleAspDotNetCoreWebapp\Pages\About.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
            BeginContext(102, 462, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">About</h1>
    <div class=""text-left"">
        <p>Contoso Fashions is currently re-branding, and we will be using this as an opportunity to bring new purchasing, tracking, and social media features to our online services.</p>
        <p>The company has won several prestigious and influential industry and consumer awards for the high standard of our online customer experience.</p>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<simpleAspDotNetCoreWebapp.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<simpleAspDotNetCoreWebapp.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<simpleAspDotNetCoreWebapp.Pages.AboutModel>)PageContext?.ViewData;
        public simpleAspDotNetCoreWebapp.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591