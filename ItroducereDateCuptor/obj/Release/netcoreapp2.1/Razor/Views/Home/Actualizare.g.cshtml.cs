#pragma checksum "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a32e6781b6f4de2361d282ecb1e04f1c86824f7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Actualizare), @"mvc.1.0.view", @"/Views/Home/Actualizare.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Actualizare.cshtml", typeof(AspNetCore.Views_Home_Actualizare))]
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
#line 1 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\_ViewImports.cshtml"
using ItroducereDateCuptor;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\_ViewImports.cshtml"
using ItroducereDateCuptor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32e6781b6f4de2361d282ecb1e04f1c86824f7e", @"/Views/Home/Actualizare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436efc314568fed976042604cee31208c141ab58", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Actualizare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ItroducereDateCuptor.Blum>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalR.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
  
    ViewData["Title"] = "Actualizare";

#line default
#line hidden
            BeginContext(94, 79, true);
            WriteLiteral("\r\n<h2>Lista laminare</h2>\r\n\r\n\r\n<h3>Bare date afara: <span id=\"nrBareDateAfara\">");
            EndContext();
            BeginContext(174, 28, false);
#line 9 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
                                           Write(ViewBag.CounterBareDateAfara);

#line default
#line hidden
            EndContext();
            BeginContext(202, 98, true);
            WriteLiteral("</span></h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(301, 38, false);
#line 14 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(339, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(395, 44, false);
#line 17 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(439, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 41, false);
#line 20 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(536, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(592, 44, false);
#line 23 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(636, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(692, 44, false);
#line 26 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(736, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(792, 44, false);
#line 29 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Sectiune));

#line default
#line hidden
            EndContext();
            BeginContext(836, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(892, 43, false);
#line 32 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Lungime));

#line default
#line hidden
            EndContext();
            BeginContext(935, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(991, 47, false);
#line 35 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.Normalizare));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1094, 46, false);
#line 38 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1196, 43, false);
#line 41 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1295, 51, false);
#line 44 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
           Write(Html.DisplayNameFor(model => model.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 49 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(1451, 32, true);
            WriteLiteral("        <tbody id=\"corpTabel\">\r\n");
            EndContext();
#line 52 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1540, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1555, "\"", 1586, 1);
#line 54 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
WriteAttributeValue("", 1563, BackgroundColour(item), 1563, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1587, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1633, 37, false);
#line 56 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1670, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1738, 43, false);
#line 59 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1849, 40, false);
#line 62 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1957, 43, false);
#line 65 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2068, 43, false);
#line 68 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2179, 43, false);
#line 71 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sectiune));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2290, 42, false);
#line 74 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lungime));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 44, true);
            WriteLiteral("\r\n                </td>\r\n                <td");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2376, "\"", 2419, 1);
#line 76 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
WriteAttributeValue("", 2384, IsNormalisedBackgroundColour(item), 2384, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2420, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2444, 46, false);
#line 77 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.Normalizare));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2558, 45, false);
#line 80 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2671, 42, false);
#line 83 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(2713, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2781, 50, false);
#line 86 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 89 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
            }

#line default
#line hidden
            BeginContext(2890, 18, true);
            WriteLiteral("        </tbody>\r\n");
            EndContext();
#line 91 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
    }

#line default
#line hidden
            BeginContext(2915, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            BeginContext(3431, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3526, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3532, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c26411b8afd448678f8de494e36b42d1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3593, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3599, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8468f2ab78b40a3ad5db3629b90c0d9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3638, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3758, 230, true);
                WriteLiteral("    <script type=\"text/javascript\">\r\n        function autoRefreshPage() {\r\n            window.location = window.location.href;\r\n        }\r\n        setInterval(\'autoRefreshPage()\', 60000); // Resetare la 60 secunde\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
#line 94 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Actualizare.cshtml"
            
    public string BackgroundColour(Blum blum)
    {
        if (blum == null) return "";
        if (blum.IsDatAfara || blum.IsRetur)
            return "background_green";
        return "";
    }

    // Functie verificare daca se normalizeaza si schimba culoare backGround
    public string IsNormalisedBackgroundColour(Blum blum)
    {
        if (blum == null) return "";
        else if (blum.Normalizare == "N") return "background_violet";
        return "";
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ItroducereDateCuptor.Blum>> Html { get; private set; }
    }
}
#pragma warning restore 1591
