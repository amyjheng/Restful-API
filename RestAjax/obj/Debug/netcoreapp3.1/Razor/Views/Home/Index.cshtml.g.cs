#pragma checksum "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4908e9dd7a52f061e464e89ca6da15acd765dc4"
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
#line 1 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\_ViewImports.cshtml"
using RestAjax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\_ViewImports.cshtml"
using RestAjax.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4908e9dd7a52f061e464e89ca6da15acd765dc4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380a4bc4fd2b879ff8d1b711191a089e3e28e7ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>


<table align=""center"">
    <tr>
        <td width=""300px"">
            <ul>
                M05
                <li><a");
            BeginWriteAttribute("href", " href=\"", 363, "\"", 397, 1);
#nullable restore
#line 16 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 370, Url.Action("Index", "M05"), 370, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Index</a></li>\r\n            </ul>\r\n            <ul>\r\n                M07\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 495, "\"", 534, 1);
#nullable restore
#line 20 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 502, Url.Action("XhrGetSync", "M07"), 502, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">XhrGetSync</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 579, "\"", 620, 1);
#nullable restore
#line 21 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 586, Url.Action("XhrGetASync1", "M07"), 586, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">XhrGetASync1</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 667, "\"", 703, 1);
#nullable restore
#line 22 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 674, Url.Action("XhrPost", "M07"), 674, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">XhrPost</a></li>\r\n            </ul>\r\n            <ul>\r\n                M08\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 803, "\"", 838, 1);
#nullable restore
#line 26 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 810, Url.Action("XhrXml", "M08"), 810, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">XhrXml</a></li>\r\n            </ul>\r\n            <ul>\r\n                M09\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 937, "\"", 973, 1);
#nullable restore
#line 30 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 944, Url.Action("XhrJson", "M09"), 944, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">XhrJson</a></li>\r\n            </ul>\r\n\r\n            <ul>\r\n                M10\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1075, "\"", 1112, 1);
#nullable restore
#line 35 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1082, Url.Action("FormData", "M10"), 1082, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">FormData</a></li>\r\n            </ul>\r\n            <ul>\r\n                M11\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1213, "\"", 1256, 1);
#nullable restore
#line 39 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1220, Url.Action("PromiseResolve", "M11"), 1220, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PromiseResolve</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1305, "\"", 1347, 1);
#nullable restore
#line 40 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1312, Url.Action("PromiseReject", "M11"), 1312, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PromiseReject</a></li>\r\n            </ul>\r\n            <ul>\r\n                M12\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1453, "\"", 1491, 1);
#nullable restore
#line 44 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1460, Url.Action("FetchJson", "M12"), 1460, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">FetchJson</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1535, "\"", 1575, 1);
#nullable restore
#line 45 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1542, Url.Action("FetchUpload", "M12"), 1542, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">FetchUpload</a></li>\r\n            </ul>\r\n        </td>\r\n        <td width=\"300px\">            \r\n            <ul>\r\n                M13\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1734, "\"", 1772, 1);
#nullable restore
#line 51 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1741, Url.Action("JQueryGet", "M13"), 1741, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">JQueryGet</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1816, "\"", 1855, 1);
#nullable restore
#line 52 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1823, Url.Action("JQueryPost", "M13"), 1823, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">JQueryPost</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1900, "\"", 1939, 1);
#nullable restore
#line 53 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1907, Url.Action("JQueryLoad", "M13"), 1907, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">JQueryLoad</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1984, "\"", 2026, 1);
#nullable restore
#line 54 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 1991, Url.Action("JQueryGetJson", "M13"), 1991, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">JQueryGetJson</a></li>\r\n            </ul>\r\n            <ul>\r\n                M14\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2132, "\"", 2176, 1);
#nullable restore
#line 58 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 2139, Url.Action("JQuerySerialize", "M14"), 2139, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">JQuerySerialize</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2226, "\"", 2267, 1);
#nullable restore
#line 59 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 2233, Url.Action("LoadingImage", "M14"), 2233, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">LoadingImage</a></li>\r\n            </ul>\r\n            <ul>\r\n                M15\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2372, "\"", 2409, 1);
#nullable restore
#line 63 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 2379, Url.Action("CheckAcc", "M15"), 2379, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">CheckAcc</a></li>\r\n            </ul>\r\n            <ul>\r\n                M16\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2510, "\"", 2542, 1);
#nullable restore
#line 67 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 2517, Url.Action("Rss", "M16"), 2517, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Rss</a></li>\r\n            </ul>\r\n            <ul>\r\n                M17\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2638, "\"", 2679, 1);
#nullable restore
#line 71 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 2645, Url.Action("AutoComplete", "M17"), 2645, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">AutoComplete</a></li>\r\n            </ul>\r\n            <ul>\r\n                M18\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2784, "\"", 2827, 1);
#nullable restore
#line 75 "D:\material\WebClient\AJAX\vs_webApp\RestAjax\RestAjax\Views\Home\Index.cshtml"
WriteAttributeValue("", 2791, Url.Action("AutoCompleteUI", "M18"), 2791, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">AutoCompleteUI</a></li>\r\n            </ul>\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
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