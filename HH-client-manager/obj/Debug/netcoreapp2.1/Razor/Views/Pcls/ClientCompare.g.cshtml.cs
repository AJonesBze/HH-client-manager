#pragma checksum "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef48a91ae9ae6a3d6f44362be659fb5bc8a89cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pcls_ClientCompare), @"mvc.1.0.view", @"/Views/Pcls/ClientCompare.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pcls/ClientCompare.cshtml", typeof(AspNetCore.Views_Pcls_ClientCompare))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef48a91ae9ae6a3d6f44362be659fb5bc8a89cd", @"/Views/Pcls/ClientCompare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26626022f55dc4cc60e7198eccca8cab6e1e84bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Pcls_ClientCompare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HHclientmanager.Models.Pcl>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml"
  
    ViewData["Title"] = "ClientCompare";

#line default
#line hidden
            BeginContext(86, 77, true);
            WriteLiteral("\r\n<h2>PCL Client Comparison</h2>\r\n<p>Comparing the PCL Assessment of Client #");
            EndContext();
            BeginContext(164, 14, false);
#line 8 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml"
                                      Write(Model.ClientId);

#line default
#line hidden
            EndContext();
            BeginContext(178, 236, true);
            WriteLiteral(" to all Client\'s PCL Results.</p>\r\n\r\n<div>\r\n    <hr />\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    Comparing\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(415, 49, false);
#line 19 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml"
               Write(Html.DisplayNameFor(model => model.SeverityScore));

#line default
#line hidden
            EndContext();
            BeginContext(464, 148, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>\r\n                    Client # ");
            EndContext();
            BeginContext(613, 40, false);
#line 26 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml"
                        Write(Html.DisplayFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(653, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(721, 45, false);
#line 29 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml"
               Write(Html.DisplayFor(model => model.SeverityScore));

#line default
#line hidden
            EndContext();
            BeginContext(766, 181, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Client Avg\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(948, 21, false);
#line 37 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml"
               Write(ViewBag.SeverityScore);

#line default
#line hidden
            EndContext();
            BeginContext(969, 126, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        <td>\r\n        </td>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1095, "\"", 1134, 2);
            WriteAttributeValue("", 1102, "/Clients/Details/", 1102, 17, true);
#line 46 "C:\Users\dowdiem\Source\Repos\n00721843\HH-client-manager\HH-client-manager\Views\Pcls\ClientCompare.cshtml"
WriteAttributeValue("", 1119, Model.ClientId, 1119, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1135, 29, true);
            WriteLiteral(">Back to Client</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HHclientmanager.Models.Pcl> Html { get; private set; }
    }
}
#pragma warning restore 1591
