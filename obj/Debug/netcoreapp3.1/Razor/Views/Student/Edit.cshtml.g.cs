#pragma checksum "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c53ab769ae8b9c543efa1daf0167e4bc0965652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Edit), @"mvc.1.0.view", @"/Views/Student/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c53ab769ae8b9c543efa1daf0167e4bc0965652", @"/Views/Student/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186a325e9be5884874025fb3b979139569bc8ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/student/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c53ab769ae8b9c543efa1daf0167e4bc09656525153", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c53ab769ae8b9c543efa1daf0167e4bc09656525415", async() => {
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
                WriteLiteral("\r\n    <title>Student Entry</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c53ab769ae8b9c543efa1daf0167e4bc09656527333", async() => {
                WriteLiteral("\r\n    <input type=\"text\" hidden");
                BeginWriteAttribute("value", " value=\"", 228, "\"", 245, 1);
#nullable restore
#line 7 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 236, Model.Id, 236, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" />\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Code</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 380, "\"", 399, 1);
#nullable restore
#line 10 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 388, Model.Code, 388, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Code\" required>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Name</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 555, "\"", 574, 1);
#nullable restore
#line 14 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 563, Model.Name, 563, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" required>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Email</label>\r\n        <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 732, "\"", 752, 1);
#nullable restore
#line 18 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 740, Model.Email, 740, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Email\">\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Address</label>\r\n        <textarea name=\"Address\" class=\"form-control\">");
#nullable restore
#line 22 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
                                                 Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Course</label>\r\n        <select name=\"CourseId\" class=\"form-control\">\r\n");
#nullable restore
#line 27 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
             foreach (var item in ViewBag.CourseList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c53ab769ae8b9c543efa1daf0167e4bc096565210466", async() => {
#nullable restore
#line 29 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
                                       Write(item.Text);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
                   WriteLiteral(item.Value);

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
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Phone</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1379, "\"", 1399, 1);
#nullable restore
#line 35 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 1387, Model.Phone, 1387, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Phone\" required>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Father Name</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1563, "\"", 1588, 1);
#nullable restore
#line 39 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 1571, Model.FatherName, 1571, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FatherName\" required>\r\n    </div>\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">Date of Birth</label>\r\n        <input type=\"date\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1759, "\"", 1800, 1);
#nullable restore
#line 43 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 1767, Model.DOB.ToString("yyyy-MM-dd"), 1767, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"DOB\" required>\r\n    </div>\r\n\r\n    <div class=\"mb-3\">\r\n        <label class=\"form-label\">National Registration Card</label>\r\n        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1979, "\"", 1997, 1);
#nullable restore
#line 48 "C:\Users\Min Khant Maung\source\repos\SFMS\SFMS\Views\Student\Edit.cshtml"
WriteAttributeValue("", 1987, Model.NRC, 1987, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""NRC"" required>
    </div>




    <div class=""mb-3"">
        <div class=""row"">
            <div class=""col"">
                <input type=""submit"" class=""btn btn-success"" value=""Entry"" />
            </div>
            <div class=""col"">
                <input type=""reset"" class=""btn btn-secondary"" value=""Cancel"" />
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
