#pragma checksum "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ef968f75e178411157f6a7685124e4600f6cc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listar), @"mvc.1.0.view", @"/Views/Home/Listar.cshtml")]
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
#line 1 "D:\Interviews\WebMotors\WebMotors\Views\_ViewImports.cshtml"
using WebMotors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Interviews\WebMotors\WebMotors\Views\_ViewImports.cshtml"
using WebMotors.Service.Model.V1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ef968f75e178411157f6a7685124e4600f6cc6", @"/Views/Home/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d40e4475dc043d9ff754566af91608bc4dc697", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebMotors.Domain.Entities.Anuncio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
  
    ViewBag.Title = ":: WebMotors ::";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-12\">\r\n    <h1 class=\"page-header\">Anúncios</h1>\r\n</div>\r\n<div class=\"col-lg-12\">\r\n\r\n    <div class=\"row botao\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 248, "\"", 279, 1);
#nullable restore
#line 13 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
WriteAttributeValue("", 255, Url.Action("Cadastrar"), 255, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">
            <span class=""glyphicon glyphicon-plus-sign"" aria-hidden=""true""></span>
            Novo Anúncio
        </a>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-success"">
            <div class=""panel-heading"" style=""margin: 30px 20px; font-size: 18px; font-weight: 900;"">Lista</div>
            <div class=""panel-body"">
                <div class=""row"">
                    <div class=""container"">
                        <div class=""col-lg-10"">

                            <table class=""table table-responsive table-condensed"">
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 31 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                   Write(Html.DisplayName("Código"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 34 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                   Write(Html.Label("Marca"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 37 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                   Write(Html.Label("Modelo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 40 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                   Write(Html.Label("Versão"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 43 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                   Write(Html.Label("Ano"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 46 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                   Write(Html.Label("Quilometragem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 49 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                   Write(Html.Label("Observação"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>Ações</th>\r\n                                </tr>\r\n\r\n");
#nullable restore
#line 54 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 58 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 61 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 64 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 67 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Versao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 70 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 73 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Quilometragem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 76 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3590, "\"", 3639, 1);
#nullable restore
#line 79 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
WriteAttributeValue("", 3597, Url.Action("Editar",new { id = item.Id }), 3597, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">
                                                Editar
                                                <span class=""glyphicon glyphicon-pencil"" aria-hidden=""true""></span>
                                            </a>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 3936, "\"", 3985, 1);
#nullable restore
#line 83 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
WriteAttributeValue("", 3943, Url.Action("Excluir",new { id = item.Id}), 3943, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"">
                                                Excluir
                                                <span class=""glyphicon glyphicon-trash"" aria-hidden=""true""></span>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 89 "D:\Interviews\WebMotors\WebMotors\Views\Home\Listar.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebMotors.Domain.Entities.Anuncio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
