#pragma checksum "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618cf6c136347d298129e26224a37b4c26a211b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blums_Index), @"mvc.1.0.view", @"/Views/Blums/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blums/Index.cshtml", typeof(AspNetCore.Views_Blums_Index))]
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
#line 1 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\_ViewImports.cshtml"
using ItroducereDateCuptor;

#line default
#line hidden
#line 2 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\_ViewImports.cshtml"
using ItroducereDateCuptor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618cf6c136347d298129e26224a37b4c26a211b0", @"/Views/Blums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436efc314568fed976042604cee31208c141ab58", @"/Views/_ViewImports.cshtml")]
    public class Views_Blums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ItroducereDateCuptor.Blum>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportToExcelAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:whitesmoke; background-color:orangered; border-radius: 5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(119, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed9b7d744d0f408bb6c0a06edb247679", async() => {
                BeginContext(142, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(156, 17, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(173, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ae8706d7bed4de8bec02909b5d9b5a3", async() => {
                BeginContext(243, 23, true);
                WriteLiteral("Exporta in fisier Excel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(270, 17, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(287, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acb1195269b439ba1dd9070d0ab29d7", async() => {
                BeginContext(421, 29, true);
                WriteLiteral("Stergere totala lista blumuri");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(454, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 44, false);
#line 22 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(591, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(647, 41, false);
#line 25 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(688, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(744, 44, false);
#line 28 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(788, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(844, 44, false);
#line 31 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(888, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(944, 46, false);
#line 34 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(990, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1046, 43, false);
#line 37 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1145, 43, false);
#line 40 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsRebut));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1244, 51, false);
#line 43 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(1295, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1413, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1462, 43, false);
#line 52 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1561, 40, false);
#line 55 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1657, 43, false);
#line 58 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1756, 43, false);
#line 61 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1855, 45, false);
#line 64 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(1900, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1956, 42, false);
#line 67 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2054, 42, false);
#line 70 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsRebut));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2152, 50, false);
#line 73 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(2202, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2257, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f97c6ac485b4841b0f4c96fb7a917e1", async() => {
                BeginContext(2302, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2310, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2330, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febef3da9c984a73849da2b75ac582d5", async() => {
                BeginContext(2378, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2389, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2409, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5534b113e944f6b5b4589cca642280", async() => {
                BeginContext(2456, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2466, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\IA\Desktop\Proiecte in lucru\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2505, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ItroducereDateCuptor.Blum>> Html { get; private set; }
    }
}
#pragma warning restore 1591
