#pragma checksum "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_CommentaList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07c9b61b046a031315048ef6e69b73c9661c98ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CommentaList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CommentaList/Default.cshtml")]
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
#line 1 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_CommentaList/Default.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c9b61b046a031315048ef6e69b73c9661c98ae", @"/Views/Shared/Components/_CommentaList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f43b338c0a05b8d70d89971383b9850445251b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__CommentaList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CommentModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/uploads/T4.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <div class=\"ltn__comment-area mb-30\">\n                                <div class=\"ltn__comment-inner\">\n                                    <ul>\n");
#nullable restore
#line 6 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_CommentaList/Default.cshtml"
                                         foreach (var comment in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <li>
                                                <div class=""ltn__comment-item clearfix"">
                                                    <div class=""ltn__commenter-img"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07c9b61b046a031315048ef6e69b73c9661c98ae4881", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                    </div>\n                                                    <div class=\"ltn__commenter-comment\">\n                                                        <h6><a href=\"#\">");
#nullable restore
#line 14 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_CommentaList/Default.cshtml"
                                                                   Write(comment.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\n                                                        \n                                                        <p>");
#nullable restore
#line 16 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_CommentaList/Default.cshtml"
                                                      Write(comment.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                                        <span class=\"ltn__comment-reply-btn\">");
#nullable restore
#line 17 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_CommentaList/Default.cshtml"
                                                                                        Write(comment.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                                    </div>\n                                                </div>\n                                            </li>\n");
#nullable restore
#line 21 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_CommentaList/Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </ul>\n                                </div>\n                            </div>");
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
