#pragma checksum "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3708923e6ecc6f034524e6d1331d973af5a11c46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bookings_Views_Invoice_Index), @"mvc.1.0.view", @"/Areas/Bookings/Views/Invoice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Bookings/Views/Invoice/Index.cshtml", typeof(AspNetCore.Areas_Bookings_Views_Invoice_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3708923e6ecc6f034524e6d1331d973af5a11c46", @"/Areas/Bookings/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Areas/Bookings/Views/_ViewImports.cshtml")]
    public class Areas_Bookings_Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InvoiceList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
  
    ViewData["Title"] = "Guest";

#line default
#line hidden
            BeginContext(85, 168, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h3 class=\"h3\">List for Invoice</h3>\r\n    </div>\r\n    <div class=\"col-md-6\" style=\"text-align:right\">\r\n        ");
            EndContext();
            BeginContext(253, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3708923e6ecc6f034524e6d1331d973af5a11c465553", async() => {
                BeginContext(320, 42, true);
                WriteLiteral("<i class=\'bx bx-list-ol\'></i> Invoice List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(366, 176, true);
            WriteLiteral("\r\n    </div>\r\n</div><hr />\r\n\r\n<table class=\"table table-striped\" style=\"margin-top:30px\" id=\"myTable\">\r\n    <thead>\r\n        <tr>\r\n            <th> SL. </th>\r\n            <th> ");
            EndContext();
            BeginContext(543, 40, false);
#line 21 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
            Write(Html.DisplayNameFor(x => x.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(583, 25, true);
            WriteLiteral(" </th>\r\n            <th> ");
            EndContext();
            BeginContext(609, 41, false);
#line 22 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
            Write(Html.DisplayNameFor(x => x.CustomerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(650, 25, true);
            WriteLiteral(" </th>\r\n            <th> ");
            EndContext();
            BeginContext(676, 36, false);
#line 23 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
            Write(Html.DisplayNameFor(x => x.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(712, 25, true);
            WriteLiteral(" </th>\r\n            <th> ");
            EndContext();
            BeginContext(738, 34, false);
#line 24 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
            Write(Html.DisplayNameFor(x => x.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(772, 25, true);
            WriteLiteral(" </th>\r\n            <th> ");
            EndContext();
            BeginContext(798, 39, false);
#line 25 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
            Write(Html.DisplayNameFor(x => x.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(837, 99, true);
            WriteLiteral(" </th>\r\n            <th class=\"text-center\">Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
          
            var i = 1;
            foreach (var item in Model.Bookings)
            {

#line default
#line hidden
            BeginContext(1037, 47, true);
            WriteLiteral("                <tr>\r\n                    <td> ");
            EndContext();
            BeginContext(1085, 1, false);
#line 35 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 34, true);
            WriteLiteral(". </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1121, 47, false);
#line 36 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1202, 48, false);
#line 37 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.CustomerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1284, 43, false);
#line 38 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1361, 41, false);
#line 39 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1436, 46, false);
#line 40 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 78, true);
            WriteLiteral(" </td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1560, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3708923e6ecc6f034524e6d1331d973af5a11c4611903", async() => {
                BeginContext(1668, 34, true);
                WriteLiteral("<i class=\'bx bx-plus\'></i> Invoice");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                                                                                                       WriteLiteral(item.BookingId);

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
            BeginContext(1706, 69, true);
            WriteLiteral(" |\r\n                        <a class=\"btn btn-sm btn-info text-white\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1775, "\"", 1886, 3);
            WriteAttributeValue("", 1785, "showInPopup(\'", 1785, 13, true);
#line 43 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1798, Url.Action("Details", "Booking", new { id = item.BookingId }, Context.Request.Scheme), 1798, 86, false);

#line default
#line hidden
            WriteAttributeValue("", 1884, "\')", 1884, 2, true);
            EndWriteAttribute();
            BeginContext(1887, 90, true);
            WriteLiteral("><i class=\'bx bx-info-circle\'></i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 46 "F:\GitHub\HotelApplication\Areas\Bookings\Views\Invoice\Index.cshtml"
                i++;
            }
        

#line default
#line hidden
            BeginContext(2025, 353, true);
            WriteLiteral(@"    </tbody>
</table>


<script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.13.1/build/alertify.min.js""></script>
<script type=""text/javascript"">
    function Delete(id) {
        location.replace(""/Bookings/Booking/Delete/"" + id);
    }

    $(document).ready(function () {
        $('#myTable').DataTable({

        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApplication.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
