#pragma checksum "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d2cc2d14e9adfceb88250f809c888ce6a12833b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamVgc_VGCAnalysis), @"mvc.1.0.view", @"/Views/TeamVgc/VGCAnalysis.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TeamVgc/VGCAnalysis.cshtml", typeof(AspNetCore.Views_TeamVgc_VGCAnalysis))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\_ViewImports.cshtml"
using MSSA_CAD_Project_Lugias_Lair;

#line default
#line hidden
#line 2 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\_ViewImports.cshtml"
using MSSA_CAD_Project_Lugias_Lair.Models;

#line default
#line hidden
#line 3 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\_ViewImports.cshtml"
using MSSA_CAD_Project_Lugias_Lair.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\_ViewImports.cshtml"
using MSSA_CAD_Project_Lugias_Lair.Controllers;

#line default
#line hidden
#line 5 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 6 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d2cc2d14e9adfceb88250f809c888ce6a12833b", @"/Views/TeamVgc/VGCAnalysis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a866b566b9c86a40203d5d2de7f8c66fc437cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamVgc_VGCAnalysis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string[]>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TeamVgc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VGCAnalysis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VGCTeamPicker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContentHub", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
  
    ViewBag.Title = "Generate VGC Teams";

#line default
#line hidden
            BeginContext(73, 552, true);
            WriteLiteral(@"<!-- This will be where users can see all of the possible 4-Pokemon Teams that they could make from a given 6-Pokemon team -->


<header class=""text-center"">
    <h1>VGC Teams Generator</h1>
    <p>This page is where users will generate combinations of 4-Pokemon teams for a VGC match from a given 6-Pokemon team</p>
    <p>Note: This page is currently only a demo, and therefore it comes pre-populated with a group of VGC combinations. Enter your own team of 6 Pokemon below in order to generate a fresh set of VGC combinations.</p>
</header>
");
            EndContext();
            BeginContext(625, 1057, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2cc2d14e9adfceb88250f809c888ce6a12833b7382", async() => {
                BeginContext(695, 980, true);
                WriteLiteral(@"
    <h3>Enter 6 Pokemon as a Base Team to generate VGC Teams:</h3>
    <div class=""form-group"">
        <label>Pokemon One: </label>
        <input type=""text"" name=""pokemonOne"" />
    </div>
    <div class=""form-group"">
        <label>Pokemon Two:</label>
        <input type=""text"" name=""pokemonTwo"" />
    </div>
    <div class=""form-group"">
        <label>Pokemon Three:</label>
        <input type=""text"" name=""pokemonThree"" />
    </div>
    <div class=""form-group"">
        <label>Pokemon Four:</label>
        <input type=""text"" name=""pokemonFour"" />
    </div>
    <div class=""form-group"">
        <label>Pokemon Five:</label>
        <input type=""text"" name=""pokemonFive"" />
    </div>
    <div class=""form-group"">
        <label>Pokemon Six:</label>
        <input type=""text"" name=""pokemonSix"" />
    </div>
    <div class=""text-center"">
        <input class=""btn btn-primary"" type=""submit"" value=""Generate VGC Team Combos"" />
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1682, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
 for (int i = 0; i < 15; i++)
{

#line default
#line hidden
            BeginContext(1718, 102, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <h4 class=\"text-center\">VGC Team Combination #");
            EndContext();
            BeginContext(1821, 1, false);
#line 47 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1822, 340, true);
            WriteLiteral(@"</h4>
            <tr>
                <th scope=""col"">Pokemon One</th>
                <th scope=""col"">Pokemon Two</th>
                <th scope=""col"">Pokemon Three</th>
                <th scope=""col"">Pokemon Four</th>
            </tr>
        </thead>
        <tbody>
                <tr>
                    <td scope=""row"">");
            EndContext();
            BeginContext(2163, 11, false);
#line 57 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
                               Write(Model[i][0]);

#line default
#line hidden
            EndContext();
            BeginContext(2174, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2206, 11, false);
#line 58 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
                   Write(Model[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(2217, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2249, 11, false);
#line 59 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
                   Write(Model[i][2]);

#line default
#line hidden
            EndContext();
            BeginContext(2260, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2292, 11, false);
#line 60 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
                   Write(Model[i][3]);

#line default
#line hidden
            EndContext();
            BeginContext(2303, 62, true);
            WriteLiteral("</td>\r\n                </tr>\r\n        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 64 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\TeamVgc\VGCAnalysis.cshtml"
}

#line default
#line hidden
            BeginContext(2368, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2381, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2cc2d14e9adfceb88250f809c888ce6a12833b13609", async() => {
                BeginContext(2460, 28, true);
                WriteLiteral("Conditional VGC Battle Teams");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2492, 24, true);
            WriteLiteral("\r\n</div>\r\n<footer>\r\n    ");
            EndContext();
            BeginContext(2516, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2cc2d14e9adfceb88250f809c888ce6a12833b15321", async() => {
                BeginContext(2588, 21, true);
                WriteLiteral("Return to Content Hub");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2613, 19, true);
            WriteLiteral("\r\n</footer>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string[]>> Html { get; private set; }
    }
}
#pragma warning restore 1591