#pragma checksum "C:\Users\rapma\OneDrive\Área de Trabalho\project-RoleTopMVC\Views\Administrador\dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f249e01987f269a065689b7cd2adab1dcce1bb57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_dashboard), @"mvc.1.0.view", @"/Views/Administrador/dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/dashboard.cshtml", typeof(AspNetCore.Views_Administrador_dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f249e01987f269a065689b7cd2adab1dcce1bb57", @"/Views/Administrador/dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9346c35ab2aa533a85ce99e20e39341cea489f", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2419, true);
            WriteLiteral(@"<main>
     <h2>Dashboard</h2>

     <section id=""status-agendamentos"">
          <h3>Status dos Eventos</h3>
          <div id=""painel"">
               <div class=""box-status-solicitacoes aprovados"">
                    <h4>Aprovados</h4>
                    <p>7</p>
               </div>

               <div class=""box-status-solicitacoes pendentes"">
                    <h4>Pendentes</h4>
                    <p>7</p>
               </div>

               <div class=""box-status-solicitacoes reprovados"">
                    <h4>Reprovados</h4>
                    <p>7</p>
               </div>
          </div>
     </section>

     <section id=""lista-solicitacoes"">
          <h3>Lista de Solicitações</h3>
          <table>
               <thead>
                    <tr>
                         <th>Nome</th>
                         <th>Tema do Evento</th>
                         <th>Dia e Hora</th>
                         <th>Tipo do Evento</th>
                         <th>");
            WriteLiteral(@"Serviços</th>
                         <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    
               </thead>
               <tfoot>
                    <tr>
                         <td colspan=""7"">
                              <p>Pedidos atualizados em 12/12/2012 às 3:07</p>
                         </td>
                    </tr>
               </tfoot>

               <tbody>
                    <tr>
                         <td>Megan Fox</td>
                         <td>Casamento</td>
                         <td>11/05/2020 19:00</td>
                         <td>Privado</td>
                         <td>Som</td>
                         <td><a href=""#""><i class=""fas fa-check""></i></a></td>
                         <td><a href=""#""><i class=""fas fa-times""></i></a></td>
                    </tr>
                    <tr>
                         <td>Madame Villa Lobos</td>
                         <td>Show</td>
                         <td");
            WriteLiteral(@">12/09/2019 14:00</td>
                         <td>Público</td>
                         <td>Iluminação</td>
                         <td><a href=""#""><i class=""fas fa-check""></i></a></td>
                         <td><a href=""#""><i class=""fas fa-times""></i></a></td>
                    </tr>
               </tbody>
          </table>
     </section>

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
