#pragma checksum "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\Cliente\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6606a51b34dc9f03e8a60d1657dc6bb742381f33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Login), @"mvc.1.0.view", @"/Views/Cliente/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Login.cshtml", typeof(AspNetCore.Views_Cliente_Login))]
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
#line 1 "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\_ViewImports.cshtml"
using project_RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\_ViewImports.cshtml"
using project_RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6606a51b34dc9f03e8a60d1657dc6bb742381f33", @"/Views/Cliente/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9346c35ab2aa533a85ce99e20e39341cea489f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<project_RoleTopMVC.ViewModels.RespostaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 65, true);
            WriteLiteral("\r\n<main>\r\n     <h2> Faça o evento mais top do ano! </h2>\r\n\r\n     ");
            EndContext();
            BeginContext(121, 751, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7296b54ebf634ccea7723dfbfdea6797", async() => {
                BeginContext(182, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 8 "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\Cliente\Login.cshtml"
           if(!string.IsNullOrEmpty(@Model.Mensagem)){

#line default
#line hidden
                BeginContext(242, 18, true);
                WriteLiteral("               <p>");
                EndContext();
                BeginContext(261, 14, false);
#line 9 "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\Cliente\Login.cshtml"
             Write(Model.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(275, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 10 "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\Cliente\Login.cshtml"
          }

#line default
#line hidden
                BeginContext(294, 466, true);
                WriteLiteral(@"          <div>
               <label for=""email"">Email</label>
               <br />
               <input type=""email"" id=""email"" name=""email"" required>
          </div>


          <div>
               <label for=""senha"">Senha</label>
               <br />
               <input type=""password"" id=""senha"" name=""senha"" required>
          </div>

          <input type=""submit"" value=""Entrar"">

          <div id=""link-cadastro"">
               <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\'", 760, "\'", 800, 1);
#line 27 "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\Cliente\Login.cshtml"
WriteAttributeValue("", 768, Url.Action("Index", "Cadastro"), 768, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(801, 64, true);
                WriteLiteral(">Não tem Login? Quero me cadastrar.</a>\r\n          </div>\r\n     ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 6 "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\Cliente\Login.cshtml"
AddHtmlAttributeValue("", 149, Url.Action("Login", "Cliente"), 149, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(872, 9, true);
            WriteLiteral("\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<project_RoleTopMVC.ViewModels.RespostaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
