#pragma checksum "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce1c1e8cc37a63539bc73bb6c3672ff80e5b82b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Create), @"mvc.1.0.view", @"/Views/Accounts/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce1c1e8cc37a63539bc73bb6c3672ff80e5b82b0", @"/Views/Accounts/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4bd1abf96d3be6f1816b35edc16145ce26aa007", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
 using (Html.BeginForm("Create", "Accounts", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 6 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 8 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 14 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 20 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 26 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
       Write(Html.TextBoxFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
   Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 32 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
       Write(Html.TextBoxFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Dodaj konto\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 37 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
