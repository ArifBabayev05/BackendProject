#pragma checksum "/Users/babayev_/Desktop/Quorter3/QuorterBackEnd/Views/RightBar/RightBarInShopPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05261f6eb8bad13598b0b375fe8607c0853c9241"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RightBar_RightBarInShopPage), @"mvc.1.0.view", @"/Views/RightBar/RightBarInShopPage.cshtml")]
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
#line 3 "/Users/babayev_/Desktop/Quorter3/QuorterBackEnd/Views/_ViewImports.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/babayev_/Desktop/Quorter3/QuorterBackEnd/Views/_ViewImports.cshtml"
using QuorterBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/babayev_/Desktop/Quorter3/QuorterBackEnd/Views/_ViewImports.cshtml"
using QuorterBackEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05261f6eb8bad13598b0b375fe8607c0853c9241", @"/Views/RightBar/RightBarInShopPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f43b338c0a05b8d70d89971383b9850445251b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RightBar_RightBarInShopPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <!-- Top Rated Product Widget -->\n");
#nullable restore
#line 2 "/Users/babayev_/Desktop/Quorter3/QuorterBackEnd/Views/RightBar/RightBarInShopPage.cshtml"
Write(await Component.InvokeAsync("_TopProps"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!-- Menu Widget (Category) -->\n\n");
#nullable restore
#line 6 "/Users/babayev_/Desktop/Quorter3/QuorterBackEnd/Views/RightBar/RightBarInShopPage.cshtml"
Write(await Component.InvokeAsync("_TopRated"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!-- Popular Post Widget -->\n");
#nullable restore
#line 9 "/Users/babayev_/Desktop/Quorter3/QuorterBackEnd/Views/RightBar/RightBarInShopPage.cshtml"
Write(await Component.InvokeAsync("_Leatest"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Social Media Widget -->
<div class=""widget ltn__social-media-widget"">
    <h4 class=""ltn__widget-title ltn__widget-title-border-2"">Follow us</h4>
    <div class=""ltn__social-media-2"">
        <ul>
            <li><a href=""#"" title=""Facebook""><i class=""fab fa-facebook-f""></i></a></li>
            <li><a href=""#"" title=""Twitter""><i class=""fab fa-twitter""></i></a></li>
            <li><a href=""#"" title=""Linkedin""><i class=""fab fa-linkedin""></i></a></li>
            <li><a href=""#"" title=""Instagram""><i class=""fab fa-instagram""></i></a></li>

        </ul>
    </div>
</div>
<!-- Tagcloud Widget -->
<div class=""widget ltn__tagcloud-widget"">
    <h4 class=""ltn__widget-title ltn__widget-title-border-2"">Popular Tags</h4>
    <ul>
        <li><a href=""#"">Popular</a></li>
        <li><a href=""#"">desgin</a></li>
        <li><a href=""#"">ux</a></li>
        <li><a href=""#"">usability</a></li>
        <li><a href=""#"">develop</a></li>
        <li><a href=""#"">icon</a></li>
        <li><a href=""#"">Car</a></li>
        <l");
            WriteLiteral(@"i><a href=""#"">Service</a></li>
        <li><a href=""#"">Repairs</a></li>
        <li><a href=""#"">Auto Parts</a></li>
        <li><a href=""#"">Oil</a></li>
        <li><a href=""#"">Dealer</a></li>
        <li><a href=""#"">Oil Change</a></li>
        <li><a href=""#"">Body Color</a></li>
    </ul>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
