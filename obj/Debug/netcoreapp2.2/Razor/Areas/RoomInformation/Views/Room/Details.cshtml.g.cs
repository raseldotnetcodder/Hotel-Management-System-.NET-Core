#pragma checksum "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e020404055cae544465ae07ff669917153f6ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_RoomInformation_Views_Room_Details), @"mvc.1.0.view", @"/Areas/RoomInformation/Views/Room/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/RoomInformation/Views/Room/Details.cshtml", typeof(AspNetCore.Areas_RoomInformation_Views_Room_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e020404055cae544465ae07ff669917153f6ca", @"/Areas/RoomInformation/Views/Room/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Areas/RoomInformation/Views/_ViewImports.cshtml")]
    public class Areas_RoomInformation_Views_Room_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 185px; padding: 5px; border-radius: 10px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
            BeginContext(102, 165, true);
            WriteLiteral("<h4>Room Details</h4>\r\n<div>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-7\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-5\"> ");
            EndContext();
            BeginContext(268, 46, false);
#line 13 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(314, 46, true);
            WriteLiteral(" </dt>\r\n                <dd class=\"col-sm-7\"> ");
            EndContext();
            BeginContext(361, 42, false);
#line 14 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(403, 46, true);
            WriteLiteral(" </dd>\r\n                <dt class=\"col-sm-5\"> ");
            EndContext();
            BeginContext(450, 57, false);
#line 15 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayNameFor(model => model.RoomType.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(507, 46, true);
            WriteLiteral(" </dt>\r\n                <dd class=\"col-sm-7\"> ");
            EndContext();
            BeginContext(554, 42, false);
#line 16 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.RoomTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(596, 46, true);
            WriteLiteral(" </dd>\r\n                <dt class=\"col-sm-5\"> ");
            EndContext();
            BeginContext(643, 41, false);
#line 17 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(684, 46, true);
            WriteLiteral(" </dt>\r\n                <dd class=\"col-sm-7\"> ");
            EndContext();
            BeginContext(731, 37, false);
#line 18 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(768, 46, true);
            WriteLiteral(" </dd>\r\n                <dt class=\"col-sm-5\"> ");
            EndContext();
            BeginContext(815, 45, false);
#line 19 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayNameFor(model => model.Available));

#line default
#line hidden
            EndContext();
            BeginContext(860, 46, true);
            WriteLiteral(" </dt>\r\n                <dd class=\"col-sm-7\"> ");
            EndContext();
            BeginContext(907, 41, false);
#line 20 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.Available));

#line default
#line hidden
            EndContext();
            BeginContext(948, 46, true);
            WriteLiteral(" </dd>\r\n                <dt class=\"col-sm-5\"> ");
            EndContext();
            BeginContext(995, 49, false);
#line 21 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayNameFor(model => model.MaximumGuests));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 46, true);
            WriteLiteral(" </dt>\r\n                <dd class=\"col-sm-7\"> ");
            EndContext();
            BeginContext(1091, 45, false);
#line 22 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.MaximumGuests));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 46, true);
            WriteLiteral(" </dd>\r\n                <dt class=\"col-sm-5\"> ");
            EndContext();
            BeginContext(1183, 47, false);
#line 23 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 46, true);
            WriteLiteral(" </dt>\r\n                <dd class=\"col-sm-7\"> ");
            EndContext();
            BeginContext(1277, 43, false);
#line 24 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 106, true);
            WriteLiteral(" </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"col-md-5\">\r\n            <h4>Features</h4>\r\n");
            EndContext();
#line 29 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
             foreach (var feature in ViewBag.Features as IEnumerable<Feature>)
            {

#line default
#line hidden
            BeginContext(1521, 102, true);
            WriteLiteral("                <div class=\"row\" style=\"margin-bottom:3px;\">\r\n                    <p class=\"col-sm-5\">");
            EndContext();
            BeginContext(1624, 12, false);
#line 32 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                   Write(feature.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(1662, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40e020404055cae544465ae07ff669917153f6ca11884", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#line 33 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                                                                           WriteLiteral(feature.Icon);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1788, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 35 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1829, 51, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <h4>Images</h4>\r\n");
            EndContext();
#line 40 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
     foreach (var image in ViewBag.Images as IEnumerable<Image>)
    {

#line default
#line hidden
            BeginContext(1953, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1961, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40e020404055cae544465ae07ff669917153f6ca14958", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#line 42 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
                                                                                  WriteLiteral(image.ImageUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
AddHtmlAttributeValue("", 2095, image.Name, 2095, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "F:\HotelApplication\Areas\RoomInformation\Views\Room\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2119, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApplication.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591