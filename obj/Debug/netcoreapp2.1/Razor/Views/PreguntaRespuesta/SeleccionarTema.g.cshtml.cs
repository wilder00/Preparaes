#pragma checksum "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9acb8c75d478f271bb1aa1e95794383fa597ce79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PreguntaRespuesta_SeleccionarTema), @"mvc.1.0.view", @"/Views/PreguntaRespuesta/SeleccionarTema.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PreguntaRespuesta/SeleccionarTema.cshtml", typeof(AspNetCore.Views_PreguntaRespuesta_SeleccionarTema))]
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
#line 2 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
using Preparaes.modelosDeUso;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acb8c75d478f271bb1aa1e95794383fa597ce79", @"/Views/PreguntaRespuesta/SeleccionarTema.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce90bbdeb45404ceef260baa92eefc34ee311bbb", @"/Views/_ViewImports.cshtml")]
    public class Views_PreguntaRespuesta_SeleccionarTema : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndicarTema>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 29, true);
            WriteLiteral("\r\n<h1>Seleccionar tema</h1>\r\n");
            EndContext();
            BeginContext(83, 24, false);
#line 6 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(107, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(203, 25, true);
            WriteLiteral("<div class=\"container\">\r\n");
            EndContext();
#line 13 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
      
        if(ViewBag.numero != null){

#line default
#line hidden
            BeginContext(273, 29, true);
            WriteLiteral("            <h1>El numero es ");
            EndContext();
            BeginContext(303, 14, false);
#line 15 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
                        Write(ViewBag.numero);

#line default
#line hidden
            EndContext();
            BeginContext(317, 8, true);
            WriteLiteral(" </h1>\r\n");
            EndContext();
#line 16 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
        }
    

#line default
#line hidden
#line 18 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
 using (Html.BeginForm()){
    

#line default
#line hidden
            BeginContext(554, 52, true);
            WriteLiteral("    <br/>\r\n    <label>Seleccionar el Tema:</label>\r\n");
            EndContext();
            BeginContext(611, 162, false);
#line 25 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
Write(Html.DropDownListFor(m => m.Id, 
                    ViewBag.temas as SelectList, 
                    null ,
                    new{@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(775, 52, true);
            WriteLiteral("    <br/>\r\n    <label>Seleccionar el modo:</label>\r\n");
            EndContext();
            BeginContext(832, 158, false);
#line 31 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
Write(Html.DropDownListFor(m => m.Modo, 
                    (SelectList)ViewBag.sel,null
                    ,
                    new{@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(992, 91, true);
            WriteLiteral("    <br/><br/><br/><br/>\r\n    <input class=\"form-control\" value=\"enviar\" type=\"submit\" />\r\n");
            EndContext();
#line 37 "D:\PROYECTOS\proyectos de visual studio\con visual code\Preparaes\Views\PreguntaRespuesta\SeleccionarTema.cshtml"
}   

#line default
#line hidden
            BeginContext(1089, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndicarTema> Html { get; private set; }
    }
}
#pragma warning restore 1591
