#pragma checksum "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 4\Zadanie domowe\MaciejKopinskiLab4ZadDom\MaciejKopinskiLab4ZadDom\Views\Home\SongLyricsFormSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeb27a62a2d2ad620c688098eaa521fd0427fc5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SongLyricsFormSummary), @"mvc.1.0.view", @"/Views/Home/SongLyricsFormSummary.cshtml")]
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
#line 1 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 4\Zadanie domowe\MaciejKopinskiLab4ZadDom\MaciejKopinskiLab4ZadDom\Views\_ViewImports.cshtml"
using MaciejKopinskiLab4ZadDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 4\Zadanie domowe\MaciejKopinskiLab4ZadDom\MaciejKopinskiLab4ZadDom\Views\_ViewImports.cshtml"
using MaciejKopinskiLab4ZadDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb27a62a2d2ad620c688098eaa521fd0427fc5a", @"/Views/Home/SongLyricsFormSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6976f3f6cebd2dee7cef03d6940c0aba7de6486", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SongLyricsFormSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div>\r\n    <h2>Tytuł: ");
#nullable restore
#line 9 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 4\Zadanie domowe\MaciejKopinskiLab4ZadDom\MaciejKopinskiLab4ZadDom\Views\Home\SongLyricsFormSummary.cshtml"
          Write(TempData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h4>\r\n        Wykonawca: ");
#nullable restore
#line 11 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 4\Zadanie domowe\MaciejKopinskiLab4ZadDom\MaciejKopinskiLab4ZadDom\Views\Home\SongLyricsFormSummary.cshtml"
              Write(TempData["Vocalist"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n    <h4>Słowa:</h4>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 362, 1);
#nullable restore
#line 14 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 4\Zadanie domowe\MaciejKopinskiLab4ZadDom\MaciejKopinskiLab4ZadDom\Views\Home\SongLyricsFormSummary.cshtml"
WriteAttributeValue("", 319, Url.Content(TempData["Lyrics"].ToString()), 319, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 363, "\"", 387, 1);
#nullable restore
#line 14 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 4\Zadanie domowe\MaciejKopinskiLab4ZadDom\MaciejKopinskiLab4ZadDom\Views\Home\SongLyricsFormSummary.cshtml"
WriteAttributeValue("", 369, TempData["Title"], 369, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n</div>");
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
