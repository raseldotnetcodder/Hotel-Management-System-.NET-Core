#pragma checksum "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b6c89fdc939163a54577c76c569abdb6f21cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bookings_Views_Suplementary_Index), @"mvc.1.0.view", @"/Areas/Bookings/Views/Suplementary/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Bookings/Views/Suplementary/Index.cshtml", typeof(AspNetCore.Areas_Bookings_Views_Suplementary_Index))]
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
#line 1 "F:\GitHub\HotelApplication\Areas\Bookings\Views\_ViewImports.cshtml"
using HotelApplication;

#line default
#line hidden
#line 2 "F:\GitHub\HotelApplication\Areas\Bookings\Views\_ViewImports.cshtml"
using HotelApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b6c89fdc939163a54577c76c569abdb6f21cfd", @"/Areas/Bookings/Views/Suplementary/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Areas/Bookings/Views/_ViewImports.cshtml")]
    public class Areas_Bookings_Views_Suplementary_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.Models.Suplementary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
  
    ViewData["Title"] = "Suplementary Services";

#line default
#line hidden
            BeginContext(106, 193, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h3 class=\"h3\">Suplementary Services</h3>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div style=\"text-align:right;\">\r\n            ");
            EndContext();
            BeginContext(299, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b6c89fdc939163a54577c76c569abdb6f21cfd5367", async() => {
                BeginContext(365, 47, true);
                WriteLiteral("<i class=\'bx bx-plus\'></i> Suplementary Service");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(416, 173, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table table-striped\" style=\"margin-top:30px\">\r\n    <thead>\r\n        <tr>\r\n            <th> SL. </th>\r\n            <th> ");
            EndContext();
            BeginContext(590, 32, false);
#line 23 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
            Write(Html.DisplayNameFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(622, 25, true);
            WriteLiteral(" </th>\r\n            <th> ");
            EndContext();
            BeginContext(648, 33, false);
#line 24 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
            Write(Html.DisplayNameFor(x => x.Price));

#line default
#line hidden
            EndContext();
            BeginContext(681, 99, true);
            WriteLiteral(" </th>\r\n            <th class=\"text-center\">Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
          
            var i = 1;
            foreach (var item in Model.Suplementaries)
            {

#line default
#line hidden
            BeginContext(887, 47, true);
            WriteLiteral("                <tr>\r\n                    <td> ");
            EndContext();
            BeginContext(935, 1, false);
#line 34 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(936, 34, true);
            WriteLiteral(". </td>\r\n                    <td> ");
            EndContext();
            BeginContext(971, 39, false);
#line 35 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1044, 40, false);
#line 36 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 78, true);
            WriteLiteral(" </td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1162, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b6c89fdc939163a54577c76c569abdb6f21cfd9523", async() => {
                BeginContext(1238, 26, true);
                WriteLiteral("<i class=\'bx bx-edit\'></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1268, 69, true);
            WriteLiteral(" |\r\n                        <a class=\"btn btn-sm btn-info text-white\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1337, "\"", 1446, 3);
            WriteAttributeValue("", 1347, "showInPopup(\'", 1347, 13, true);
#line 39 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
WriteAttributeValue("", 1360, Url.Action("Details", "Suplementary", new { id = item.Id }, Context.Request.Scheme), 1360, 84, false);

#line default
#line hidden
            WriteAttributeValue("", 1444, "\')", 1444, 2, true);
            EndWriteAttribute();
            BeginContext(1447, 98, true);
            WriteLiteral("><i class=\'bx bx-info-circle\'></i></a> |\r\n                        <a class=\"btn btn-sm btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1545, "\"", 1571, 3);
            WriteAttributeValue("", 1555, "Delete(", 1555, 7, true);
#line 40 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
WriteAttributeValue("", 1562, item.Id, 1562, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1570, ")", 1570, 1, true);
            EndWriteAttribute();
            BeginContext(1572, 93, true);
            WriteLiteral(" href=\"#\"><i class=\'bx bx-trash\'></i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Suplementary\Index.cshtml"
                i++;
            }
        

#line default
#line hidden
            BeginContext(1713, 149, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<script>\r\n    function Delete(id) {\r\n        location.replace(\"/Bookings/Suplementary/Delete/\" + id);\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApplication.Models.Suplementary> Html { get; private set; }
    }
}
#pragma warning restore 1591
