#pragma checksum "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "529fd8dbcf18dc1636fcabb5a06d71a83d10dac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_RoomInformation_Views_Room_Index), @"mvc.1.0.view", @"/Areas/RoomInformation/Views/Room/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/RoomInformation/Views/Room/Index.cshtml", typeof(AspNetCore.Areas_RoomInformation_Views_Room_Index))]
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
#line 1 "F:\HotelApplication\Areas\RoomInformation\Views\_ViewImports.cshtml"
using HotelApplication;

#line default
#line hidden
#line 2 "F:\HotelApplication\Areas\RoomInformation\Views\_ViewImports.cshtml"
using HotelApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529fd8dbcf18dc1636fcabb5a06d71a83d10dac1", @"/Areas/RoomInformation/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Areas/RoomInformation/Views/_ViewImports.cshtml")]
    public class Areas_RoomInformation_Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.ViewModels.RoomsAdminIndexViewModel>
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 176, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h3 class=\"h3\">Room</h3>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div style=\"text-align:right;\">\r\n            ");
            EndContext();
            BeginContext(282, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "529fd8dbcf18dc1636fcabb5a06d71a83d10dac15335", async() => {
                BeginContext(348, 31, true);
                WriteLiteral("<i class=\'bx bx-plus\'></i> Room");
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
            BeginContext(383, 460, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<table class=""table table-striped"" style=""margin-top:30px"">
    <thead>
        <tr>
            <th> SL. </th>
            <th> Room Number </th>
            <th> Room Catagory </th>
            <th> Price </th>
            <th> Available </th>
            <th> Description </th>
            <th> Maximum Guests </th>
            <th class=""text-center"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 33 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
          
            var i = 1;
            foreach (var item in Model.Rooms)
            {

#line default
#line hidden
            BeginContext(941, 47, true);
            WriteLiteral("                <tr>\r\n                    <td> ");
            EndContext();
            BeginContext(989, 1, false);
#line 38 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(990, 34, true);
            WriteLiteral(". </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1025, 45, false);
#line 39 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1104, 56, false);
#line 40 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.RoomType.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1194, 40, false);
#line 41 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 53, true);
            WriteLiteral(" </td>\r\n                    <td class=\"text-center\"> ");
            EndContext();
            BeginContext(1288, 44, false);
#line 42 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Available));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 33, true);
            WriteLiteral(" </td>\r\n                    <td> ");
            EndContext();
            BeginContext(1366, 46, false);
#line 43 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 53, true);
            WriteLiteral(" </td>\r\n                    <td class=\"text-center\"> ");
            EndContext();
            BeginContext(1466, 48, false);
#line 44 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.MaximumGuests));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 78, true);
            WriteLiteral(" </td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1592, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "529fd8dbcf18dc1636fcabb5a06d71a83d10dac110554", async() => {
                BeginContext(1668, 26, true);
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
#line 46 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
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
            BeginContext(1698, 69, true);
            WriteLiteral(" |\r\n                        <a class=\"btn btn-sm btn-info text-white\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1767, "\"", 1868, 3);
            WriteAttributeValue("", 1777, "showInPopup(\'", 1777, 13, true);
#line 47 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
WriteAttributeValue("", 1790, Url.Action("Details", "Room", new { id = item.Id }, Context.Request.Scheme), 1790, 76, false);

#line default
#line hidden
            WriteAttributeValue("", 1866, "\')", 1866, 2, true);
            EndWriteAttribute();
            BeginContext(1869, 98, true);
            WriteLiteral("><i class=\'bx bx-info-circle\'></i></a> |\r\n                        <a class=\"btn btn-sm btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1967, "\"", 1993, 3);
            WriteAttributeValue("", 1977, "Delete(", 1977, 7, true);
#line 48 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
WriteAttributeValue("", 1984, item.Id, 1984, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1992, ")", 1992, 1, true);
            EndWriteAttribute();
            BeginContext(1994, 93, true);
            WriteLiteral(" href=\"#\"><i class=\'bx bx-trash\'></i></a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 51 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Index.cshtml"
                i++;
            }
        

#line default
#line hidden
            BeginContext(2135, 528, true);
            WriteLiteral(@"    </tbody>
</table>

<script>
    function Edit(id, roomNumber, roomTypeId, price, avilable, description, maximumGuests) {
        $('#id').val(id);
        $('#roomNumber').val(roomNumber);
        $('#roomTypeId').val(roomTypeId);
        $('#price').val(price);
        $('#avilable').val(avilable);
        $('#description').val(description);
        $('#maximumGuests').val(maximumGuests);

    }

    function Delete(id) {
        location.replace(""/RoomInformation/Room/Delete/"" + id);
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApplication.ViewModels.RoomsAdminIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591