#pragma checksum "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d57003d46bb5a9a4a9fa88a0ba6fdf3fca850013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Delete), @"mvc.1.0.view", @"/Views/Directors/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57003d46bb5a9a4a9fa88a0ba6fdf3fca850013", @"/Views/Directors/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fdbbabff2de6e1cefa95af74e6acba1954ecde", @"/Views/_ViewImports.cshtml")]
    public class Views_Directors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Director>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
 using (Html.BeginForm("Delete", "Directors", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 7 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 10 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-12\">\r\n            Zostaną również usunięte poniższe filmy:\r\n        </dt>\r\n");
#nullable restore
#line 21 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
         foreach (var item in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 24 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
           Write(Html.DisplayNameFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
           Write(Html.DisplayFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 29 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Usuń\" class=\"btn btn-danger\" />\r\n");
#nullable restore
#line 33 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Director> Html { get; private set; }
    }
}
#pragma warning restore 1591