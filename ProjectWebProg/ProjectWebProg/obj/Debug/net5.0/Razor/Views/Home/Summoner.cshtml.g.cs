#pragma checksum "C:\Users\Berkay\Documents\GitHub\WebProg_Project\ProjectWebProg\ProjectWebProg\Views\Home\Summoner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03b0e19feed0a325717ca576ad71a53f00fb1176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Summoner), @"mvc.1.0.view", @"/Views/Home/Summoner.cshtml")]
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
#line 1 "C:\Users\Berkay\Documents\GitHub\WebProg_Project\ProjectWebProg\ProjectWebProg\Views\_ViewImports.cshtml"
using ProjectWebProg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berkay\Documents\GitHub\WebProg_Project\ProjectWebProg\ProjectWebProg\Views\_ViewImports.cshtml"
using ProjectWebProg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03b0e19feed0a325717ca576ad71a53f00fb1176", @"/Views/Home/Summoner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d705442f2c9d36949fedf3a3ea0f87984c667b5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Summoner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Berkay\Documents\GitHub\WebProg_Project\ProjectWebProg\ProjectWebProg\Views\Home\Summoner.cshtml"
  
    ViewData["Title"] = "Summoner";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\Berkay\Documents\GitHub\WebProg_Project\ProjectWebProg\ProjectWebProg\Views\Home\Summoner.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div>
    <img />
    <div class=""border-danger"">Summoner Icon</div>
    <div class=""border-dark"">Summoner Name</div>
</div>

<div><button>Champion Masteries</button></div>
<div><button>Ranked Details</button></div>
<div>
    <!--<input type=""button""
           value=""Detailed Statistics""
           onclick=""location.href='<%: Url.Action("" Action"", ""HomeController"" ) %>' "" />-->
    <!--<input type=""button"" value=""Detailed Statistics"" onclick=""location.href='<%: Url.Action(""Index"", ""HomeController"" , new { parameter1=value1 }) %>'"" />-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591