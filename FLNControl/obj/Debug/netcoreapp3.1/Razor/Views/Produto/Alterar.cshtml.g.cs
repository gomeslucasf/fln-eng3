#pragma checksum "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9059c78bc7e4de825ae31f733b7014cad717b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Alterar), @"mvc.1.0.view", @"/Views/Produto/Alterar.cshtml")]
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
#line 1 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\_ViewImports.cshtml"
using FLNControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\_ViewImports.cshtml"
using FLNControl.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9059c78bc7e4de825ae31f733b7014cad717b66", @"/Views/Produto/Alterar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bc622b93c472f87161ec6c6b45c813c3aa16ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Alterar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("f-cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte3/plugins/toastr/toastr.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("module"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/flncontrol/js/Produto.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte3/plugins/toastr/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
  
    ViewData["TituloPagina"] = "Alterar Produto";
    ViewData["ClasseBody"] = "hold-transition register-page";
    Layout = "_LayoutDashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <!-- left column -->\n    <div class=\"col-md-12\">\n        <!-- general form elements -->\n        <div class=\"card card-primary\">\n            <div class=\"card-header\">\n                <h3 class=\"card-title\">Visualizar Produto: ");
#nullable restore
#line 12 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
                                                      Write(ViewBag.Produto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
                                                                            Write(ViewBag.Produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n            </div>\n            <!-- /.card-header -->\n            <!-- form start -->\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9059c78bc7e4de825ae31f733b7014cad717b667399", async() => {
                WriteLiteral("\n                <div class=\"card-body\">\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 666, "\"", 693, 1);
#nullable restore
#line 18 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 674, ViewBag.Produto.Id, 674, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"i-prod-codigo\"/>\n                    <div class=\"form-group\">\n                        <label for=\"i-desc\">Descrição</label>\n                        <input type=\"text\" class=\"form-control\" id=\"i-desc\"");
                BeginWriteAttribute("value", " value=\"", 898, "\"", 932, 1);
#nullable restore
#line 21 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 906, ViewBag.Produto.Descricao, 906, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"i-categ\">Categoria</label>\n                        <input type=\"text\" class=\"form-control\" id=\"i-categ\"");
                BeginWriteAttribute("value", " value=\"", 1146, "\"", 1180, 1);
#nullable restore
#line 25 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 1154, ViewBag.Produto.Categoria, 1154, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"i-brand\">Marca</label>\n                        <input type=\"text\" class=\"form-control\" id=\"i-brand\"");
                BeginWriteAttribute("value", " value=\"", 1390, "\"", 1420, 1);
#nullable restore
#line 29 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 1398, ViewBag.Produto.Marca, 1398, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    <div class=""form-group"">
                        <label for=""i-valor-compra"">Valor de Compra</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">R$</span>
                            </div>
                            <input type=""text"" class=""form-control"" id=""i-valor-compra""");
                BeginWriteAttribute("value", " value=\"", 1878, "\"", 1914, 1);
#nullable restore
#line 37 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 1886, ViewBag.Produto.ValorCompra, 1886, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""i-valor-venda"">Valor de Compra</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">R$</span>
                            </div>
                            <input type=""text"" class=""form-control"" id=""i-valor-venda""");
                BeginWriteAttribute("value", " value=\"", 2401, "\"", 2436, 1);
#nullable restore
#line 46 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 2409, ViewBag.Produto.ValorVenda, 2409, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <button type=""button"" class=""btn btn-default"" onclick=""FLNProduto.telaConsultar()"">Cancelar</button>
                    <button type=""button"" class=""btn btn-success float-right"" onclick=""FLNProduto.alterar()"">Alterar</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e9059c78bc7e4de825ae31f733b7014cad717b6613660", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9059c78bc7e4de825ae31f733b7014cad717b6614990", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9059c78bc7e4de825ae31f733b7014cad717b6616175", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
