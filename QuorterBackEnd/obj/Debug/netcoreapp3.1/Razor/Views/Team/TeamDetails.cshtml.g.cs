#pragma checksum "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_TeamDetails), @"mvc.1.0.view", @"/Views/Team/TeamDetails.cshtml")]
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
#line 3 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/_ViewImports.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c3", @"/Views/Team/TeamDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f43b338c0a05b8d70d89971383b9850445251b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_TeamDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataEntities.Concrete.Team>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Team Member Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""ltn__utilize-overlay""></div>

<!-- BREADCRUMB AREA START -->
<div class=""ltn__breadcrumb-area text-left bg-overlay-white-30 bg-image "" data-bs-bg=""img/bg/14.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ltn__breadcrumb-inner"">
                    <h1 class=""page-title"">Agent Details</h1>
                    <div class=""ltn__breadcrumb-list"">
                        <ul>
                            <li><a href=""index.html""><span class=""ltn__secondary-color""><i class=""fas fa-home""></i></span> Home</a></li>
                            <li>Agent Details</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- BREADCRUMB AREA END -->
<!-- TEAM DETAILS AREA START -->
<div class=""ltn__team-details-area mb-120"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""ltn__team-details");
            WriteLiteral("-member-info text-center mb-40\">\n                    <div class=\"team-details-img\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c36629", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1176, "~/assets/uploads/", 1176, 17, true);
#nullable restore
#line 31 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
AddHtmlAttributeValue("", 1193, Model.Image, 1193, 12, false);

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
            WriteLiteral("\n                    </div>\n                    <h2>");
#nullable restore
#line 33 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <h6 class=\"text-uppercase ltn__secondary-color\">");
#nullable restore
#line 34 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                                                               Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <div class=\"ltn__social-media-3\">\n                        <ul>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1506, "\"", 1531, 1);
#nullable restore
#line 37 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
WriteAttributeValue("", 1513, Model.FacebookUrl, 1513, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1634, 1);
#nullable restore
#line 38 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
WriteAttributeValue("", 1617, Model.TwitterUrl, 1617, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a></li>\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1710, "\"", 1735, 1);
#nullable restore
#line 39 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
WriteAttributeValue("", 1717, Model.LinkedinUrl, 1717, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fab fa-linkedin""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""ltn__team-details-member-info-details"">
                    <p>");
#nullable restore
#line 46 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                  Write(Model.Text3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""ltn__team-details-member-about"">
                                <ul>
                                    <li><strong>Positions:</strong> Senior ");
#nullable restore
#line 51 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                                                                      Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    <li><strong>Experience:</strong> ");
#nullable restore
#line 52 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                                                                Write(Model.ExperienceYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + Years</li>\n                                    <li><strong>Practice Area:</strong> ");
#nullable restore
#line 53 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                                                                   Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""ltn__team-details-member-about"">
                                <ul>
                                    <li><strong>Email:</strong> ");
#nullable restore
#line 60 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                                                           Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\n                                    <li><strong>Phone:</strong> ");
#nullable restore
#line 62 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                                                           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                </ul>\n                            </div>\n                        </div>\n                    </div>\n                    <hr>\n\n                    <p>");
#nullable restore
#line 69 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                  Write(Model.Text1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""row ltn__custom-gutter mt-50 mb-20"">
                        <div class=""col-xl-4 col-sm-6 col-12"">
                            <div class=""ltn__feature-item ltn__feature-item-6 text-center"">
                                <div class=""ltn__feature-icon"">
                                    <span><i class=""icon-tire""></i></span>
                                </div>
                                <div class=""ltn__feature-info"">
                                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c313791", async() => {
                WriteLiteral("Home Buying");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                                    <p>Lorem ipsum dolor sit ame it, consectetur adipisicing elit, sed do eiusmod te mp or</p>
                                    <!-- <a class=""ltn__service-btn"" href=""service.html"">Read More</a> -->
                                    <a class=""ltn__service-btn"" href=""service-details.html"">Read More <i class=""flaticon-right-arrow""></i></a>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-sm-6 col-12"">
                            <div class=""ltn__feature-item ltn__feature-item-6 text-center active"">
                                <div class=""ltn__feature-icon"">
                                    <span><i class=""icon-mechanic""></i></span>
                                </div>
                                <div class=""ltn__feature-info"">
                                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c316093", async() => {
                WriteLiteral("Home Selling");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                                    <p>Lorem ipsum dolor sit ame it, consectetur adipisicing elit, sed do eiusmod te mp or</p>
                                    <!-- <a class=""ltn__service-btn"" href=""service.html"">Read More</a> -->
                                    <a class=""ltn__service-btn"" href=""service-details.html"">Read More <i class=""flaticon-right-arrow""></i></a>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-sm-6 col-12"">
                            <div class=""ltn__feature-item ltn__feature-item-6 text-center"">
                                <div class=""ltn__feature-icon"">
                                    <span><i class=""icon-wheel-1""></i></span>
                                </div>
                                <div class=""ltn__feature-info"">
                                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c318388", async() => {
                WriteLiteral("Escrow Services");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                                    <p>Lorem ipsum dolor sit ame it, consectetur adipisicing elit, sed do eiusmod te mp or</p>
                                    <!-- <a class=""ltn__service-btn"" href=""service.html"">Read More</a> -->
                                    <a class=""ltn__service-btn"" href=""service-details.html"">Read More <i class=""flaticon-right-arrow""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>


                    <p>");
#nullable restore
#line 113 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/Team/TeamDetails.cshtml"
                  Write(Model.Text2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <div class=\"ltn__form-box contact-form-box box-shadow white-bg mt-50\">\n                        <h4 class=\"title-2\">Contact for any Inquiry</h4>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c320710", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""input-item input-item-name ltn__custom-icon"">
                                        <input type=""text"" name=""name"" placeholder=""Enter your name"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""input-item input-item-email ltn__custom-icon"">
                                        <input type=""email"" name=""email"" placeholder=""Enter email address"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""input-item"">
                                        <select class=""nice-select"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c321941", async() => {
                    WriteLiteral("Select Service Type");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c322997", async() => {
                    WriteLiteral("Property Management ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c324054", async() => {
                    WriteLiteral("Mortgage Service ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c325108", async() => {
                    WriteLiteral("Consulting Service");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c326163", async() => {
                    WriteLiteral("Home Buying");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c327211", async() => {
                    WriteLiteral("Home Selling");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd060e59ad52ee4de65d5f6b3b0cdd41f9394c328260", async() => {
                    WriteLiteral("Escrow Services");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""input-item input-item-phone ltn__custom-icon"">
                                        <input type=""text"" name=""phone"" placeholder=""Enter phone number"">
                                    </div>
                                </div>
                            </div>
                            <div class=""input-item input-item-textarea ltn__custom-icon"">
                                <textarea name=""message"" placeholder=""Enter message""></textarea>
                            </div>
                            <p><label class=""input-info-save mb-0""><input type=""checkbox"" name=""agree""> Save my name, email, and website in this browser for the next time I comment.</label></p>
                            <div class=""btn-wrapper mt-0"">
                                <button cla");
                WriteLiteral("ss=\"btn theme-btn-1 btn-effect-1 text-uppercase\" type=\"submit\">get an free service</button>\n                            </div>\n                            <p class=\"form-messege mb-0 mt-20\"></p>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- TEAM DETAILS AREA END -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataEntities.Concrete.Team> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
