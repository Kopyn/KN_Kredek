#pragma checksum "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eef87505f470b2a2cc589fbd9511d00316aa485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Create), @"mvc.1.0.view", @"/Views/Directors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eef87505f470b2a2cc589fbd9511d00316aa485", @"/Views/Directors/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fdbbabff2de6e1cefa95af74e6acba1954ecde", @"/Views/_ViewImports.cshtml")]
    public class Views_Directors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Director>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Create.cshtml"
 using (Html.BeginForm("Create", "Directors", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Create.cshtml"
   Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 14 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Create.cshtml"
       Write(Html.TextBoxFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Create.cshtml"
   Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 20 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Create.cshtml"
       Write(Html.TextBoxFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <input type=\"submit\" value=\"Dodaj film\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 24 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Praca na laboratorium\MaciejKopinskiLab5\MaciejKopinskiLab5\Views\Directors\Create.cshtml"
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
