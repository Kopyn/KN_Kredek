#pragma checksum "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Manufacturers\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d733a2cde823cfad3a2677d29486428c0364c9df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manufacturers_Create), @"mvc.1.0.view", @"/Views/Manufacturers/Create.cshtml")]
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
#line 1 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\_ViewImports.cshtml"
using MaciejKopinskiLab5ZadDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\_ViewImports.cshtml"
using MaciejKopinskiLab5ZadDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d733a2cde823cfad3a2677d29486428c0364c9df", @"/Views/Manufacturers/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4bd1abf96d3be6f1816b35edc16145ce26aa007", @"/Views/_ViewImports.cshtml")]
    public class Views_Manufacturers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manufacturer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Manufacturers\Create.cshtml"
 using (Html.BeginForm("Create", "Manufacturers", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 6 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Manufacturers\Create.cshtml"
   Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 8 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Manufacturers\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Dodaj producenta\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 14 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Manufacturers\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manufacturer> Html { get; private set; }
    }
}
#pragma warning restore 1591
