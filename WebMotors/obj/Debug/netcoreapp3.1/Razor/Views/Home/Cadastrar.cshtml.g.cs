#pragma checksum "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f1d94e9067036a818ecdbb6a714fb09afc9deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cadastrar), @"mvc.1.0.view", @"/Views/Home/Cadastrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f1d94e9067036a818ecdbb6a714fb09afc9deb", @"/Views/Home/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d40e4475dc043d9ff754566af91608bc4dc697", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMotors.Domain.Entities.Anuncio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
  
    ViewBag.Title = ":: WebMotors ::";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-13"">
    <h1 class=""page-header"">Anúncios</h1>
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">Cadastrar</div>
            <div class=""panel-body"">
                <div class=""row"">
                    <div class=""col-lg-10"">

");
#nullable restore
#line 19 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                         using (Html.BeginForm())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-horizontal\">\r\n                                ");
#nullable restore
#line 23 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 24 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                           Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 27 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                               Write(Html.Label("ID", "Marca", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-md-10\">\r\n                                        ");
#nullable restore
#line 29 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.DropDownListFor(model => model.Marca, new SelectList(ViewBag.Marcas, "ID", "Name"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 30 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Marca, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 35 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                               Write(Html.Label("ID", "Modelo", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <div class=""col-md-10"">

                                        <select class=""form-control"" id=""Modelo"" name=""Modelo"">                            </select>
                                        <span class=""field-validation-valid text-danger"" data-valmsg-for=""Modelo"" data-valmsg-replace=""true""></span>
                                    </div>
                                </div>


                                <div class=""form-group"">
                                    ");
#nullable restore
#line 45 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                               Write(Html.Label("ID", "Versao", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <div class=""col-md-10"">

                                        <select class=""form-control"" id=""Versao"" name=""Versao"">                            </select>
                                        <span class=""field-validation-valid text-danger"" data-valmsg-for=""Versao"" data-valmsg-replace=""true""></span>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    ");
#nullable restore
#line 54 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                               Write(Html.Label("Ano", "Ano", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-md-2\">\r\n                                        ");
#nullable restore
#line 56 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.EditorFor(model => model.Ano, new { htmlAttributes = new { @class = "form-control class-focusin" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 57 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Ano, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 62 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                               Write(Html.Label("Quilometragem", "Quilometragem", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-md-10\">\r\n                                        ");
#nullable restore
#line 64 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.EditorFor(model => model.Quilometragem, new { htmlAttributes = new { @class = "form-control class-focusin" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 65 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Quilometragem, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n\r\n                                <div class=\"form-group\">\r\n                                    ");
#nullable restore
#line 71 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                               Write(Html.Label("Observação", "Observação", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"col-md-10\">\r\n                                        ");
#nullable restore
#line 73 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.EditorFor(model => model.Observacao, new { htmlAttributes = new { @class = "form-control class-focusin" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 74 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Observacao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <div class=""col-md-offset-2 col-md-10"">
                                        <input type=""submit"" value=""Salvar"" name=""Cadastrar"" class=""btn btn-default"" />
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 84 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div>\r\n                            ");
#nullable restore
#line 87 "D:\Interviews\WebMotors\WebMotors\Views\Home\Cadastrar.cshtml"
                       Write(Html.ActionLink("Voltar", "Listar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>

    function AplicarMarca(id) {
        PopularModelos();
    }

    function PopularModelos() {
        $(""#Modelo"").empty();
        var marcaId = $(""#Marca"").val();

        $.ajax({
            type: ""GET"",
            url: ""/Home/ObterModelos/"" + marcaId,
            success: function (data) {
                $(""#Modelo"").empty();
                $.each(JSON.parse(data), function (index, element) {
                    $(""#Modelo"").append('<option value=""' + element.ID + '"">' + element.Name + '</option>');
                });

                PopularVersoes();
            }
        });
    }

    function PopularVersoes() {
        $(""#Versao"").empty();
        var modeloId = $(""#Modelo"").val();

        $.ajax({
            type: ""GET"",
            url: ""/Home/ObterVersoes/"" + modeloId,
            success: function (data) {");
            WriteLiteral(@"
                $(""#Versao"").empty();
                $.each(JSON.parse(data), function (index, element) {
                    $(""#Versao"").append('<option value=""' + element.ID + '"">' + element.Name + '</option>');
                });
            }
        });
    }

    $(document).ready(function () {
        AplicarMarca();

        $(""#Marca"").focusout(function () {
            PopularModelos();
        });

        $(""#Marca"").change(function () {
            PopularModelos();
        });

        $(""#Modelo"").focusout(function () {
            PopularVersoes();
        });

        $(""#Modelo"").change(function () {
            PopularVersoes();
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMotors.Domain.Entities.Anuncio> Html { get; private set; }
    }
}
#pragma warning restore 1591
