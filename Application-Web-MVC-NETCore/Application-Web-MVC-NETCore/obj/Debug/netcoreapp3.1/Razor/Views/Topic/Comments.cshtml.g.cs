#pragma checksum "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topic\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b7f8c53913ac47b65f84045b4ff8d06a2e4c00f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Comments), @"mvc.1.0.view", @"/Views/Topic/Comments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7f8c53913ac47b65f84045b4ff8d06a2e4c00f", @"/Views/Topic/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ac4b2615fc5113c97c25b8b2a2b776ca0ea319", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topic\Comments.cshtml"
  
    ViewData["Title"] = "Liste de commentaires";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Ici le contenu de la page est décrit en html -->\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n\r\n<p>Liste de commentaires</p>\r\n\r\n");
#nullable restore
#line 12 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topic\Comments.cshtml"
 for (var i = 0; i < Model.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"border: solid 1px black;\"><p>");
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topic\Comments.cshtml"
                                     Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><p>");
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topic\Comments.cshtml"
                                                           Write(Model[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>");
#nullable restore
#line 13 "D:\Cours\NET\Application-Web-MVC-NETCore\Application-Web-MVC-NETCore\Views\Topic\Comments.cshtml"
                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
