#pragma checksum "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Location/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1515c333a43b91400a58918517d45b3511602c3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Index), @"mvc.1.0.view", @"/Views/Location/Index.cshtml")]
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
#line 4 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/_ViewImports.cshtml"
using QuorterBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/_ViewImports.cshtml"
using QuorterBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Location/Index.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1515c333a43b91400a58918517d45b3511602c3e", @"/Views/Location/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f43b338c0a05b8d70d89971383b9850445251b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Location_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Map>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"
<div class=""ltn__utilize-overlay""></div>

<!-- BREADCRUMB AREA START -->
<div class=""ltn__breadcrumb-area text-left bg-overlay-white-30 bg-image mb-0"" data-bs-bg=""img/bg/14.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ltn__breadcrumb-inner"">
                    <h1 class=""page-title"">Google Map Locations</h1>
                    <div class=""ltn__breadcrumb-list"">
                        <ul>
                            <li><a href=""index.html""><span class=""ltn__secondary-color""><i class=""fas fa-home""></i></span> Home</a></li>
                            <li>Locations</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- BREADCRUMB AREA END -->
<!-- GOOGLE MAP LOCATIONS AREA START -->
<div class=""ltn__google-map-locations-area"">
    <div id=""gmap""></div>
</div>
<!-- GOOGLE MAP LOCATIONS AREA END -->
<!-- GOOGLE MAP LOCATIONS LIST AREA START -->
");
#nullable restore
#line 32 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Location/Index.cshtml"
Write(await Component.InvokeAsync("_LocationPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- GOOGLE MAP LOCATIONS LIST AREA END -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Map>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
