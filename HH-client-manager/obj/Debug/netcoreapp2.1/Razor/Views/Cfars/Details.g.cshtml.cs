#pragma checksum "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9a1f884c4c26e04d8b166a0e64beef205f4494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cfars_Details), @"mvc.1.0.view", @"/Views/Cfars/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cfars/Details.cshtml", typeof(AspNetCore.Views_Cfars_Details))]
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
#line 1 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\_ViewImports.cshtml"
using HH_client_manager;

#line default
#line hidden
#line 2 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\_ViewImports.cshtml"
using HH_client_manager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9a1f884c4c26e04d8b166a0e64beef205f4494", @"/Views/Cfars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26626022f55dc4cc60e7198eccca8cab6e1e84bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Cfars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HHclientmanager.Models.Cfar>
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 11, true);
            WriteLiteral("\r\n<h2>CFAR ");
            EndContext();
            BeginContext(93, 38, false);
#line 7 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
    Write(Html.DisplayFor(model => model.CfarId));

#line default
#line hidden
            EndContext();
            BeginContext(131, 94, true);
            WriteLiteral(" Details</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(226, 43, false);
#line 13 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Anxiety));

#line default
#line hidden
            EndContext();
            BeginContext(269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(313, 39, false);
#line 16 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Anxiety));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(396, 51, false);
#line 19 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TraumaticStress));

#line default
#line hidden
            EndContext();
            BeginContext(447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(491, 47, false);
#line 22 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayFor(model => model.TraumaticStress));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(582, 46, false);
#line 25 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Depression));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 42, false);
#line 28 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Depression));

#line default
#line hidden
            EndContext();
            BeginContext(714, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(758, 53, false);
#line 31 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmotionalityIndex));

#line default
#line hidden
            EndContext();
            BeginContext(811, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(855, 49, false);
#line 34 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmotionalityIndex));

#line default
#line hidden
            EndContext();
            BeginContext(904, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(948, 42, false);
#line 37 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client));

#line default
#line hidden
            EndContext();
            BeginContext(990, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1034, 47, false);
#line 40 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1128, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e6530ff0584586ae150060853c93eb", async() => {
                BeginContext(1178, 4, true);
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
#line 45 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Cfars\Details.cshtml"
                           WriteLiteral(Model.CfarId);

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
            BeginContext(1186, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1194, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bb68895a86b4507a8af4e1062116f31", async() => {
                BeginContext(1216, 12, true);
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
            BeginContext(1232, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HHclientmanager.Models.Cfar> Html { get; private set; }
    }
}
#pragma warning restore 1591
