#pragma checksum "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fed01000075f9ca123c110a0e4620b5049a6a80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\_ViewImports.cshtml"
using Ejercicio_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\_ViewImports.cshtml"
using Ejercicio_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fed01000075f9ca123c110a0e4620b5049a6a80", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa696e8a67115f940008526a54bb94a08678e67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml"
         using (Html.BeginForm("Index", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card m-4\">\r\n                <div class=\"card-body\">                 \r\n");
#nullable restore
#line 10 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml"
                     for (int i = 1; i <= 10; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group float-left ml-2\">\r\n                            <input type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 429, "\"", 439, 2);
            WriteAttributeValue("", 434, "n", 434, 1, true);
#nullable restore
#line 13 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml"
WriteAttributeValue("", 435, i, 435, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 440, "\"", 463, 2);
            WriteAttributeValue("", 454, "Numero", 454, 6, true);
#nullable restore
#line 13 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 460, i, 461, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                        </div>\r\n");
#nullable restore
#line 15 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                </div>\r\n\r\n                <div class=\"card-footer\">\r\n                    <input type=\"button\" id=\"btnSubmit\" class=\"btn btn-primary float-right\" value=\"Guardar\">\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\user\Desktop\Nueva carpeta (4)\Ejercicio 1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
