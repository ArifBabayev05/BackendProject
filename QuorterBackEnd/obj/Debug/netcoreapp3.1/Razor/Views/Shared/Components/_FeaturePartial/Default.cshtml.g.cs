#pragma checksum "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d1c60659b331555a7a84cf8515d307f1c897bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__FeaturePartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_FeaturePartial/Default.cshtml")]
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
#line 1 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d1c60659b331555a7a84cf8515d307f1c897bb", @"/Views/Shared/Components/_FeaturePartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f43b338c0a05b8d70d89971383b9850445251b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__FeaturePartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature2>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""ltn__product-slider-area ltn__product-gutter pt-115 pb-90"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title-area ltn__section-title-2--- text-center"">
                    <h6 class=""section-subtitle section-subtitle-2 ltn__secondary-color"">Properties</h6>
                    <h1 class=""section-title"">Featured Listings</h1>
                </div>
            </div>
        </div>
        <div class=""row ltn__product-slider-item-three-active slick-arrow-1"">
            <!-- ltn__product-item -->
            <!-- ltn__product-item -->
");
#nullable restore
#line 17 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
             foreach (var feature in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-12\">\n                    <div class=\"ltn__product-item ltn__product-item-4 text-center---\">\n                        <div class=\"product-img\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 951, "\"", 987, 2);
            WriteAttributeValue("", 958, "/Shop/ShopDetails/", 958, 18, true);
#nullable restore
#line 22 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
WriteAttributeValue("", 976, feature.Id, 976, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5d1c60659b331555a7a84cf8515d307f1c897bb5351", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 999, "~/assets/uploads/", 999, 17, true);
#nullable restore
#line 22 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
AddHtmlAttributeValue("", 1016, feature.MainPhoto, 1016, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                            <div class=\"product-badge\">\n                                <ul>\n");
#nullable restore
#line 25 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                     if (feature.IsSale)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"sale-badge bg-warning\">For Sale</li>\n");
#nullable restore
#line 28 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"sale-badge bg-green\">For Rent</li>\n");
#nullable restore
#line 33 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                            </div>
                            <div class=""product-img-location-gallery"">
                                <div class=""product-img-location"">
                                    <ul>
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 1911, "\"", 1918, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"flaticon-pin\"></i> ");
#nullable restore
#line 41 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                                                               Write(feature.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </a>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""product-img-gallery"">
                                    <ul>
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 2297, "\"", 2333, 2);
            WriteAttributeValue("", 2304, "/Shop/ShopDetails/", 2304, 18, true);
#nullable restore
#line 48 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
WriteAttributeValue("", 2322, feature.Id, 2322, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-camera\"></i> 4</a>\n                                        </li>\n                                        <li>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2508, "\"", 2544, 2);
            WriteAttributeValue("", 2515, "/Shop/ShopDetails/", 2515, 18, true);
#nullable restore
#line 51 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
WriteAttributeValue("", 2533, feature.Id, 2533, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-film""></i> 2</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""product-info"">
                            <div class=""product-price"">
                                <span>");
#nullable restore
#line 59 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                 Write(feature.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>/Month</label></span>\n                            </div>\n                            <h2 class=\"product-title\"><a");
            BeginWriteAttribute("href", " href=\"", 3052, "\"", 3088, 2);
            WriteAttributeValue("", 3059, "/Shop/ShopDetails/", 3059, 18, true);
#nullable restore
#line 61 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
WriteAttributeValue("", 3077, feature.Id, 3077, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                                                                         Write(feature.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\n                            <div class=\"product-description\">\n                                <p>\n                                    ");
#nullable restore
#line 64 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                               Write(feature.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </p>\n                            </div>\n                            <ul class=\"ltn__list-item-2 ltn__list-item-2-before\">\n                                <li>\n                                    <span>");
#nullable restore
#line 69 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                     Write(feature.BedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"flaticon-bed\"></i></span>\n                                    Bedrooms\n                                </li>\n                                <li>\n                                    <span>");
#nullable restore
#line 73 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                     Write(feature.BathCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"flaticon-clean\"></i></span>\n                                    Bathrooms\n                                </li>\n                                <li>\n                                    <span>");
#nullable restore
#line 77 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                     Write(feature.SalesManName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<i class=""flaticon-square-shape-design-interface-tool-symbol""></i></span>
                                    square Ft
                                </li>
                            </ul>
                        </div>
                        <div class=""product-info-bottom"">
                            <div class=""real-estate-agent"">
                                <div class=""agent-img"">
                                    <a href=""team-details.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5d1c60659b331555a7a84cf8515d307f1c897bb14237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4431, "~/assets/uploads/", 4431, 17, true);
#nullable restore
#line 85 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
AddHtmlAttributeValue("", 4448, feature.AuthorImage, 4448, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                                </div>\n                                <div class=\"agent-brief\">\n                                    <h6><a href=\"team-details.html\">");
#nullable restore
#line 88 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
                                                               Write(feature.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h6>
                                    <small>Estate Agents</small>
                                </div>
                            </div>
                            <div class=""product-hover-action"">
                                <ul>
                                    <li>
                                        <a href=""#"" title=""Quick View"" data-bs-toggle=""modal"" data-bs-target=""#quick_view_modal"">
                                            <i class=""flaticon-expand""></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"" title=""Wishlist"" data-bs-toggle=""modal"" data-bs-target=""#liton_wishlist_modal"">
                                            <i class=""flaticon-heart-1""></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 5670, "\"", 5706, 2);
            WriteAttributeValue("", 5677, "/Shop/ShopDetails/", 5677, 18, true);
#nullable restore
#line 105 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
WriteAttributeValue("", 5695, feature.Id, 5695, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""Product Details"">
                                            <i class=""flaticon-add""></i>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 114 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Shared/Components/_FeaturePartial/Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--  -->\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
