#pragma checksum "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_MessageList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4f0f130d64a6ee5cd1834743d454b874c6ec8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__MessageList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_MessageList/Default.cshtml")]
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
#line 1 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_MessageList/Default.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4f0f130d64a6ee5cd1834743d454b874c6ec8a", @"/Views/Shared/Components/_MessageList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f43b338c0a05b8d70d89971383b9850445251b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__MessageList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CommentModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-0"">Platform Settings</h6>
        </div>
        <div class=""card-body p-3"">
            <h6 class=""text-uppercase text-body text-xs font-weight-bolder"">Messages</h6>
            <ul class=""list-group"">
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <p>Hrllo</p>
                    </div>
                </li>
                <li class=""list-group-item border-0 px-0"">
                    <div class=""form-check form-switch ps-0"">
                        <p>Hrllo</p>
                    </div>
                </li>
");
#nullable restore
#line 22 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_MessageList/Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item border-0 px-0\">\n                        <div class=\"form-check form-switch ps-0\">\n                            <p>Hrllo</p>\n                        </div>\n                    </li>\n");
#nullable restore
#line 29 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_MessageList/Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </ul>\n\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CommentModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
