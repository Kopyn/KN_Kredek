#pragma checksum "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a05fd44e3e6ca64af163de86e39fa369de6d5b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a05fd44e3e6ca64af163de86e39fa369de6d5b5", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4bd1abf96d3be6f1816b35edc16145ce26aa007", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Account>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 4 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
Write(Html.ActionLink("Dodaj", "Create", "Accounts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
         foreach (var account in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(a => account.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(a => account.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(a => account.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(a => account.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(a => account.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.DisplayFor(a => account.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.ActionLink("Edytuj", "Edit", "Accounts", routeValues: new { id = account.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 54 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
           Write(Html.ActionLink("Usuń", "Delete", "Accounts", routeValues: new { id = account.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\macko\source\repos\maciej_kopinski_cpc2021-1\Laboratorium 5\Zadanie domowe\MaciejKopinskiLab5ZadDom\MaciejKopinskiLab5ZadDom\Views\Accounts\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
