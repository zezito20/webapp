#pragma checksum "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\Burguer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a267743e5cf48ee927fb42bef1d27a13838b7bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Burguer_Details), @"mvc.1.0.view", @"/Views/Burguer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Burguer/Details.cshtml", typeof(AspNetCore.Views_Burguer_Details))]
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
#line 1 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\_ViewImports.cshtml"
using burguerwebapp.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\_ViewImports.cshtml"
using burguerwebapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a267743e5cf48ee927fb42bef1d27a13838b7bb", @"/Views/Burguer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5fd523af6e5865f7b446f9d2630894c0198100c", @"/Views/_ViewImports.cshtml")]
    public class Views_Burguer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Burguer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(23, 10, false);
#line 3 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\Burguer\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(33, 44, true);
            WriteLiteral("</h3>\r\n\r\n\r\n<div class=\"thumbnail\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 77, "\"", 94, 1);
#line 7 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\Burguer\Details.cshtml"
WriteAttributeValue("", 83, Model.Name, 83, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 95, "\"", 116, 1);
#line 7 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\Burguer\Details.cshtml"
WriteAttributeValue("", 101, Model.ImageUrl, 101, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(117, 66, true);
            WriteLiteral(">\r\n    <div class=\"caption-full\">\r\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(184, 11, false);
#line 9 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\Burguer\Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(195, 45, true);
            WriteLiteral("</h3>\r\n        <h3>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(241, 10, false);
#line 11 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\Burguer\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(251, 32, true);
            WriteLiteral("</a>\r\n        </h3>\r\n        <p>");
            EndContext();
            BeginContext(284, 17, false);
#line 13 "C:\Users\Admin\burguerwebapp\burguerwebapp\burguerwebapp\Views\Burguer\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(301, 28, true);
            WriteLiteral("</p>\r\n    </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Burguer> Html { get; private set; }
    }
}
#pragma warning restore 1591
