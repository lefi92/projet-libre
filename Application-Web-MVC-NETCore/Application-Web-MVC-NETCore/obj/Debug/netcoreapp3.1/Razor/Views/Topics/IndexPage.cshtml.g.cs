#pragma checksum "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a2495e1507bf95490e6a8365ae44a3404d2a5de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_IndexPage), @"mvc.1.0.view", @"/Views/Topics/IndexPage.cshtml")]
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
#line 1 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\_ViewImports.cshtml"
using Application_Web_MVC_NETCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\_ViewImports.cshtml"
using Application_Web_MVC_NETCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2495e1507bf95490e6a8365ae44a3404d2a5de", @"/Views/Topics/IndexPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ac4b2615fc5113c97c25b8b2a2b776ca0ea319", @"/Views/_ViewImports.cshtml")]
    public class Views_Topics_IndexPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
  
    ViewData["Title"] = "Liste de topics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Ici le contenu de la page est décrit en html -->\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Page 2</h1>\r\n</div>\r\n\r\n<p>Liste d\'articles</p>\r\n\r\n");
#nullable restore
#line 12 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
 for (var i = 0; i < Model.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\'", 254, "\'", 290, 1);
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
WriteAttributeValue("", 261, Url.Action("Index", "Topic"), 261, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p style=\"border: solid 1px black;\">");
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
                                                                        Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
                                                                                       Write(Model[i].titre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
                                                                                                         Write(Model[i].UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a>");
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
                                                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\'", 392, "\'", 433, 1);
#nullable restore
#line 15 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topics\IndexPage.cshtml"
WriteAttributeValue("", 399, Url.Action("IndexPage", "Topics"), 399, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\'button\' value=\'Page 3\' disabled />\r\n</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591