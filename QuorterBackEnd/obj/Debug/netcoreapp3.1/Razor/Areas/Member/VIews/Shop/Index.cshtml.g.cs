#pragma checksum "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92ed0daaf6036559a71e8097122152d021e91480"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_VIews_Shop_Index), @"mvc.1.0.view", @"/Areas/Member/VIews/Shop/Index.cshtml")]
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
#line 3 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/_ViewImports.cshtml"
using DataEntities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/_ViewImports.cshtml"
using QuorterBackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/_ViewImports.cshtml"
using QuorterBackEnd.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/_ViewImports.cshtml"
using QuorterBackEnd.Areas.Member;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ed0daaf6036559a71e8097122152d021e91480", @"/Areas/Member/VIews/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b883d501075400a88c9a9acb67e14a4ae017858", @"/Areas/Member/VIews/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_VIews_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<DataEntities.Concrete.Feature2>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"
<h1>Current Products</h1>


<table class=""table table-bordered"">
    <tr>

        <th>City</th>
        <th>Title Of Product</th>
        <th>Build Year</th>

        <th>Saler Man Name</th>
        <th>Price</th>

        
        <th>Delete</th>



    </tr>

");
#nullable restore
#line 27 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
     foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n\n    <td>");
#nullable restore
#line 31 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
   Write(item.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 32 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 33 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
   Write(item.BuildYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 34 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
   Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    <td>");
#nullable restore
#line 36 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n    <td>");
#nullable restore
#line 39 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
   Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 40 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92ed0daaf6036559a71e8097122152d021e914808654", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92ed0daaf6036559a71e8097122152d021e9148011288", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n\n\n</tr>\n");
#nullable restore
#line 47 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n");
#nullable restore
#line 51 "/Users/babayev_/Desktop/Quorter2/QuorterBackEnd/Areas/Member/VIews/Shop/Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index", new {page})));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>


    ul.pagination {
        margin: 15px;
        padding: 10px;
        border-radius: 20px;
        border-color: black;
        justify-content: center;
        font-family: inherit;
        text-decoration: underline;
        font-weight: 600;
    }

    .pagination a {
        margin: 0 10px;
        color: black;
        background-color: pink;
        padding: 20px;
        border-radius: 50px;
        border: 1px solid;
        border-color: gray;
    }

    .pagination span {
        margin: 0 10px;
        color: black;
        background-color: pink;
        padding: 20px;
        border-radius: 50px;
        border: 1px solid;
        border-color: gray;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92ed0daaf6036559a71e8097122152d021e9148015149", async() => {
                WriteLiteral("Add New Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<DataEntities.Concrete.Feature2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
