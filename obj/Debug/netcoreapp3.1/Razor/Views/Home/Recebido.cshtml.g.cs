#pragma checksum "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\Home\Recebido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e10bfb94bca799dd434ae701ad84337d941996f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Recebido), @"mvc.1.0.view", @"/Views/Home/Recebido.cshtml")]
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
#line 1 "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\_ViewImports.cshtml"
using TESTE_ENTREVISTA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\_ViewImports.cshtml"
using TESTE_ENTREVISTA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10bfb94bca799dd434ae701ad84337d941996f2", @"/Views/Home/Recebido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3838efadba021ff0c48a97e0209178947a297793", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Recebido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TESTE_ENTREVISTA.Models.Formulario>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\Home\Recebido.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e10bfb94bca799dd434ae701ad84337d941996f23505", async() => {
                WriteLiteral("\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e10bfb94bca799dd434ae701ad84337d941996f24483", async() => {
                WriteLiteral("\r\n        <p>");
#nullable restore
#line 12 "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\Home\Recebido.cshtml"
      Write(Model.nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 13 "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\Home\Recebido.cshtml"
      Write(Model.telefone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 14 "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\Home\Recebido.cshtml"
      Write(Model.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 15 "C:\Users\Ricardo\Desktop\TESTE ENTREVISTA1\TESTE ENTREVISTA\Views\Home\Recebido.cshtml"
      Write(Model.mensagem);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>Olá, bem vindo e obrigado pelos dados.</p>    \r\n\r\n\r\n\r\n        <!--Nome/Telefone/Email/Mensagem, com um botão Enviar -->\r\n\r\n        <a href=\"/home/index\">Voltar ao formulario.</a>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TESTE_ENTREVISTA.Models.Formulario> Html { get; private set; }
    }
}
#pragma warning restore 1591