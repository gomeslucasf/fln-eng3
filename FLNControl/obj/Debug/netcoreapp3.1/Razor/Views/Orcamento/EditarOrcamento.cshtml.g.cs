#pragma checksum "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c6b0021973b99247848d379f02219b6fd31204c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orcamento_EditarOrcamento), @"mvc.1.0.view", @"/Views/Orcamento/EditarOrcamento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6b0021973b99247848d379f02219b6fd31204c", @"/Views/Orcamento/EditarOrcamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bc622b93c472f87161ec6c6b45c813c3aa16ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Orcamento_EditarOrcamento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FLNControl.Models.Transporte>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/View/Orcamento/orcamento.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
  
    ViewData["Title"] = "EditarOrcamento";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c6b0021973b99247848d379f02219b6fd31204c4999", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c6b0021973b99247848d379f02219b6fd31204c6152", async() => {
                WriteLiteral(@"
    <!-- Site wrapper -->
    <div class=""wrapper"">
        <!-- Navbar -->

        <div class=""content-wrapper"">
            <section class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-4"">
                            <h1>Editar Orçamento</h1>
                        </div>
                    </div>
                </div><!-- /.container-fluid -->
            </section>

            <!-- Main content -->
");
#nullable restore
#line 29 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
             using (Html.BeginForm("EditarOrcamento", "Orcamento", FormMethod.Post))
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c6b0021973b99247848d379f02219b6fd31204c7299", async() => {
                    WriteLiteral(@"
                    <div class=""row"" id=""corpoformulario"">
                        <div class=""col-md-12"">
                            <div class=""card card-primary"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Informações</h3>
                                </div>
                                <div class=""row"">

                                    <div class=""col-3"" >
                                        <label for=""nomeClienteForm"">Cliente *</label>
                                        <select class=""form-control"" name=""statusSelected"" >
                                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c6b0021973b99247848d379f02219b6fd31204c8257", async() => {
#nullable restore
#line 44 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
                                                                                              Write(Model.cliente.First().Nome);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
                                                        WriteLiteral(Model.cliente.First().Codigo);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                        </select>
                                    </div>

                                    <div class=""col-3"">
                                        <label for=""dataNascForm"">Data Vencimento *</label>
                                        <input type=""date"" id=""dataVencimento"" name=""dataVencimento"" class=""form-control required""");
                    BeginWriteAttribute("value", " value=\"", 2041, "\"", 2104, 1);
#nullable restore
#line 50 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
WriteAttributeValue("", 2049, Model.orcamento.Data_Validade.ToString("yyyy-MM-dd"), 2049, 55, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    </div>\n");
                    WriteLiteral(@"                                </div>

                                <div class=""row"">
                                    <div class=""col-12 form-group custom-control custom-checkbox"">
                                        <label>Produtos</label>
                                        <div class=""table-responsive"">
                                            <table class=""table"">
                                                <tbody>
");
#nullable restore
#line 71 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
                                                     foreach (var produto in Model.produto)
                                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                        <tr>\n                                                            <td><input type=\"text\" readonly name=\"listProdutos\"");
                    BeginWriteAttribute("value", " value=\"", 3659, "\"", 3685, 1);
#nullable restore
#line 74 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
WriteAttributeValue("", 3667, produto.Descricao, 3667, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\n                                                            <td name=\"tdValor\"><input readonly type=\"text\" name=\"valorVenda\"");
                    BeginWriteAttribute("value", " value=\"", 3819, "\"", 3846, 1);
#nullable restore
#line 75 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
WriteAttributeValue("", 3827, produto.ValorVenda, 3827, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\n                                                            <td><input type=\"number\" style=\"float-right\" name=\"quantidadeProdutos\"");
                    BeginWriteAttribute("id", " id=\"", 3986, "\"", 4026, 1);
#nullable restore
#line 76 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
WriteAttributeValue("", 3991, string.Concat("quant",@produto.Id), 3991, 35, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" onchange=\"alterarValorTotal()\"");
                    BeginWriteAttribute("value", " value=\"", 4058, "\"", 4085, 1);
#nullable restore
#line 76 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
WriteAttributeValue("", 4066, produto.quantidade, 4066, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" min=\"0\" /></td>\n                                                            <input type=\"hidden\" name=\"listIdsProdutos\"");
                    BeginWriteAttribute("value", " value=\"", 4206, "\"", 4225, 1);
#nullable restore
#line 77 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
WriteAttributeValue("", 4214, produto.Id, 4214, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\n                                                        </tr>\n");
#nullable restore
#line 79 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                                </tbody>
                                                <tfoot>
                                                    <tr>
                                                        <td class=""text-center"" colspan=""2"">Total</td>
                                                        <td class=""text-center"">R$ <label id=""lbTotal"">0.00</label></td>
                                                    </tr>
                                                </tfoot>
                                            </table>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <input type=""hidden"" name=""idOrcamento""");
                    BeginWriteAttribute("value", " value=\"", 5281, "\"", 5308, 1);
#nullable restore
#line 97 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
WriteAttributeValue("", 5289, Model.orcamento.Id, 5289, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\n                            <input type=\"submit\" value=\"Editar Orcamento\" class=\"btn btn-outline-primary float-right\" onclick=\"return confereInputs()\">\n                        </div>\n                    </div>\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 102 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Orcamento\EditarOrcamento.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <p>&nbsp;</p>
            <p id=""validate_message"">&nbsp;</p>
            <p>&nbsp;</p>
            <!-- /.content -->
        </div>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FLNControl.Models.Transporte> Html { get; private set; }
    }
}
#pragma warning restore 1591