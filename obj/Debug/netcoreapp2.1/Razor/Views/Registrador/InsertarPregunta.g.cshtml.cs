#pragma checksum "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b52bc61d0b8c65849b12317caf98e8b228a52a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registrador_InsertarPregunta), @"mvc.1.0.view", @"/Views/Registrador/InsertarPregunta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registrador/InsertarPregunta.cshtml", typeof(AspNetCore.Views_Registrador_InsertarPregunta))]
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
#line 1 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\_ViewImports.cshtml"
using PREPARAES;

#line default
#line hidden
#line 2 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\_ViewImports.cshtml"
using PREPARAES.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b52bc61d0b8c65849b12317caf98e8b228a52a", @"/Views/Registrador/InsertarPregunta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce90bbdeb45404ceef260baa92eefc34ee311bbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Registrador_InsertarPregunta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pregunta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 30, true);
            WriteLiteral("\r\n<h2>Insertar Pregunta</h2>\r\n");
            EndContext();
            BeginContext(48, 24, false);
#line 4 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
 using (Html.BeginForm())
{
    


#line default
#line hidden
            BeginContext(114, 60, true);
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Pregunta:</label>\r\n    ");
            EndContext();
            BeginContext(174, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3560e70d42ac4ce080e394a1a9144fd7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 12 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PreguntaString);

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
            BeginContext(241, 80, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    <label>Respuesta Correcta:</label>\r\n    ");
            EndContext();
            BeginContext(322, 71, false);
#line 16 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
Write(Html.TextAreaFor(m => m.RptaCorrecta,4,4, new{@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(393, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(405, 75, true);
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Respuestas incorrecta 1:</label>\r\n    ");
            EndContext();
            BeginContext(481, 74, false);
#line 21 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
Write(Html.TextAreaFor(m => m.RptaIncorrecta1,4,4, new{@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(555, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(567, 75, true);
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Respuestas incorrecta 2:</label>\r\n    ");
            EndContext();
            BeginContext(643, 74, false);
#line 26 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
Write(Html.TextAreaFor(m => m.RptaIncorrecta2,4,4, new{@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(717, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(729, 56, true);
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Tipo:</label>\r\n    ");
            EndContext();
            BeginContext(785, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "773d8643a9ff47458027b1158209cc37", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 31 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tipo);

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
            BeginContext(842, 76, true);
            WriteLiteral("\r\n    <small class=\"\">es para agrupar por tipo de Pregunta</small>\r\n</div>\r\n");
            EndContext();
            BeginContext(920, 58, true);
            WriteLiteral("<div class=\"form-group\">\r\n    <label>Sesion:</label>\r\n    ");
            EndContext();
            BeginContext(978, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a76eca4a044a8b91962f95c54c02b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 37 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SesionId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 37 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Sesiones;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1064, 23, true);
            WriteLiteral("\r\n           \r\n</div>\r\n");
            EndContext();
            BeginContext(1089, 42, true);
            WriteLiteral("<button type=\"submit\">Registrar</button>\r\n");
            EndContext();
#line 42 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\Registrador\InsertarPregunta.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pregunta> Html { get; private set; }
    }
}
#pragma warning restore 1591
