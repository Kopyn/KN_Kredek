#pragma checksum "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfba958e2b8c43bd5e93ee6ec247b61c4b7dc244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Index), @"mvc.1.0.view", @"/Views/Directors/Index.cshtml")]
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
#line 1 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\_ViewImports.cshtml"
using MaciejKopinskiLab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\_ViewImports.cshtml"
using MaciejKopinskiLab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfba958e2b8c43bd5e93ee6ec247b61c4b7dc244", @"/Views/Directors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fdbbabff2de6e1cefa95af74e6acba1954ecde", @"/Views/_ViewImports.cshtml")]
    public class Views_Directors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Director>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 4 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
Write(Html.ActionLink("Dodaj", "Create", "Directors"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
         foreach (var director in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => director.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => director.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => director.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
               Write(Html.ActionLink("Usu??", "Delete", "Directors", routeValues: new { directorId = director.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Director>> Html { get; private set; }
    }
}
#pragma warning restore 1591
