#pragma checksum "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Views/MemberLayoutPartial/_NavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd01ac86bcd789d7dff045c9cf9796683e593dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberLayoutPartial__NavbarPartial), @"mvc.1.0.view", @"/Views/MemberLayoutPartial/_NavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd01ac86bcd789d7dff045c9cf9796683e593dae", @"/Views/MemberLayoutPartial/_NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f43b338c0a05b8d70d89971383b9850445251b3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MemberLayoutPartial__NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/assets/img/logo-ct.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand-img h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("main_logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside class=""sidenav navbar navbar-vertical navbar-expand-xs border-0 border-radius-xl my-3 fixed-start ms-3 "" id=""sidenav-main"">
    <div class=""sidenav-header"">
        <i class=""fas fa-times p-3 cursor-pointer text-secondary opacity-5 position-absolute end-0 top-0 d-none d-xl-none"" aria-hidden=""true"" id=""iconSidenav""></i>
        <a class=""navbar-brand m-0"" href=""https://demos.creative-tim.com/soft-ui-dashboard/pages/dashboard.html"" target=""_blank"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fd01ac86bcd789d7dff045c9cf9796683e593dae6951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <span class=""ms-1 font-weight-bold"">P226</span>
        </a>
    </div>
    <hr class=""horizontal dark mt-0"">
    <div class=""collapse navbar-collapse  w-auto  max-height-vh-100 h-100"" id=""sidenav-collapse-main"">
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd01ac86bcd789d7dff045c9cf9796683e593dae8449", async() => {
                WriteLiteral(@"
                    <div class=""icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center"">
                        <svg width=""12px"" height=""12px"" viewBox=""0 0 45 40"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                            <title>shop </title>
                            <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                <g transform=""translate(-1716.000000, -439.000000)"" fill=""#FFFFFF"" fill-rule=""nonzero"">
                                    <g transform=""translate(1716.000000, 291.000000)"">
                                        <g transform=""translate(0.000000, 148.000000)"">
                                            <path class=""color-background opacity-6"" d=""M46.7199583,10.7414583 L40.8449583,0.949791667 C40.4909749,0.360605034 39.8540131,0 39.1666667,0 L7.83333333,0 C7.1459869,0 6.50902508,0.360605034 6.15504167,0.949791667 ");
                WriteLiteral(@"L0.280041667,10.7414583 C0.0969176761,11.0460037 -1.23209662e-05,11.3946378 -1.23209662e-05,11.75 C-0.00758042603,16.0663731 3.48367543,19.5725301 7.80004167,19.5833333 L7.81570833,19.5833333 C9.75003686,19.5882688 11.6168794,18.8726691 13.0522917,17.5760417 C16.0171492,20.2556967 20.5292675,20.2556967 23.494125,17.5760417 C26.4604562,20.2616016 30.9794188,20.2616016 33.94575,17.5760417 C36.2421905,19.6477597 39.5441143,20.1708521 42.3684437,18.9103691 C45.1927731,17.649886 47.0084685,14.8428276 47.0000295,11.75 C47.0000295,11.3946378 46.9030823,11.0460037 46.7199583,10.7414583 Z""></path>
                                            <path class=""color-background"" d=""M39.198,22.4912623 C37.3776246,22.4928106 35.5817531,22.0149171 33.951625,21.0951667 L33.92225,21.1107282 C31.1430221,22.6838032 27.9255001,22.9318916 24.9844167,21.7998837 C24.4750389,21.605469 23.9777983,21.3722567 23.4960833,21.1018359 L23.4745417,21.1129513 C20.6961809,22.6871153 17.4786145,22.9344611 14.5386667,21.7998837 C14.029926,21.6054643");
                WriteLiteral(@" 13.533337,21.3722507 13.0522917,21.1018359 C11.4250962,22.0190609 9.63246555,22.4947009 7.81570833,22.4912623 C7.16510551,22.4842162 6.51607673,22.4173045 5.875,22.2911849 L5.875,44.7220845 C5.875,45.9498589 6.7517757,46.9451667 7.83333333,46.9451667 L19.5833333,46.9451667 L19.5833333,33.6066734 L27.4166667,33.6066734 L27.4166667,46.9451667 L39.1666667,46.9451667 C40.2482243,46.9451667 41.125,45.9498589 41.125,44.7220845 L41.125,22.2822926 C40.4887822,22.4116582 39.8442868,22.4815492 39.198,22.4912623 Z""></path>
                                        </g>
                                    </g>
                                </g>
                            </g>
                        </svg>
                    </div>
                    <span class=""nav-link-text ms-1"">Dashboard</span>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </li>\n            <li class=\"nav-item\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd01ac86bcd789d7dff045c9cf9796683e593dae13116", async() => {
                WriteLiteral(@"
                    <div class=""icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center"">
                        <svg width=""12px"" height=""12px"" viewBox=""0 0 42 42"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                            <title>office</title>
                            <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                <g transform=""translate(-1869.000000, -293.000000)"" fill=""#FFFFFF"" fill-rule=""nonzero"">
                                    <g transform=""translate(1716.000000, 291.000000)"">
                                        <g id=""office"" transform=""translate(153.000000, 2.000000)"">
                                            <path class=""color-background opacity-6"" d=""M12.25,17.5 L8.75,17.5 L8.75,1.75 C8.75,0.78225 9.53225,0 10.5,0 L31.5,0 C32.46775,0 33.25,0.78225 33.25,1.75 L33.25,12.25 L29.75,12.25 L29.75,3.5 L12.25,3.5");
                WriteLiteral(@" L12.25,17.5 Z""></path>
                                            <path class=""color-background"" d=""M40.25,14 L24.5,14 C23.53225,14 22.75,14.78225 22.75,15.75 L22.75,38.5 L19.25,38.5 L19.25,22.75 C19.25,21.78225 18.46775,21 17.5,21 L1.75,21 C0.78225,21 0,21.78225 0,22.75 L0,40.25 C0,41.21775 0.78225,42 1.75,42 L40.25,42 C41.21775,42 42,41.21775 42,40.25 L42,15.75 C42,14.78225 41.21775,14 40.25,14 Z M12.25,36.75 L7,36.75 L7,33.25 L12.25,33.25 L12.25,36.75 Z M12.25,29.75 L7,29.75 L7,26.25 L12.25,26.25 L12.25,29.75 Z M35,36.75 L29.75,36.75 L29.75,33.25 L35,33.25 L35,36.75 Z M35,29.75 L29.75,29.75 L29.75,26.25 L35,26.25 L35,29.75 Z M35,22.75 L29.75,22.75 L29.75,19.25 L35,19.25 L35,22.75 Z""></path>
                                        </g>
                                    </g>
                                </g>
                            </g>
                        </svg>
                    </div>
                    <span class=""nav-link-text ms-1""> Product Table</span>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
            <li class=""nav-item"">
                <a class=""nav-link  "" href=""/Member/Admin/Index"">
                    <div class=""icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center"">
                        <svg width=""12px"" height=""12px"" viewBox=""0 0 43 36"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                            <title>credit-card</title>
                            <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                <g transform=""translate(-2169.000000, -745.000000)"" fill=""#FFFFFF"" fill-rule=""nonzero"">
                                    <g transform=""translate(1716.000000, 291.000000)"">
                                        <g transform=""translate(453.000000, 454.000000)"">
                                            <path class=""color-background opacity-6"" d=""M43,10.7482083 L43,3.58333333 C43,1.60354167");
            WriteLiteral(@" 41.3964583,0 39.4166667,0 L3.58333333,0 C1.60354167,0 0,1.60354167 0,3.58333333 L0,10.7482083 L43,10.7482083 Z""></path>
                                            <path class=""color-background"" d=""M0,16.125 L0,32.25 C0,34.2297917 1.60354167,35.8333333 3.58333333,35.8333333 L39.4166667,35.8333333 C41.3964583,35.8333333 43,34.2297917 43,32.25 L43,16.125 L0,16.125 Z M19.7083333,26.875 L7.16666667,26.875 L7.16666667,23.2916667 L19.7083333,23.2916667 L19.7083333,26.875 Z M35.8333333,26.875 L28.6666667,26.875 L28.6666667,23.2916667 L35.8333333,23.2916667 L35.8333333,26.875 Z""></path>
                                        </g>
                                    </g>
                                </g>
                            </g>
                        </svg>
                    </div>
                    <span class=""nav-link-text ms-1"">Roles</span>
                </a>
            </li>
     
           
            <li class=""nav-item mt-3"">
                <h6 class=""ps-4 ms-2 text-uppercase text-xs f");
            WriteLiteral(@"ont-weight-bolder opacity-6"">Account pages</h6>
            </li>
       
            <li class=""nav-item"">
                <a class=""nav-link  "" href=""/Login/SignIn/"">
                    <div class=""icon icon-shape icon-sm shadow border-radius-md bg-white text-center me-2 d-flex align-items-center justify-content-center"">
                        <svg width=""12px"" height=""12px"" viewBox=""0 0 40 44"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                            <title>document</title>
                            <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                <g transform=""translate(-1870.000000, -591.000000)"" fill=""#FFFFFF"" fill-rule=""nonzero"">
                                    <g transform=""translate(1716.000000, 291.000000)"">
                                        <g transform=""translate(154.000000, 300.000000)"">
                                            <path class=""color-background opacity-6"" ");
            WriteLiteral(@"d=""M40,40 L36.3636364,40 L36.3636364,3.63636364 L5.45454545,3.63636364 L5.45454545,0 L38.1818182,0 C39.1854545,0 40,0.814545455 40,1.81818182 L40,40 Z""></path>
                                            <path class=""color-background"" d=""M30.9090909,7.27272727 L1.81818182,7.27272727 C0.814545455,7.27272727 0,8.08727273 0,9.09090909 L0,41.8181818 C0,42.8218182 0.814545455,43.6363636 1.81818182,43.6363636 L30.9090909,43.6363636 C31.9127273,43.6363636 32.7272727,42.8218182 32.7272727,41.8181818 L32.7272727,9.09090909 C32.7272727,8.08727273 31.9127273,7.27272727 30.9090909,7.27272727 Z M18.1818182,34.5454545 L7.27272727,34.5454545 L7.27272727,30.9090909 L18.1818182,30.9090909 L18.1818182,34.5454545 Z M25.4545455,27.2727273 L7.27272727,27.2727273 L7.27272727,23.6363636 L25.4545455,23.6363636 L25.4545455,27.2727273 Z M25.4545455,20 L7.27272727,20 L7.27272727,16.3636364 L25.4545455,16.3636364 L25.4545455,20 Z""></path>
                                        </g>
                                    </g>
             ");
            WriteLiteral(@"                   </g>
                            </g>
                        </svg>
                    </div>
                    <span class=""nav-link-text ms-1"">Sign In</span>
                </a>
            </li>
            
        </ul>
    </div>
    <div class=""sidenav-footer mx-3 "">
        <div class=""card card-background shadow-none card-background-mask-secondary"" id=""sidenavCard"">
            <div class=""full-background"" style=""background-image: url('../assets/img/curved-images/white-curved.jpeg')""></div>
            <div class=""card-body text-start p-3 w-100"">
                <div class=""icon icon-shape icon-sm bg-white shadow text-center mb-3 d-flex align-items-center justify-content-center border-radius-md"">
                    <i class=""ni ni-diamond text-dark text-gradient text-lg top-0"" aria-hidden=""true"" id=""sidenavCardIcon""></i>
                </div>
                <div class=""docs-info"">
                    <h6 class=""text-white up mb-0"">Need help?</h6>
                    <p clas");
            WriteLiteral(@"s=""text-xs font-weight-bold"">Please check our docs</p>
                    <a href=""https://www.creative-tim.com/learning-lab/bootstrap/license/soft-ui-dashboard"" target=""_blank"" class=""btn btn-white btn-sm w-100 mb-0"">Documentation</a>
                </div>
            </div>
        </div>
        <a class=""btn bg-gradient-primary mt-4 w-100"" href=""https://www.creative-tim.com/product/soft-ui-dashboard-pro?ref=sidebarfree"" type=""button"">Upgrade to pro</a>
    </div>
</aside>");
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
