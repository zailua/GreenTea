#pragma checksum "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a26a1696322d2b0eeb416c0fe9f562962e378dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receitas_Details), @"mvc.1.0.view", @"/Views/Receitas/Details.cshtml")]
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
#line 1 "C:\estudos\repoRecode2\greentea\greenTea\Views\_ViewImports.cshtml"
using greenTea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\estudos\repoRecode2\greentea\greenTea\Views\_ViewImports.cshtml"
using greenTea.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a26a1696322d2b0eeb416c0fe9f562962e378dd", @"/Views/Receitas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08745e4d6690ee6e2a797dd012858b65c3dbb8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Receitas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<greenTea.Models.Receita>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info  align-content-center p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
  
    ViewData["Title"] = "Receitas";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n<div class=\"container mb-5\">\n\n\n    <div>\n        <div class=\"row\">\n            <h2 class=\"col-10\">Receitas</h2>\n            <div class=\"col-2\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a26a1696322d2b0eeb416c0fe9f562962e378dd5716", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            \n        </div>\n\n        <hr />\n\n\n\n        <div class=\"page blog-post-list\">\n            <section class=\"clean-block clean-blog-list dark\">\n                <div");
            BeginWriteAttribute("class", " class=\"", 521, "\"", 529, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"block-heading\">\n                        <h1 class=\"text-info\">");
#nullable restore
#line 31 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.NomeReceita));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <p>");
#nullable restore
#line 32 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                      Write(Html.DisplayFor(model => model.DescricaoTopo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""block-content"">
                        <div class=""clean-blog-post"">
                            <div class=""row"">
                                <div class=""col-lg-5"">
                                    <img class=""rounded img-fluid""");
            BeginWriteAttribute("src", " src=\"", 1050, "\"", 1095, 1);
#nullable restore
#line 38 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 1056, Html.DisplayFor(model => model.UrlImg), 1056, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <p>\n                                        Autor: ");
#nullable restore
#line 40 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </p>\n                                </div>\n                                <div class=\"col-lg-7\">\n                                    <h3>");
#nullable restore
#line 44 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.NomeReceita));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                    <p>\n                                        <i class=\"fas fa-utensils\"></i>\n                                        <strong> Rendimento ");
#nullable restore
#line 47 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.NumPorcoes));

#line default
#line hidden
#nullable disable
            WriteLiteral(" porções</strong>\n                                    </p>\n                                    <p>\n                                        <i class=\"fas fa-clock\"></i>\n                                        <strong> Preparo Médio ( ");
#nullable restore
#line 51 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.TempoPreparo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</strong>\n                                    </p>\n                                    <p>\n                                        <i class=\"fas fa-fire\"></i>\n                                        <strong> Calorias: ");
#nullable restore
#line 55 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.Calorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                                    </p>\n                                    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a26a1696322d2b0eeb416c0fe9f562962e378dd11091", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n");
            WriteLiteral("                        <p>\n                            ");
#nullable restore
#line 64 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n");
            WriteLiteral("                        <h3>Ingredientes</h3>\n");
#nullable restore
#line 68 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                        var todosIngs = Model.Ingredientes.ToString();
                        string[] ingsPorParte = todosIngs.Split('_');

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!--aux para classes dinamicas-->\n");
#nullable restore
#line 71 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                        var cont1 = 0;
                        var cont2 = 0;
                        foreach (var parte in ingsPorParte)
                        {
                            cont1++;
                            string[] ings = parte.Split(';');
                            foreach (var i in ings)
                            {
                                cont2++;
                                if (i == ings[0] && ingsPorParte.Length > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h4>");
#nullable restore
#line 82 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                   Write(ings[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 83 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                }
                                else if (i == ings[ings.Length - 1])
                                {
                                    continue;
                                }
                                else
                                {
                                    var check1 = cont1 + "ings" + cont2;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <fieldset class=\"check-image\">\n                                        <label");
            BeginWriteAttribute("for", " for=\"", 3932, "\"", 3945, 1);
#nullable restore
#line 92 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 3938, check1, 3938, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-3 d-flex\">\n                                            <input class=\" text-center\" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 4055, "\"", 4069, 1);
#nullable restore
#line 93 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 4062, check1, 4062, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4070, "\"", 4082, 1);
#nullable restore
#line 93 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 4075, check1, 4075, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i></i>\n                                            <p class=\"mt-1\"><span");
            BeginWriteAttribute("class", " class=\"", 4157, "\"", 4165, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 94 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\n                                        </label>\n                                    </fieldset>\n");
#nullable restore
#line 97 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>Modo de Preparo:</h3>\n");
#nullable restore
#line 101 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                        var todosMod = Model.ModoPreparo;
                        string[] modPorParte = todosMod.ToString().Split('_');

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!--aux para classes dinamicas-->\n");
#nullable restore
#line 104 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                        var contAux = 0;
                        var cont = 1;

                        foreach (var parteMod in modPorParte)
                        {
                            contAux++;
                            string[] mod = parteMod.Split(';');

                            foreach (var b in mod)
                            {
                                if (b == mod[0] && modPorParte.Length > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h4>");
#nullable restore
#line 116 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                   Write(mod[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 117 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                }
                                else if (b == mod[mod.Length - 1])
                                {
                                    continue;
                                }
                                else
                                {
                                    var check = contAux + "check" + cont;
                                    var texto = contAux + "texto" + cont;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("class", " class=\"", 5603, "\"", 5611, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        <fieldset class=\"check-image\">\n                                            <label");
            BeginWriteAttribute("for", " for=\"", 5735, "\"", 5747, 1);
#nullable restore
#line 128 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 5741, check, 5741, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5748, "\"", 5767, 2);
            WriteAttributeValue("", 5756, "ml-3", 5756, 4, true);
#nullable restore
#line 128 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue(" ", 5760, texto, 5761, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                <input");
            BeginWriteAttribute("class", " class=\"", 5824, "\"", 5850, 2);
#nullable restore
#line 129 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 5832, check, 5832, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5838, "text-center", 5839, 12, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 5867, "\"", 5880, 1);
#nullable restore
#line 129 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 5874, check, 5874, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5881, "\"", 5892, 1);
#nullable restore
#line 129 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 5886, check, 5886, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i></i>Passo ");
#nullable restore
#line 129 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                                                                                                    Write(cont);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                <p class=\"ml-3\"><span");
            BeginWriteAttribute("class", " class=\"", 5982, "\"", 5996, 1);
#nullable restore
#line 130 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
WriteAttributeValue("", 5990, texto, 5990, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 130 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                                                 Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\n                                            </label>\n                                        </fieldset>\n                                    </div>\n");
#nullable restore
#line 134 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                    cont++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <script>\n                                        $(document).ready(function () {\n                                            $(\".");
#nullable restore
#line 138 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                           Write(check);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").change(function () {\n                                                if ($(this).prop(\'checked\')) {\n                                                    $(\".");
#nullable restore
#line 140 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                   Write(texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").addClass(\"font-italic tracejado\");\n                                                } else {\n                                                    $(\".");
#nullable restore
#line 142 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                                   Write(texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").removeClass(\"font-italic tracejado\");\n                                                }\n                                            })\n                                        })\n                                    </script>\n");
#nullable restore
#line 147 "C:\estudos\repoRecode2\greentea\greenTea\Views\Receitas\Details.cshtml"
                                }

                            }
                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </section>\n        </div>\n\n    </div>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a26a1696322d2b0eeb416c0fe9f562962e378dd25427", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a26a1696322d2b0eeb416c0fe9f562962e378dd26465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<greenTea.Models.Receita> Html { get; private set; }
    }
}
#pragma warning restore 1591
