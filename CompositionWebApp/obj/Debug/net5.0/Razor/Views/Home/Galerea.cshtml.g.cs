#pragma checksum "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e940faa7ef9c3e4325f639b0f2626f3840e5f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Galerea), @"mvc.1.0.view", @"/Views/Home/Galerea.cshtml")]
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
#line 1 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\_ViewImports.cshtml"
using CompositionWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\_ViewImports.cshtml"
using CompositionWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\_ViewImports.cshtml"
using CompositionWebApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e940faa7ef9c3e4325f639b0f2626f3840e5f78", @"/Views/Home/Galerea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88cfa65d076d275d24a8f9d190dadf2540289025", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Galerea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GalereaModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Galerea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
  
	ViewData["Title"] = "Galerea";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
  	Composition composition = Model.db.Compositions.Find(Model.SelectedId);
	string name = composition.GetDeShiffovkaName(Model.Key);
	int left  = Model.PhotoId - 1;
	int right = Model.PhotoId + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"Centr\">");
#nullable restore
#line 12 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
             Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<div class=\"col-lg-12 mr-2 ml-2\">\r\n\t<img class=\"img-thumbnail displayed\"");
            BeginWriteAttribute("src", " src=\"", 417, "\"", 484, 1);
#nullable restore
#line 16 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue("", 423, Url.Action("GetedImage", "Home", new { id = Model.PhotoId }), 423, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n<div class=\"row\">\t\r\n\t<div class=\"Centr\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div  style=\"margin-bottom:10%\">\r\n");
#nullable restore
#line 22 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
                 using (Html.BeginForm("Galerea", "Home", FormMethod.Post))
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
                     if (Model.Maybe != 1)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 743, "\"", 756, 1);
#nullable restore
#line 26 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue("", 751, left, 751, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t<input type=\"submit\" class=\"ButtOpen Butt\" style=\"display: block; margin-left: auto;\" value=\"Left\" />\r\n");
#nullable restore
#line 28 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
                     
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t\t<div >\r\n");
#nullable restore
#line 32 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
                 using (Html.BeginForm("Galerea", "Home", FormMethod.Post))
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
                     if (Model.Maybe != 2)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1053, "\"", 1067, 1);
#nullable restore
#line 36 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue("", 1061, right, 1061, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t\t<input type=\"submit\" class=\"ButtOpen Butt\" value=\"Right\" />\r\n");
#nullable restore
#line 38 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
                     
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t</div>\r\n</div>\r\n<div class=\"row\">\r\n\t\t<div class=\"Centr\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e940faa7ef9c3e4325f639b0f2626f3840e5f788928", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1349, "\"", 1382, 1);
#nullable restore
#line 49 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue("", 1357, composition.IdFirstPhoto, 1357, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t<input type=\"submit\" class=\"ButtOpen Butt RowButton\" value=\"<<<\" />\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
                 for (int i = Model.MinId; i < Model.MaxId; i++)
				{
					string color = (composition.IdFirstPhoto + i == Model.PhotoId) ? "#423333" : "gray";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e940faa7ef9c3e4325f639b0f2626f3840e5f7811489", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1719, "\"", 1758, 1);
#nullable restore
#line 56 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue("", 1727, i + composition.IdFirstPhoto, 1727, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t<input type=\"submit\" class=\"ButtOpen Butt RowButton\"");
                BeginWriteAttribute("style", " style=\"", 1822, "\"", 1854, 2);
                WriteAttributeValue("", 1830, "background-color:", 1830, 17, true);
#nullable restore
#line 57 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue(" ", 1847, color, 1848, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1855, "\"", 1869, 1);
#nullable restore
#line 57 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue("", 1863, i+1, 1863, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e940faa7ef9c3e4325f639b0f2626f3840e5f7814701", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1986, "\"", 2052, 1);
#nullable restore
#line 61 "C:\Users\Fujitsu\source\repos\CompositionWebApp\CompositionWebApp\Views\Home\Galerea.cshtml"
WriteAttributeValue("", 1994, composition.IdFirstPhoto + composition.NumberPhotos - 1, 1994, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t<input type=\"submit\" class=\"ButtOpen Butt RowButton\" value=\">>>\" />\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n\t</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GalereaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
