#pragma checksum "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1572695143f69bee259a3608e62ac1ae0af7abaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_RoomInformation_Views_Booking_Details), @"mvc.1.0.view", @"/Areas/RoomInformation/Views/Booking/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/RoomInformation/Views/Booking/Details.cshtml", typeof(AspNetCore.Areas_RoomInformation_Views_Booking_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1572695143f69bee259a3608e62ac1ae0af7abaa", @"/Areas/RoomInformation/Views/Booking/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Areas/RoomInformation/Views/_ViewImports.cshtml")]
    public class Areas_RoomInformation_Views_Booking_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive col-sm-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-12 img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:5px; width:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 149, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Booking</h4>\r\n    <a href=\"#\" class=\"btn btn-primary\">Book Now</a>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\"> ");
            EndContext();
            BeginContext(235, 51, false);
#line 12 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Room.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(286, 39, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-10\"> ");
            EndContext();
            BeginContext(326, 47, false);
#line 13 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Room.RoomNumber));

#line default
#line hidden
            EndContext();
            BeginContext(373, 38, true);
            WriteLiteral(" </dd>\r\n        <dt class=\"col-sm-2\"> ");
            EndContext();
            BeginContext(412, 62, false);
#line 14 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Room.RoomType.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(474, 39, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-10\"> ");
            EndContext();
            BeginContext(514, 58, false);
#line 15 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Room.RoomType.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(572, 38, true);
            WriteLiteral(" </dd>\r\n        <dt class=\"col-sm-2\"> ");
            EndContext();
            BeginContext(611, 46, false);
#line 16 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Room.Price));

#line default
#line hidden
            EndContext();
            BeginContext(657, 39, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-10\"> ");
            EndContext();
            BeginContext(697, 42, false);
#line 17 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Room.Price));

#line default
#line hidden
            EndContext();
            BeginContext(739, 38, true);
            WriteLiteral(" </dd>\r\n        <dt class=\"col-sm-2\"> ");
            EndContext();
            BeginContext(778, 50, false);
#line 18 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Room.Available));

#line default
#line hidden
            EndContext();
            BeginContext(828, 39, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-10\"> ");
            EndContext();
            BeginContext(868, 46, false);
#line 19 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Room.Available));

#line default
#line hidden
            EndContext();
            BeginContext(914, 38, true);
            WriteLiteral(" </dd>\r\n        <dt class=\"col-sm-2\"> ");
            EndContext();
            BeginContext(953, 52, false);
#line 20 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Room.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 39, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-10\"> ");
            EndContext();
            BeginContext(1045, 48, false);
#line 21 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Room.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 38, true);
            WriteLiteral(" </dd>\r\n        <dt class=\"col-sm-2\"> ");
            EndContext();
            BeginContext(1132, 54, false);
#line 22 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Room.MaximumGuests));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 39, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-10\"> ");
            EndContext();
            BeginContext(1226, 50, false);
#line 23 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Room.MaximumGuests));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 44, true);
            WriteLiteral(" </dd>\r\n    </dl>\r\n\r\n    <h4>Features</h4>\r\n");
            EndContext();
#line 27 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
     foreach (var feature in ViewBag.Features as IEnumerable<Feature>)
    {

#line default
#line hidden
            BeginContext(1399, 86, true);
            WriteLiteral("        <div class=\"row\" style=\"margin-bottom:3px;\">\r\n            <p class=\"col-sm-3\">");
            EndContext();
            BeginContext(1486, 12, false);
#line 30 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                           Write(feature.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1498, 18, true);
            WriteLiteral("</p>\r\n            ");
            EndContext();
            BeginContext(1516, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1572695143f69bee259a3608e62ac1ae0af7abaa11778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#line 31 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                                                                 WriteLiteral(feature.Icon);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
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
            BeginContext(1624, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 33 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1649, 23, true);
            WriteLiteral("\r\n    <h4>Images</h4>\r\n");
            EndContext();
#line 36 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
     foreach (var image in ViewBag.Images as IEnumerable<Image>)
    {

#line default
#line hidden
            BeginContext(1745, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1753, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1572695143f69bee259a3608e62ac1ae0af7abaa14707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#line 38 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
                                                                              WriteLiteral(image.ImageUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 38 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 38 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
AddHtmlAttributeValue("", 1883, image.Name, 1883, 11, false);

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
            BeginContext(1898, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "F:\HotelApplication\Areas\RoomInformation\Views\Booking\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1907, 19, true);
            WriteLiteral("</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1926, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1572695143f69bee259a3608e62ac1ae0af7abaa17660", async() => {
                BeginContext(1948, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1964, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
