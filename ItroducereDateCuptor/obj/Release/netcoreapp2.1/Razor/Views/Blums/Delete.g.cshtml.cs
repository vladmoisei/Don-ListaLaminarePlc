#pragma checksum "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "543a003e0f88d7946e70b886d063fdc2ad99294f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blums_Delete), @"mvc.1.0.view", @"/Views/Blums/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blums/Delete.cshtml", typeof(AspNetCore.Views_Blums_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"543a003e0f88d7946e70b886d063fdc2ad99294f", @"/Views/Blums/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436efc314568fed976042604cee31208c141ab58", @"/Views/_ViewImports.cshtml")]
    public class Views_Blums_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItroducereDateCuptor.Blum>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Blum</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(244, 44, false);
#line 15 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(332, 40, false);
#line 18 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(372, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(416, 41, false);
#line 21 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(457, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(501, 37, false);
#line 24 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(582, 44, false);
#line 27 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(670, 40, false);
#line 30 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(754, 44, false);
#line 33 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(798, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(842, 40, false);
#line 36 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(926, 46, false);
#line 39 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(972, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1016, 42, false);
#line 42 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1102, 43, false);
#line 45 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1189, 39, false);
#line 48 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1272, 43, false);
#line 51 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRebut));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1359, 39, false);
#line 54 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsRebut));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1442, 51, false);
#line 57 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1537, 47, false);
#line 60 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1622, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3281af0b16c144c299fffca6b6e46d5b", async() => {
                BeginContext(1648, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1658, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec935230d5394ea9b3bc389e9db421a0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\User\Desktop\Programe cod sursa\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1694, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1778, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c39248b8ad24241b1f736f649b06dec", async() => {
                    BeginContext(1800, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1816, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1829, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItroducereDateCuptor.Blum> Html { get; private set; }
    }
}
#pragma warning restore 1591
