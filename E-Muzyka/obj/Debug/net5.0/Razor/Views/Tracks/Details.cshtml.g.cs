#pragma checksum "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48de49e8c34a74d49d4b894e855cea7aca261a5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tracks_Details), @"mvc.1.0.view", @"/Views/Tracks/Details.cshtml")]
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
#line 1 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\_ViewImports.cshtml"
using E_Muzyka;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\_ViewImports.cshtml"
using E_Muzyka.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48de49e8c34a74d49d4b894e855cea7aca261a5e", @"/Views/Tracks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4faaca473eedb821bc52d49977aa63d1e52eb7d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Tracks_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_Muzyka.ModelDTO.TrackDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Szczegóły</h1>\r\n\r\n<div>\r\n    <h4>Utwór</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Artist));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Artist));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AlbumTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\STUDIA\PortfolioProj\E-Muzyka\E-Muzyka\Views\Tracks\Details.cshtml"
       Write(Html.DisplayFor(model => model.AlbumTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Muzyka.ModelDTO.TrackDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
