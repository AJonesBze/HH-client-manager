#pragma checksum "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15d6c1691d2473a3149dbbde09b6756d039b889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
#line 1 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\_ViewImports.cshtml"
using HH_client_manager;

#line default
#line hidden
#line 2 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\_ViewImports.cshtml"
using HH_client_manager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a15d6c1691d2473a3149dbbde09b6756d039b889", @"/Views/Clients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26626022f55dc4cc60e7198eccca8cab6e1e84bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HH_client_manager.Models.Client>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Client</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 42, false);
#line 14 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(292, 38, false);
#line 17 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(374, 40, false);
#line 20 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(414, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(458, 36, false);
#line 23 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Race));

#line default
#line hidden
            EndContext();
            BeginContext(494, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(538, 45, false);
#line 26 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ethnicity));

#line default
#line hidden
            EndContext();
            BeginContext(583, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(627, 41, false);
#line 29 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ethnicity));

#line default
#line hidden
            EndContext();
            BeginContext(668, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(712, 39, false);
#line 32 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(751, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(795, 35, false);
#line 35 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(830, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(874, 49, false);
#line 38 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PartnerGender));

#line default
#line hidden
            EndContext();
            BeginContext(923, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(967, 45, false);
#line 41 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.PartnerGender));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1056, 54, false);
#line 44 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RelationshipStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1154, 50, false);
#line 47 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.RelationshipStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1248, 48, false);
#line 50 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateEnrolled));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1340, 44, false);
#line 53 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateEnrolled));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1428, 49, false);
#line 56 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CounselorName));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1521, 45, false);
#line 59 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.CounselorName));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1610, 50, false);
#line 62 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GroupsAttended));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1704, 46, false);
#line 65 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.GroupsAttended));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1794, 62, false);
#line 68 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CouncelingSessionsAttended));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1900, 58, false);
#line 71 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.CouncelingSessionsAttended));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2002, 57, false);
#line 74 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MeetingsWithAdvocates));

#line default
#line hidden
            EndContext();
            BeginContext(2059, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2103, 53, false);
#line 77 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.MeetingsWithAdvocates));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2200, 44, false);
#line 80 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExitDate));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2288, 40, false);
#line 83 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExitDate));

#line default
#line hidden
            EndContext();
            BeginContext(2328, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2372, 56, false);
#line 86 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasHarkAssessmentPRE));

#line default
#line hidden
            EndContext();
            BeginContext(2428, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2472, 52, false);
#line 89 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasHarkAssessmentPRE));

#line default
#line hidden
            EndContext();
            BeginContext(2524, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2568, 57, false);
#line 92 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasHarkAssessmentPOST));

#line default
#line hidden
            EndContext();
            BeginContext(2625, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2669, 53, false);
#line 95 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasHarkAssessmentPOST));

#line default
#line hidden
            EndContext();
            BeginContext(2722, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2766, 55, false);
#line 98 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasPCLAssessmentPRE));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2865, 51, false);
#line 101 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasPCLAssessmentPRE));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2960, 56, false);
#line 104 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasPCLAssessmentPOST));

#line default
#line hidden
            EndContext();
            BeginContext(3016, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3060, 52, false);
#line 107 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasPCLAssessmentPOST));

#line default
#line hidden
            EndContext();
            BeginContext(3112, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3156, 59, false);
#line 110 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasShelterAssessmentPRE));

#line default
#line hidden
            EndContext();
            BeginContext(3215, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3259, 55, false);
#line 113 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasShelterAssessmentPRE));

#line default
#line hidden
            EndContext();
            BeginContext(3314, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3358, 60, false);
#line 116 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasShelterAssessmentPOST));

#line default
#line hidden
            EndContext();
            BeginContext(3418, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3462, 56, false);
#line 119 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasShelterAssessmentPOST));

#line default
#line hidden
            EndContext();
            BeginContext(3518, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3565, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "544368d95d6144cab8cc86c2ccd31e3c", async() => {
                BeginContext(3611, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 124 "C:\Users\Arianne Jones\Source\Repos\HH-client-manager\HH-client-manager\Views\Clients\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(3619, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3627, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4662a5134e04d27889ba8ea6ba700e6", async() => {
                BeginContext(3649, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(3665, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HH_client_manager.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
