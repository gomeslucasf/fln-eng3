#pragma checksum "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\GerirCaixa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68622ffc51a319e07971495b047fe4af09e1d2d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GerirCaixa_Index), @"mvc.1.0.view", @"/Views/GerirCaixa/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68622ffc51a319e07971495b047fe4af09e1d2d1", @"/Views/GerirCaixa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bc622b93c472f87161ec6c6b45c813c3aa16ed", @"/Views/_ViewImports.cshtml")]
    public class Views_GerirCaixa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<engenharia.Models.Caixa.Caixa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/View/GerirCaixa/abrirCaixa.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/View/GerirCaixa/movimentacao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\GerirCaixa\Index.cshtml"
  
    ViewData["TituloPagina"] = "Abrir Caixa";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68622ffc51a319e07971495b047fe4af09e1d2d14403", async() => {
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
                WriteLiteral("\n    <script src=\"https://igorescobar.github.io/jQuery-Mask-Plugin/js/jquery.mask.min.js\"></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68622ffc51a319e07971495b047fe4af09e1d2d15602", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        function getDate() {
            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!
            var yyyy = today.getFullYear();

            if (dd < 10) {
                dd = '0' + dd
            }
            if (mm < 10) {
                mm = '0' + mm
            }

            today = yyyy + '-' + mm + '-' + dd;
            console.log(today);
            document.getElementById(""inputDataAbertura"").value = today;
        }


        window.onload = function () {
            getDate();
        };
    </script>
");
            }
            );
            WriteLiteral(@"
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Abrir Caixa</h1>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card card-secondary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Informe:</h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <di");
            WriteLiteral(@"v class=""form-group"">
                            <label for=""dataAbertura"">Data Abertura * </label>
                            <input type=""date"" id=""inputDataAbertura"" class=""form-control required"" disabled>
                        </div>
                        <div class=""form-group"">
                            <label for=""inputSpentBudget"">Valor Disponibilizado: *</label>
                            <input type=""text"" id=""inputValorDisp"" class=""form-control required"">
                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <input type=""submit"" value=""Abrir Caixa"" class=""btn btn-success float-right""");
            BeginWriteAttribute("onclick", " onclick=\"", 2848, "\"", 2907, 6);
            WriteAttributeValue("", 2858, "abrirCaixa(\'", 2858, 12, true);
#nullable restore
#line 80 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\GerirCaixa\Index.cshtml"
WriteAttributeValue("", 2870, Model.valor_final, 2870, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2888, "\',", 2888, 2, true);
            WriteAttributeValue(" ", 2890, "\'", 2891, 2, true);
#nullable restore
#line 80 "C:\Users\Gomes\Desktop\faculdade\Eng3\ES2_EntregaFinal_FLNControl\flncontrol-main\FLNControl\Views\GerirCaixa\Index.cshtml"
WriteAttributeValue("", 2892, Model.status, 2892, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2905, "\')", 2905, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n        </div>\n    </section>\n<!-- /.content-wrapper -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<engenharia.Models.Caixa.Caixa> Html { get; private set; }
    }
}
#pragma warning restore 1591
