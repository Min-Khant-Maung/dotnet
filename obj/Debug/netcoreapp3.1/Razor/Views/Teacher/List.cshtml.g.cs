#pragma checksum "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb62199be81f3094967d7155243e7a7c0ffa4fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_List), @"mvc.1.0.view", @"/Views/Teacher/List.cshtml")]
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
#line 1 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\_ViewImports.cshtml"
using SFMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\_ViewImports.cshtml"
using SFMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\_ViewImports.cshtml"
using SFMS.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cb62199be81f3094967d7155243e7a7c0ffa4fe", @"/Views/Teacher/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186a325e9be5884874025fb3b979139569bc8ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SFMS.Models.ViewModel.TeacherViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cb62199be81f3094967d7155243e7a7c0ffa4fe4119", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cb62199be81f3094967d7155243e7a7c0ffa4fe4381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Teacher List</title>\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
 if (TempData["msg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
   Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<a href=""/Teacher/Entry"" class=""btn btn-info"" role=""button"">Create</a>
<table class=""table"">
    <thead>
        <tr>
            <td>Name</td>
            <td>Email</td>
            <td>Address</td>
            <td>Position</td>
            <td>Phone</td>

            <td>Action</td>
            <td></td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
         foreach (var t in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
               Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
               Write(t.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
               Write(t.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
               Write(t.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
               Write(t.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 924, "\"", 953, 2);
            WriteAttributeValue("", 931, "/Teacher/Edit?Id=", 931, 17, true);
#nullable restore
#line 36 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
WriteAttributeValue("", 948, t.Id, 948, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" role=\"button\">Edit</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1061, 2);
            WriteAttributeValue("", 1037, "/Teacher/Delete?Id=", 1037, 19, true);
#nullable restore
#line 37 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
WriteAttributeValue("", 1056, t.Id, 1056, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"return confirm(\'Are you sure to delete this record?\')\">Delete</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Teacher\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SFMS.Models.ViewModel.TeacherViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
