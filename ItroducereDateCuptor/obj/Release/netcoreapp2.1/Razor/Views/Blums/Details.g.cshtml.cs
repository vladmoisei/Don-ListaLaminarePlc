#pragma checksum "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a7abaaa2fa0a5487a49c6a139bd160fa4a15086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blums_Details), @"mvc.1.0.view", @"/Views/Blums/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blums/Details.cshtml", typeof(AspNetCore.Views_Blums_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a7abaaa2fa0a5487a49c6a139bd160fa4a15086", @"/Views/Blums/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436efc314568fed976042604cee31208c141ab58", @"/Views/_ViewImports.cshtml")]
    public class Views_Blums_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItroducereDateCuptor.Blum>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Blum</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(198, 44, false);
#line 14 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 40, false);
#line 17 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diametru));

#line default
#line hidden
            EndContext();
            BeginContext(326, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(370, 41, false);
#line 20 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(411, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(455, 37, false);
#line 23 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sarja));

#line default
#line hidden
            EndContext();
            BeginContext(492, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(536, 44, false);
#line 26 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(580, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(624, 40, false);
#line 29 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Furnizor));

#line default
#line hidden
            EndContext();
            BeginContext(664, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(708, 44, false);
#line 32 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(752, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(796, 40, false);
#line 35 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Calitate));

#line default
#line hidden
            EndContext();
            BeginContext(836, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(880, 46, false);
#line 38 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(926, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(970, 42, false);
#line 41 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDatAfara));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1056, 43, false);
#line 44 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1143, 39, false);
#line 47 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsRetur));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1226, 43, false);
#line 50 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRebut));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1313, 39, false);
#line 53 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsRebut));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1396, 51, false);
#line 56 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1491, 47, false);
#line 59 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataOraLaminare));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1585, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a3416e77fcb43fd892a23510b905229", async() => {
                BeginContext(1631, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\User\Desktop\Programe cod sursa\Don-Raport lista cuptor\Don-ListaLaminarePlc\ItroducereDateCuptor\Views\Blums\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1639, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1647, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "988a9d530be34c8d869ff0aca9765ee2", async() => {
                BeginContext(1669, 12, true);
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
            BeginContext(1685, 10, true);
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
