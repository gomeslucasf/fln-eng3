#pragma checksum "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9788c020bd91cec14c82f7a621a17121a59d612b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Visualizar), @"mvc.1.0.view", @"/Views/Venda/Visualizar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9788c020bd91cec14c82f7a621a17121a59d612b", @"/Views/Venda/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bc622b93c472f87161ec6c6b45c813c3aa16ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("f-parametros"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte3/plugins/toastr/toastr.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminlte3/plugins/toastr/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
  
    ViewData["TituloPagina"] = "Gerenciar Venda";
    ViewData["ClasseBody"] = "hold-transition register-page";
    Layout = "_LayoutDashboard";
    List<Object> Dados = ViewBag.Dados;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <!-- left column -->
    <div class=""col-md-12"">
        <!-- general form elements -->
        <div class=""card card-primary"">
            <div class=""card-header"">
                <h3 class=""card-title"">Visualizando Venda</h3>
            </div>
            <!-- /.card-header -->
            <!-- form start -->
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9788c020bd91cec14c82f7a621a17121a59d612b6061", async() => {
                WriteLiteral(@"
                <div class=""card-body"">
                    <div class=""form-group"">
                        <label for=""i-cpf""><b style=""color:red"">*</b> CPF</label>
                        <input type=""text"" class=""form-control"" id=""i-cpf"" maxlength=""14"" placeholder=""Insira o CPF do Cliente""");
                BeginWriteAttribute("value", " value=\"", 870, "\"", 887, 1);
#nullable restore
#line 21 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
WriteAttributeValue("", 878, Dados[3], 878, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                    <div class=""form-group"">
                        <label for=""i-nomecli""><b style=""color:red"">*</b> Nome do Cliente</label>
                        <input type=""text"" class=""form-control"" id=""i-nomecli"" placeholder=""Insira o Nome do Cliente""");
                BeginWriteAttribute("value", " value=\"", 1186, "\"", 1203, 1);
#nullable restore
#line 25 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
WriteAttributeValue("", 1194, Dados[2], 1194, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                    <div class=""form-group"">
                        <label for=""i-endereco""><b style=""color:red"">*</b> Endereço</label>
                        <input type=""text"" class=""form-control"" id=""i-endereco"" placeholder=""Insira o Endereço do Cliente""");
                BeginWriteAttribute("value", " value=\"", 1501, "\"", 1518, 1);
#nullable restore
#line 29 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
WriteAttributeValue("", 1509, Dados[4], 1509, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                    <div class=""form-group"">
                        <label for=""i-numero""><b style=""color:red"">*</b> Número</label>
                        <input type=""text"" class=""form-control"" id=""i-numero"" placeholder=""Insira o Número do Endereço do Cliente""");
                BeginWriteAttribute("value", " value=\"", 1820, "\"", 1837, 1);
#nullable restore
#line 33 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
WriteAttributeValue("", 1828, Dados[5], 1828, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                    <div class=""form-group"">
                        <label for=""i-bairro""><b style=""color:red"">*</b> Bairro</label>
                        <input type=""text"" class=""form-control"" id=""i-bairro"" placeholder=""Insira o Bairro do Endereço do Cliente""");
                BeginWriteAttribute("value", " value=\"", 2139, "\"", 2156, 1);
#nullable restore
#line 37 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
WriteAttributeValue("", 2147, Dados[6], 2147, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                    <div class=""form-group"">
                        <label for=""i-cidade""><b style=""color:red"">*</b> Cidade</label>
                        <input type=""text"" class=""form-control"" id=""i-cidade"" placeholder=""Insira a Cidade do Cliente""");
                BeginWriteAttribute("value", " value=\"", 2446, "\"", 2463, 1);
#nullable restore
#line 41 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
WriteAttributeValue("", 2454, Dados[7], 2454, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                    <div class=""form-group"">
                        <label for=""i-uf""><b style=""color:red"">*</b> UF</label>
                        <input type=""text"" class=""form-control"" id=""i-uf"" placeholder=""Insira a UF do Cliente""");
                BeginWriteAttribute("value", " value=\"", 2737, "\"", 2754, 1);
#nullable restore
#line 45 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
WriteAttributeValue("", 2745, Dados[8], 2745, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                    <hr />
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""card card-info"">
                                <div class=""card-header"">
                                    <div class=""row"">
                                        <div class=""col-md-11 col-sm-10"">
                                            <h3 class=""card-title"" style=""padding-top:6px"">Itens do pedido</h3>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <div class=""card"">
                                                <div class=""card-body table-responsive p-0"" style=""height: 200px;"">
                                       ");
                WriteLiteral(@"             <table class=""table table-head-fixed text-nowrap"" id=""tb-lista-produtos"">
                                                        <thead>
                                                            <tr>
                                                                <th>Produto</th>
                                                                <th>Quantidade</th>
                                                                <th>Preço Unitário</th>
                                                                <th>Valor Total</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
");
#nullable restore
#line 73 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                              
                                                                int valorTotalCompra = 0;
                                                                List<Object> itens = new List<Object>((IEnumerable<Object>)Dados[9]);
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                             foreach (var i in itens)
                                                            {
                                                                int valorTotalProd;
                                                                List<Object> pInfo = new List<Object>((IEnumerable<Object>)i);
                                                                valorTotalProd = Convert.ToInt32(pInfo[1]) * Convert.ToInt32(pInfo[0]);
                                                                valorTotalCompra += valorTotalProd;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                <tr>\n                                                                    <td>");
#nullable restore
#line 84 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                   Write(pInfo[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 85 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                   Write(pInfo[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 86 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                   Write(Convert.ToDecimal(pInfo[1]).ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 87 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                   Write(Convert.ToDecimal(valorTotalProd).ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                </tr>\n");
#nullable restore
#line 89 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                        </tbody>
                                                    </table>
                                                </div>
                                                <div class=""card-footer"">
                                                    <span>Total: </span>
                                                    <span id=""sp-total"">");
#nullable restore
#line 95 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                   Write(Convert.ToDecimal(valorTotalCompra).ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""card card-info"">
                                <div class=""card-header"">
                                    <div class=""row"">
                                        <div class=""col-md-11 col-sm-10"">
");
#nullable restore
#line 110 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                               
                                                string formaPagamento = "";
                                                switch(Convert.ToInt32(Dados[1]))
                                                {
                                                    case 1:
                                                        formaPagamento = "À Vista";
                                                        break;

                                                    case 2:
                                                        formaPagamento = "À Prazo";
                                                        break;
                                                }
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <h3 class=\"card-title\" style=\"padding-top:6px\">Forma de Pagamento: ");
#nullable restore
#line 123 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                                                          Write(formaPagamento);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <div class=""card"">
                                                <div class=""card-body table-responsive p-0"" style=""height: 200px;"">
                                                    <table class=""table table-head-fixed text-nowrap"" id=""tb-lista-produtos"">
                                                        <thead>
                                                            <tr>
                                                                <th>Data de Vencimento</th>
                                                                <th>Status</th>
                                                                <th>Valor</th>
                                 ");
                WriteLiteral("                           </tr>\n                                                        </thead>\n                                                        <tbody>\n");
#nullable restore
#line 141 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                              
                                                                List<Object> parcelas = new List<Object>((IEnumerable<Object>)Dados[10]);
                                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                 foreach (var p in parcelas)
                                                                {
                                                                    String status = "";
                                                                    List<Object> parcelaInfo = new List<Object>((IEnumerable<Object>)p);
                                                                    switch(Convert.ToInt32(parcelaInfo[1]))
                                                                    {
                                                                        case 0:
                                                                            status = "Pendente";
                                                                            break;

                                                                        case 1:
                                                                            status = "Pago";
                                                                            break;
                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <tr>\n                                                                        <td>");
#nullable restore
#line 158 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                       Write(Convert.ToDateTime(parcelaInfo[0]).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                        <td>");
#nullable restore
#line 159 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                       Write(status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                        <td>");
#nullable restore
#line 160 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                       Write(Convert.ToDecimal(parcelaInfo[2]).ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                                    </tr>\n");
#nullable restore
#line 162 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\Venda\Visualizar.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                        </tbody>
                                                    </table>
                                                </div>
                                                <div class=""card-footer"">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <button type=""button"" class=""btn btn-default"" onclick=""history.back()"">Cancelar</button>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9788c020bd91cec14c82f7a621a17121a59d612b26635", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9788c020bd91cec14c82f7a621a17121a59d612b27965", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
