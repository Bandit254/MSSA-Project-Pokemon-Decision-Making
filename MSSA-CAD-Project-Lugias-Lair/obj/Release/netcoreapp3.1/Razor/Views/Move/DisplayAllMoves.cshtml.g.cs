#pragma checksum "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f50d2298a6dfa38ff5107ff79ed21394efa2e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Move_DisplayAllMoves), @"mvc.1.0.view", @"/Views/Move/DisplayAllMoves.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Move/DisplayAllMoves.cshtml", typeof(AspNetCore.Views_Move_DisplayAllMoves))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f50d2298a6dfa38ff5107ff79ed21394efa2e43", @"/Views/Move/DisplayAllMoves.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a866b566b9c86a40203d5d2de7f8c66fc437cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Move_DisplayAllMoves : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PokemonMove>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Move", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayAllMoves", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
  
    ViewBag.Title = "Display All Moves";

#line default
#line hidden
            BeginContext(75, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f50d2298a6dfa38ff5107ff79ed21394efa2e435471", async() => {
                BeginContext(81, 42, true);
                WriteLiteral("\r\n    <h3 class=\"text-center\">Moves</h3>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(132, 817, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f50d2298a6dfa38ff5107ff79ed21394efa2e436696", async() => {
                BeginContext(202, 740, true);
                WriteLiteral(@"
    <p>
        Search by Move Name: <input type=""text"" name=""searchName"" />
        Search by Move Type: <input type=""number"" name=""searchType"" />
        Search by Move Category: <input type=""text"" name=""searchCategory"" />
        <input type=""submit"" value=""Filter"" />
    </p>
    <p class=""text-center"">
        <h6 class=""text-center"">Move Types</h6>
        1 = Normal, 2 = Fire, 3 = Water, 4 = Grass, 5 = Electric, 6 = Ice, 7 = Fighting, 8 = Poison, 9 = Ground, 10 = Flying, 11 = Psychic, 12 = Bug, 13 = Rock, 14 = Ghost, 15 = Dragon, 16 = Dark, 17 = Steel, 18 = Fairy
    </p>
    <p class=""text-center"">
        <h6 class=""text-center"">Move Categories</h6>
        Physical | Special | Non-Damage Dealing
    </p>
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
            BeginContext(949, 465, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Type</th>
            <th scope=""col"">Category</th>
            <th scope=""col"">Attack Strength</th>
            <th scope=""col"">Accuracy</th>
            <th scope=""col"">Power Points</th>
            <th scope=""col"">Additional Effect</th>
            <th scope=""col"">Prob. of Addtnl. Effect</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 38 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
         foreach (var m in Model)
        {

#line default
#line hidden
            BeginContext(1460, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(1511, 10, false);
#line 41 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
                           Write(m.MoveName);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1549, 10, false);
#line 42 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
               Write(m.MoveType);

#line default
#line hidden
            EndContext();
            BeginContext(1559, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1587, 14, false);
#line 43 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
               Write(m.MoveCategory);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1629, 11, false);
#line 44 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
               Write(m.MovePower);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1668, 14, false);
#line 45 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
               Write(m.MoveAccuracy);

#line default
#line hidden
            EndContext();
            BeginContext(1682, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1710, 12, false);
#line 46 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
               Write(m.MovePoints);

#line default
#line hidden
            EndContext();
            BeginContext(1722, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1750, 12, false);
#line 47 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
               Write(m.MoveEffect);

#line default
#line hidden
            EndContext();
            BeginContext(1762, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1790, 16, false);
#line 48 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
               Write(m.MoveEffectProb);

#line default
#line hidden
            EndContext();
            BeginContext(1806, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\pc\source\repos\MSSA-Project-Pokemon-Decision-Making\MSSA-CAD-Project-Lugias-Lair\Views\Move\DisplayAllMoves.cshtml"
        }

#line default
#line hidden
            BeginContext(1843, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PokemonMove>> Html { get; private set; }
    }
}
#pragma warning restore 1591