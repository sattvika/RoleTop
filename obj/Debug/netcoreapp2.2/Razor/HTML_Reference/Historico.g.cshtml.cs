#pragma checksum "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57daef3dd180eb4d6b9c47ef6b6945898daa2949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.HTML_Reference_Historico), @"mvc.1.0.view", @"/HTML_Reference/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/HTML_Reference/Historico.cshtml", typeof(AspNetCore.HTML_Reference_Historico))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57daef3dd180eb4d6b9c47ef6b6945898daa2949", @"/HTML_Reference/Historico.cshtml")]
    public class HTML_Reference_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
  
ViewData["Title"] = "Pedidos - McBonald's";
ViewData["H2"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(94, 14, true);
            WriteLiteral("\r\n<main>\r\n<h2>");
            EndContext();
            BeginContext(109, 14, false);
#line 7 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 220, true);
            WriteLiteral("</h2>\r\n<table>\r\n     <thead>\r\n          <tr>\r\n               <th>Data</th>\r\n               <th>Hamburguer</th>\r\n               <th>Shake</th>\r\n               <th>Preço</th>\r\n          </tr>\r\n     </thead>\r\n     <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
           foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(396, 40, true);
            WriteLiteral("               <tr>\r\n               <td>");
            EndContext();
            BeginContext(437, 19, false);
#line 20 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
              Write(pedido.DataDoPedido);

#line default
#line hidden
            EndContext();
            BeginContext(456, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(483, 22, false);
#line 21 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
              Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(505, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(532, 17, false);
#line 22 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
              Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(549, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(576, 17, false);
#line 23 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
              Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(593, 29, true);
            WriteLiteral("</td>\r\n               </tr>\r\n");
            EndContext();
#line 25 "C:\Users\35883602800\Desktop\project-RoleTopMVC\HTML_Reference\Historico.cshtml"
          }

#line default
#line hidden
            BeginContext(635, 34, true);
            WriteLiteral("     </tbody>\r\n</table>\r\n\r\n</main>");
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