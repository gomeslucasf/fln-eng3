#pragma checksum "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Fornecedor\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f47ed95b9efc0f8febc2ec4666e062fc6888a97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedor_Cadastrar), @"mvc.1.0.view", @"/Views/Fornecedor/Cadastrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f47ed95b9efc0f8febc2ec4666e062fc6888a97", @"/Views/Fornecedor/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bc622b93c472f87161ec6c6b45c813c3aa16ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedor_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/View/Fornecedor/Cadastrar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Fornecedor\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(" \n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f47ed95b9efc0f8febc2ec4666e062fc6888a974647", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral(@"
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card card-primary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Cadastro Completo de Cliente</h3>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f47ed95b9efc0f8febc2ec4666e062fc6888a976158", async() => {
                WriteLiteral(@"
                        <div class=""card-body"">
                            <div id=""corpoformulario"" class=""row"">
                                <div class=""col-md-6 form-group"">
                                    <label for=""inputNome"">Nome</label>
                                    <input type=""text"" class=""form-control"" id=""inputNome"" placeholder=""Nome..."">
                                </div>
                                <div class=""col-md-6 form-group"">
                                    <label for=""inputCpf"">CNPJ</label>
                                    <input type=""text"" class=""form-control"" id=""inputCpf"" placeholder=""Digite o CNPJ"">
                                </div>
                                <div class=""col-md-4 form-group"">
                                    <label for=""inputTelefone"">Telefone</label>
                                    <input type=""text"" class=""form-control"" id=""inputTelefone"" placeholder=""(DD) 9 0000-0000"">
                                </div>
          ");
                WriteLiteral(@"                      <div class=""col-md-4 form-group"">
                                    <label for=""inputEmail"">Email</label>
                                    <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""empresa@empresa.com.br"">
                                </div>
                                <div class=""col-md-4 form-group"">
                                    <label for=""inputSite"">Site</label>
                                    <input type=""text"" class=""form-control"" id=""inputSite"" placeholder=""Empresa.com.br"">
                                </div>
                                <div class=""col-md-4 form-group"">
                                    <label for=""inputNomeVendedor"">Nome Vendedor</label>
                                    <input type=""text"" class=""form-control"" id=""inputNomeVendedor"" placeholder=""Nome do Vendedor..."">
                                </div>
                                <div class=""col-md-4 form-group"">
                                ");
                WriteLiteral(@"    <label for=""inputTelefoneVendedor"">Telefone Vendedor</label>
                                    <input type=""text"" class=""form-control"" id=""inputTelefoneVendedor"" placeholder=""(DD) 9 0000-0000"">
                                </div>


                            </div>
                        </div>
                        <div class=""card-footer"">
                            <a class=""btn btn-primary text-white"" onclick=""Cadastrar.GravarCliente()"">Gravar</a>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
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