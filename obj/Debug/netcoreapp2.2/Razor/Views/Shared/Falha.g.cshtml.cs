#pragma checksum "C:\Users\35883602800\Desktop\project-RoleTopMVC\Views\Shared\Falha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85e9f3820637dfa7d7e8e509cb9fe73a6078a027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Falha), @"mvc.1.0.view", @"/Views/Shared/Falha.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Falha.cshtml", typeof(AspNetCore.Views_Shared_Falha))]
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
#line 1 "C:\Users\35883602800\Desktop\project-RoleTopMVC\Views\_ViewImports.cshtml"
using project_RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\35883602800\Desktop\project-RoleTopMVC\Views\_ViewImports.cshtml"
using project_RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e9f3820637dfa7d7e8e509cb9fe73a6078a027", @"/Views/Shared/Falha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9346c35ab2aa533a85ce99e20e39341cea489f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Falha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<project_RoleTopMVC.ViewModels.RespostaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 29, true);
            WriteLiteral("<main>\r\n     <h2>\r\n          ");
            EndContext();
            BeginContext(86, 18, false);
#line 4 "C:\Users\35883602800\Desktop\project-RoleTopMVC\Views\Shared\Falha.cshtml"
     Write(ViewData["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(104, 91, true);
            WriteLiteral(" não tá feito, tu é burro men?\r\n     </h2>\r\n     <div id=\"mensagem-falha\">\r\n     <p>\r\n     ");
            EndContext();
            BeginContext(196, 14, false);
#line 8 "C:\Users\35883602800\Desktop\project-RoleTopMVC\Views\Shared\Falha.cshtml"
Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(210, 33, true);
            WriteLiteral("\r\n     </p>\r\n     </div>\r\n</main>");
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
