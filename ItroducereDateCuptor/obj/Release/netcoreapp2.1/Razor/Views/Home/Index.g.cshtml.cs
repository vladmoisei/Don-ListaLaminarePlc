#pragma checksum "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06b1577b89c98d0311829fb3b2b2fd638d438e29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\_ViewImports.cshtml"
using ItroducereDateCuptor;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\_ViewImports.cshtml"
using ItroducereDateCuptor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06b1577b89c98d0311829fb3b2b2fd638d438e29", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436efc314568fed976042604cee31208c141ab58", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ItroducereDateCuptor.Blum>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ImportFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalR.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(92, 46, true);
            WriteLiteral("\r\n<div id=\"formularButoane\" class=\"row\">\r\n    ");
            EndContext();
            BeginContext(138, 1248, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10c39febeef44f928a1bf57a34a23e30", async() => {
                BeginContext(234, 1145, true);
                WriteLiteral(@"
        <div class=""form-group col-lg-3"">
            <div class=""col-md-10"">
                <p>Apasa butonul de mai jos pentru a da afara urmatoarea bucata:</p>
                <input type=""submit"" value=""Laminare"" formaction=""Home/IntroducereInLaminare"" />
            </div>
        </div>
        <div class=""form-group col-lg-3"">
            <div class=""col-md-10"">
                <p>Apasa butonul de mai jos pentru a da retur urmatoarea bucata:</p>
                <input type=""submit"" value=""Retur"" formaction=""Home/ReturBlum"" />
            </div>
        </div>
        <div class=""form-group col-lg-3"">
            <div class=""col-md-10"">
                <p>Apasa butonul de mai jos pentru a reseta counterul de bare:</p>
                <input type=""submit"" value=""Reset counter"" formaction=""Home/ResetCountBar"" />
            </div>
        </div>
        <div class=""form-group col-lg-3"">
            <div class=""col-md-10"">
                <p>Pentru ascundere comenzi botoane apasa buto");
                WriteLiteral("nul:</p>\r\n                <button id=\"butonAscundere\">Acundere butoane</button>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1386, 58, true);
            WriteLiteral("\r\n</div>\r\n<h3>Bare date afara: <span id=\"nrBareDateAfara\">");
            EndContext();
            BeginContext(1445, 28, false);
#line 34 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                                           Write(ViewBag.CounterBareDateAfara);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 98, true);
            WriteLiteral("</span></h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1572, 38, false);
#line 39 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1666, 44, false);
#line 42 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1766, 41, false);
#line 45 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1863, 44, false);
#line 48 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1963, 44, false);
#line 51 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(2007, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2063, 46, false);
#line 54 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2165, 43, false);
#line 57 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(2208, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2264, 51, false);
#line 60 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(2315, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 65 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(2420, 32, true);
            WriteLiteral("        <tbody id=\"corpTabel\">\r\n");
            EndContext();
#line 68 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2509, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2528, "\"", 2559, 1);
#line 70 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
WriteAttributeValue("", 2536, BackgroundColour(item), 2536, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2560, 53, true);
            WriteLiteral(">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2614, 37, false);
#line 72 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2651, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2731, 43, false);
#line 75 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(2774, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2854, 40, false);
#line 78 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(2894, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2974, 43, false);
#line 81 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(3017, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3097, 43, false);
#line 84 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(3140, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3220, 45, false);
#line 87 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(3265, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3345, 42, false);
#line 90 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(3387, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3467, 50, false);
#line 93 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(3517, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 96 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3584, 18, true);
            WriteLiteral("        </tbody>\r\n");
            EndContext();
#line 98 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3609, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            BeginContext(3815, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3910, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3916, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cadb69b0394023b326c8318b7c6712", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3977, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3983, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03e763cd27674792be4e227dbcc8088e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4022, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4028, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4adc03f0c8d54ff1bfe375ca3d4cbb67", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4064, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
#line 101 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Home\Index.cshtml"
            
public string BackgroundColour(Blum blum)
{
    if (blum == null) return "";
    if (blum.IsDatAfara || blum.IsRetur)
        return "background_green";
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
